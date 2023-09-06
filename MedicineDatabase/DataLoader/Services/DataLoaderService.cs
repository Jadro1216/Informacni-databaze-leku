using DataLoader.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLoader.Services
{
    internal class DataLoaderService :IDataLoaderService
    {
        private readonly string _connString;
        public DataLoaderService()
        {
            _connString = ConfigurationManager.ConnectionStrings["AppDatabase"].ConnectionString;
        }

        /// <summary>
        /// This function will save medicine data to database
        /// </summary>
        /// <param name="data">List of strings to be saved to database</param>
        /// <exception cref="Exception">Thrown when saving to database fails</exception>
        public void SaveMedicineToDatabase(List<string[]> data)
        {
            DataTable table = new DataTable();
            table.Columns.Add("SUKL_Code", typeof(string));
			table.Columns.Add("MandatoryReport", typeof(string));
			table.Columns.Add("Name", typeof(string));
			table.Columns.Add("MedicalPower", typeof(string));
			table.Columns.Add("Form", typeof(string));
			table.Columns.Add("Packing", typeof(string));
			table.Columns.Add("WayOfUse", typeof(string));
			table.Columns.Add("Supplement", typeof(string));
			table.Columns.Add("Cover", typeof(string));
			table.Columns.Add("RegistrationHolder", typeof(string));
			table.Columns.Add("HolderCountry", typeof(string));
			table.Columns.Add("ActualHolder", typeof(string));
			table.Columns.Add("ActualHolderCountry", typeof(string));
			table.Columns.Add("RegistrationState", typeof(string));
			table.Columns.Add("RegistrationValidTo_DDMMYY", typeof(string));
			table.Columns.Add("UnlimitedRegistration", typeof(string));
			table.Columns.Add("OnMarketTo_DDMMYY", typeof(string));
			table.Columns.Add("IndicationGroup", typeof(string));
			table.Columns.Add("ATC", typeof(string));
			table.Columns.Add("ATC_Name", typeof(string));
			table.Columns.Add("RegistrationNumber", typeof(string));
            table.Columns.Add("ParallelImport_Number", typeof(string));
			table.Columns.Add("ParallelImport_Importer", typeof(string));
			table.Columns.Add("ParallelImport_Country", typeof(string));
			table.Columns.Add("RegistrationProcedure", typeof(string));
			table.Columns.Add("DefinedDailyDose_MedicineAmount", typeof(string));
			table.Columns.Add("DefinedDailyDose_Union", typeof(string));
			table.Columns.Add("DefinedDailyDose_AmountInPackage", typeof(string));
			table.Columns.Add("WHO_Index", typeof(string));
			table.Columns.Add("MedicalSubstances", typeof(string));
			table.Columns.Add("Dispensing", typeof(string));
			table.Columns.Add("Addiction", typeof(string));
			table.Columns.Add("Doping", typeof(string));
			table.Columns.Add("NarVla", typeof(string));
			table.Columns.Add("SuppliedPast_HalfYear", typeof(string));
			table.Columns.Add("Ean", typeof(string));
			table.Columns.Add("Braille", typeof(string));
			table.Columns.Add("Expiration", typeof(string));
            table.Columns.Add("Expoiration_Type", typeof(string));
			table.Columns.Add("RegisteredName", typeof(string));
			table.Columns.Add("MRP_Number", typeof(string));
			table.Columns.Add("LegalRegistrationBase", typeof(string));
			table.Columns.Add("ProtectiveElement", typeof(string));

			table.Rows.Clear();
			for (int i = 1; i < data.Count; i++)
			{
				table.Rows.Add(data[i]);
			}
			try
			{
				using (SqlConnection conn = new SqlConnection(_connString))
				{
					if (conn.State != ConnectionState.Open) conn.Open();
					using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[UpdateMedicinePills]", Connection = conn, CommandType = CommandType.StoredProcedure })
					{
						cmd.CommandTimeout = 0;
						cmd.Parameters.Add(new SqlParameter() { ParameterName = "Pills", Value = table.Rows.Count > 0 ? table : null, SqlDbType = SqlDbType.Structured, Direction = ParameterDirection.Input });

						cmd.ExecuteNonQuery();
						cmd.Dispose();
					}
					conn.Close();
				}
			}
			catch (Exception ex)
			{

				throw new Exception($"Saving medicines to db failed: {ex.Message}.");
			}
        }

        /// <summary>
        /// This function will save structured data to database
        /// </summary>
        /// <param name="structured">Dictionary of structured data to be saved</param>
        /// <exception cref="Exception">Thrown when saving to database fails</exception>
        public void SaveStructuredDataToDatabase(Dictionary<string, Dictionary<string, string>> structured)
        {
            DataTable table = new DataTable();
            table.Columns.Add("DocumentName", typeof(string));
            table.Columns.Add("Indications", typeof(string));
            table.Columns.Add("Contraindications", typeof(string));
            table.Columns.Add("SideEffects", typeof(string));
            table.Columns.Add("Validity", typeof(string));
            table.Columns.Add("Warnings", typeof(string));
            table.Columns.Add("Interactions", typeof(string));
            table.Columns.Add("Dosage", typeof(string));
            table.Columns.Add("Compositions", typeof(string));
            table.Columns.Add("Substances", typeof(string));
            table.Columns.Add("Overdose", typeof(string));

            table.Rows.Clear();

            foreach (KeyValuePair<string, Dictionary<string, string>> entry in structured)
			{
                List<string> _row = new List<string>();
                _row.Add(entry.Key);
				foreach(string value in entry.Value.Values.ToList())
				{
					_row.Add(value);
				}
				table.Rows.Add(_row.ToArray());
			}
            try
            {
                using (SqlConnection conn = new SqlConnection(_connString))
                {
                    if (conn.State != ConnectionState.Open) conn.Open();
                    using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[UpdateStructuredMedicineDocuments]", Connection = conn, CommandType = CommandType.StoredProcedure })
                    {
                        cmd.CommandTimeout = 0;
                        cmd.Parameters.Add(new SqlParameter() { ParameterName = "StructuredData", Value = table.Rows.Count > 0 ? table : null, SqlDbType = SqlDbType.Structured, Direction = ParameterDirection.Input });

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception($"Saving medicines to db failed: {ex.Message}.");
            }
        }

        /// <summary>
        /// This function saves medicine and document mapping to database
        /// </summary>
        /// <param name="mapping">List of mapping values</param>
        /// <exception cref="Exception">Thrown when saving to database fails</exception>
		public void SaveMappingToDatabase(List<string[]> mapping)
		{
            DataTable table = new DataTable();
            table.Columns.Add("MedicineSUKL", typeof(string));
            table.Columns.Add("DocumentName", typeof(string));

            table.Rows.Clear();
            for (int i = 1; i < mapping.Count; i++)
			{
				string[] values = mapping[i];
                table.Rows.Add(values[0], values[3]);
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connString))
                {
                    if (conn.State != ConnectionState.Open) conn.Open();
                    using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[UpdateMedicineSPC_Mapping]", Connection = conn, CommandType = CommandType.StoredProcedure })
                    {
                        cmd.CommandTimeout = 0;
                        cmd.Parameters.Add(new SqlParameter() { ParameterName = "Mapping", Value = table.Rows.Count > 0 ? table : null, SqlDbType = SqlDbType.Structured, Direction = ParameterDirection.Input });

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Saving SPC documents mapping to db failed: {ex.Message}.");
            }
        }

        /// <summary>
        /// This function saves files and its informations to database
        /// </summary>
        /// <param name="files">Array of file names</param>
        /// <exception cref="Exception">Thrown when saving to database fails</exception>
		public void SaveFilesToDatabase(string[] files)
		{
			foreach (string file in files)
			{
				var fileInfo = new FileInfo(file);
				byte[] content = File.ReadAllBytes(file);

                try
                {
                    using (SqlConnection conn = new SqlConnection(_connString))
                    {
                        if (conn.State != ConnectionState.Open) conn.Open();
                        using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[UpdateSPCDocuments]", Connection = conn, CommandType = CommandType.StoredProcedure })
                        {
                            cmd.CommandTimeout = 0;
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "FileName", Value = fileInfo.Name, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "FileType", Value = fileInfo.Extension, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "FileContent", Value = content, SqlDbType = SqlDbType.VarBinary, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Size", Value = DocumentHelper.SizeSuffix(fileInfo.Length), SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "CreatedOn", Value = fileInfo.CreationTime, SqlDbType = SqlDbType.DateTime, Direction = ParameterDirection.Input });

                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Saving document {fileInfo.Name} to db failed: {ex.Message}.");
                }
            }
		}
        
        /// <summary>
        /// This function saves pharmacy object to database
        /// </summary>
        /// <param name="data">List of pharmacy objects</param>
        /// <exception cref="Exception">Thrown when saving to database fails</exception>
        public void SavePharmacies(List<PharmacyObject> data)
        {
            DataTable webTable = new DataTable();
            webTable.Columns.Add("Value", typeof(string));
            DataTable phoneTable = new DataTable();
            phoneTable.Columns.Add("Value", typeof(string));
            DataTable emailTable = new DataTable();
            emailTable.Columns.Add("Value", typeof(string));

            DataTable hoursTable = new DataTable();
            hoursTable.Columns.Add("Day", typeof(string));
            hoursTable.Columns.Add("Time", typeof(string));

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["AppDatabase"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    if (conn.State != ConnectionState.Open) conn.Open();
                    int id;
                    foreach (var item in data)
                    {
                        phoneTable.Rows.Clear();
                        emailTable.Rows.Clear();
                        webTable.Rows.Clear();
                        hoursTable.Rows.Clear();
                        item.Kontakty.Telefon.Distinct().ToList().ForEach(itm =>
                        {
                            if (itm != null) phoneTable.Rows.Add(itm);
                        });
                        item.Kontakty.Email.Distinct().ToList().ForEach(itm =>
                        {
                            if (itm != null) emailTable.Rows.Add(itm);
                        });
                        item.Kontakty.Web.Distinct().ToList().ForEach(itm =>
                        {
                            if (itm != null) webTable.Rows.Add(itm);
                        });
                        item.OteviraciDoba.Polozky.ForEach(itm =>
                        {
                            if (itm != null)
                            {
                                string day = "";
                                switch (itm.Den)
                                {
                                    case 1:
                                        day = "PO";
                                        break;
                                    case 2:
                                        day = "UT";
                                        break;
                                    case 3:
                                        day = "ST";
                                        break;
                                    case 4:
                                        day = "ŠT";
                                        break;
                                    case 5:
                                        day = "PI";
                                        break;
                                    case 6:
                                        day = "SO";
                                        break;
                                    case 7:
                                        day = "NE";
                                        break;
                                    case 8:
                                        day = "SVIATOK";
                                        break;
                                    default:
                                        break;
                                }
                                var times = itm.Doby[0];

                                string time = times.Od + " - " + times.Do;
                                hoursTable.Rows.Add(day, time);
                            }
                        });

                        using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[UpdatePharmacies]", Connection = conn, CommandType = CommandType.StoredProcedure })
                        {
                            cmd.CommandTimeout = 0;
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Name", Value = item.Nazev, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "WorkPlaceCode", Value = item.KodPracoviste, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "PharmacyCode", Value = item.KodLekarny, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Icz", Value = item.Icz, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Ico", Value = item.Ico, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "PharmacyType", Value = item.TypLekarny, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Latitude", Value = item.Souradnice.Gpsn, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Longitude", Value = item.Souradnice.Gpse, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "HasEmergency", Value = item.OteviraciDoba.Pohotovost, SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "ExtendedWorkTime", Value = item.OteviraciDoba.RozsirenaPracDoba, SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Input });
                            //cmd.Parameters.Add(new SqlParameter() { ParameterName = "NewId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output });

                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "City", Value = item.Adresa.Obec, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Street", Value = item.Adresa.Ulice, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "OrientationNumber", Value = item.Adresa.CisloOrientacni, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "DescriptiveNumber", Value = item.Adresa.CisloPopisne, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Psc", Value = item.Adresa.Psc, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "PersonName", Value = item.VedouciLekarnik.Jmeno, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "PersonSurname", Value = item.VedouciLekarnik.Prijmeni, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "TitleBefore", Value = item.VedouciLekarnik.TitulPred, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "TitleAfter", Value = item.VedouciLekarnik.TitulZa, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Phones", Value = phoneTable.Rows.Count > 0 ? phoneTable : null, SqlDbType = SqlDbType.Structured, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Emails", Value = emailTable.Rows.Count > 0 ? emailTable : null, SqlDbType = SqlDbType.Structured, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Webs", Value = webTable.Rows.Count > 0 ? webTable : null, SqlDbType = SqlDbType.Structured, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Hours", Value = hoursTable.Rows.Count > 0 ? hoursTable : null, SqlDbType = SqlDbType.Structured, Direction = ParameterDirection.Input });

                            cmd.ExecuteNonQuery();
                            //id = (int)cmd.Parameters["NewId"].Value;
                            cmd.Dispose();
                        }

                        #region Possible code (different approach)
                        /*
                        //-------- address
                        using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[UpdatePharmacyAddress]", Connection = conn, CommandType = CommandType.StoredProcedure })
                        {
                            cmd.CommandTimeout = 0;
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "PharmacyId", Value = id, SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "City", Value = item.Adresa.Obec, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Street", Value = item.Adresa.Ulice, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "OrientationNumber", Value = item.Adresa.CisloOrientacni, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "DescriptiveNumber", Value = item.Adresa.CisloPopisne, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Psc", Value = item.Adresa.Psc, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });

                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }

                        //-------- pharmacist
                        using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[UpdatePharmacist]", Connection = conn, CommandType = CommandType.StoredProcedure })
                        {
                            cmd.CommandTimeout = 0;
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "PharmacyId", Value = id, SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Name", Value = item.VedouciLekarnik.Jmeno, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Surname", Value = item.VedouciLekarnik.Prijmeni, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "TitleBefore", Value = item.VedouciLekarnik.TitulPred, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "TitleAfter", Value = item.VedouciLekarnik.TitulZa, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });

                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }

                        //--------- phones
                        item.Kontakty.Telefon.ForEach(item =>
                        {
                            table.Rows.Add(id, item);
                        });

                        using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[UpdatePharmacyPhone]", Connection = conn, CommandType = CommandType.StoredProcedure })
                        {
                            cmd.CommandTimeout = 0;
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Phones", Value = table, SqlDbType = SqlDbType.Structured, Direction = ParameterDirection.Input });
                            
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                        table.Rows.Clear();

                        //------ emails
                        item.Kontakty.Email.ForEach(item =>
                        {
                            table.Rows.Add(id, item);
                        });

                        using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[UpdatePharmacyEmail]", Connection = conn, CommandType = CommandType.StoredProcedure })
                        {
                            cmd.CommandTimeout = 0;
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Emails", Value = table, SqlDbType = SqlDbType.Structured, Direction = ParameterDirection.Input });

                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                        table.Rows.Clear();

                        //------ webs
                        item.Kontakty.Web.ForEach(item =>
                        {
                            table.Rows.Add(id, item);
                        });

                        using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[UpdatePharmacyWeb]", Connection = conn, CommandType = CommandType.StoredProcedure })
                        {
                            cmd.CommandTimeout = 0;
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Webs", Value = table, SqlDbType = SqlDbType.Structured, Direction = ParameterDirection.Input });

                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                        table.Rows.Clear();

                        //------ opening hours
                        item.OteviraciDoba.Polozky.ForEach(item =>
                        {
                            string hours = "";
                            switch (item.Den)
                            {
                                case 1:
                                    hours = "PO: ";
                                    break;
                                case 2:
                                    hours = "UT: ";
                                    break;
                                case 3:
                                    hours = "ST: ";
                                    break;
                                case 4:
                                    hours = "SŤ: ";
                                    break;
                                case 5:
                                    hours = "PI: ";
                                    break;
                                case 6:
                                    hours = "SO: ";
                                    break;
                                case 7:
                                    hours = "NE: ";
                                    break;
                                case 8:
                                    hours = "SVIATOK: ";
                                    break;
                                default:
                                    break;
                            }
                            var times = item.Doby[0];
                            hours += times.Od + " - " + times.Do;
                            hoursTable.Rows.Add(id, hours);
                        });

                        using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[UpdatePharmacyHours]", Connection = conn, CommandType = CommandType.StoredProcedure })
                        {
                            cmd.CommandTimeout = 0;
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "Hours", Value = hoursTable, SqlDbType = SqlDbType.Structured, Direction = ParameterDirection.Input });

                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                        hoursTable.Rows.Clear();
                        */

                        #endregion

                    }
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// This function will get pharmacies from API
        /// </summary>
        /// <returns>String result of response</returns>
        public string GetPharmacies()
        {
            try
            {
                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(Const.PharmaciesApiUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    var dataObjects = response.Content.ReadAsStringAsync().Result;
                    return dataObjects;
                }
                else
                {
                    throw new Exception($"Response status code {(int)response.StatusCode} ({response.ReasonPhrase})");
                }

                client.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Get pharmacies from api failed {0}", e.Message);
                throw e;
            }
        }

        public static class DocumentHelper
        {
            /// <summary>
            /// This function creates more human readable information about file size
            /// </summary>
            /// <param name="value">File size in bytes</param>
            /// <param name="decimalPlaces">How many decimal places we want in the result size</param>
            /// <returns></returns>
            /// <exception cref="ArgumentOutOfRangeException"></exception>
            public static string SizeSuffix(Int64 value, int decimalPlaces = 1)
            {
                string[] SizeSuffixes =
                          { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
                if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
                if (value < 0) { return "-" + SizeSuffix(-value, decimalPlaces); }
                if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }

                // mag is 0 for bytes, 1 for KB, 2, for MB, etc.
                int mag = (int)Math.Log(value, 1024);

                // 1L << (mag * 10) == 2 ^ (10 * mag) 
                // [i.e. the number of bytes in the unit corresponding to mag]
                decimal adjustedSize = (decimal)value / (1L << (mag * 10));

                // make adjustment when the value is large enough that
                // it would round up to 1000 or more
                if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
                {
                    mag += 1;
                    adjustedSize /= 1024;
                }

                return string.Format("{0:n" + decimalPlaces + "} {1}",
                    adjustedSize,
                    SizeSuffixes[mag]);
            }
        }
    }
}
