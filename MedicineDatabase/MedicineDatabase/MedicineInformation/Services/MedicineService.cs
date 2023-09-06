using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using MedicineDatabase.Languages;
using MedicineDatabase.MedicineInformation.Controllers;
using MedicineDatabase.MedicineInformation.Models;
using MedicineDatabase.MedicineInformation.Domain;

namespace MedicineDatabase.MedicineInformation.Services
{
    public class MedicineService : IMedicineService
    {
        private MedicineController medicineController;
        public MedicineService(MedicineController controller)
        {
            medicineController = controller;
        }

        /// <summary>
        /// This function load medicine pills from database according to user's searched text and filter.
        /// It also takes into account information bout user's health, he filled in before search
        /// </summary>
        /// <param name="searchText">Text to search</param>
        /// <param name="filter">What filter to use</param>
        /// <param name="healthProblems">Array of health problems</param>
        /// <param name="alergies">Array of allergies</param>
        /// <returns>Returns list of pills, that meet the requirements</returns>
        /// <exception cref="Exception">Thrown when lading medicine pills failed</exception>
        public List<MedicineModel> LoadMedicinePills(string searchText, string filter, string[] healthProblems, string[] alergies)
        {
            List<MedicineModel> medicines = new List<MedicineModel>();

            string procedure = "";

            string _name = Language.FilterName;
            if (filter.Equals(Language.FilterName))
            {
                procedure = "[dbo].[GetMedicinePillsByName]";

            }
            else if (filter.Equals(Language.FilterIndications))
            {
                procedure = "[dbo].[GetMedicinePillsByIndications]";
            }
            else if (filter.Equals(Language.FilterContraindications))
            {
                procedure = "[dbo].[GetMedicinePillsByContraindications]";
            }
            else if (filter.Equals(Language.FilterComposition))
            {
                procedure = "[dbo].[GetMedicinePillsByComposition]";
            }
            else if (filter.Equals(Language.FilterSideEffect))
            {
                procedure = "[dbo].[GetMedicinePillsBySideEffects]";
            }
            else if (filter.Equals(Language.FilterInteractions))
            {
                procedure = "[dbo].[GetMedicinePillsByInteractions]";
            }
            else if (filter.Equals(Language.FilterSubstances))
            {
                procedure = "[dbo].[GetMedicinePillsByMedicalSubstances]";
            }

            List<string> searchExpressions = new List<string>();

            if (healthProblems != null)
            {
                foreach (string element in healthProblems)
                {
                    if (element == "") continue;
                    string expression = $"FORMSOF(FREETEXT, \"{element.Trim()}\")";
                    searchExpressions.Add(expression);
                }
            }

            if (alergies != null)
            {
                foreach (string element in alergies)
                {
                    if (element == "") continue;
                    string expression = $"FORMSOF(FREETEXT, \"{element.Trim()}\")";
                    searchExpressions.Add(expression);
                }
            }

            string result = string.Join(" OR ", searchExpressions);

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["AppDatabase"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    if (conn.State != ConnectionState.Open) conn.Open();

                    using (SqlCommand cmd = new SqlCommand() { CommandText = procedure, Connection = conn, CommandType = CommandType.StoredProcedure })
                    {
                        cmd.CommandTimeout = 0;
                        cmd.Parameters.Add(new SqlParameter() { ParameterName = "searchText", Value = searchText, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });
                        cmd.Parameters.Add(new SqlParameter() { ParameterName = "topN", Value = Const.topN, SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input });
                        cmd.Parameters.Add(new SqlParameter() { ParameterName = "healthConditions", Value = result.Length == 0 ? null : result, SqlDbType = SqlDbType.NVarChar, Direction = ParameterDirection.Input });



                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                medicines.Add(new MedicineModel()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    Name = reader.GetString(reader.GetOrdinal("MedicineName")),
                                    SUKLCode = reader.IsDBNull(reader.GetOrdinal("SUKL_Code")) ? null : reader.GetString(reader.GetOrdinal("SUKL_Code")),
                                    Problem = reader.IsDBNull(reader.GetOrdinal("Problem")) ? null : reader.GetString(reader.GetOrdinal("Problem")),
                                    MedicalPower = reader.IsDBNull(reader.GetOrdinal("MedicalPower")) ? null : reader.GetString(reader.GetOrdinal("MedicalPower")),
                                    Form = reader.IsDBNull(reader.GetOrdinal("Form")) ? null : reader.GetString(reader.GetOrdinal("Form")),
                                    Packing = reader.IsDBNull(reader.GetOrdinal("Packing")) ? null : reader.GetString(reader.GetOrdinal("Packing")),
                                    WayOfUse = reader.IsDBNull(reader.GetOrdinal("WayOfUse")) ? null : reader.GetString(reader.GetOrdinal("WayOfUse")),
                                    Supplement = reader.IsDBNull(reader.GetOrdinal("Supplement")) ? null : reader.GetString(reader.GetOrdinal("Supplement")),
                                    Cover = reader.IsDBNull(reader.GetOrdinal("Cover")) ? null : reader.GetString(reader.GetOrdinal("Cover")),
                                    RegistrationHolder = reader.IsDBNull(reader.GetOrdinal("RegistrationHolder")) ? null : reader.GetString(reader.GetOrdinal("RegistrationHolder")),
                                    HolderCountry = reader.IsDBNull(reader.GetOrdinal("HolderCountry")) ? null : reader.GetString(reader.GetOrdinal("HolderCountry")),
                                    RegistrationState = reader.IsDBNull(reader.GetOrdinal("RegistrationState")) ? null : reader.GetString(reader.GetOrdinal("RegistrationState")),
                                    RegistrationValidTo_DDMMYY = reader.IsDBNull(reader.GetOrdinal("RegistrationValidTo_DDMMYY")) ? null : reader.GetString(reader.GetOrdinal("RegistrationValidTo_DDMMYY")),
                                    UnlimitedRegistration = reader.IsDBNull(reader.GetOrdinal("UnlimitedRegistration")) ? null : reader.GetString(reader.GetOrdinal("UnlimitedRegistration")),
                                    IndicationGroup = reader.IsDBNull(reader.GetOrdinal("IndicationGroup")) ? null : reader.GetString(reader.GetOrdinal("IndicationGroup")),
                                    ATC = reader.IsDBNull(reader.GetOrdinal("ATC")) ? null : reader.GetString(reader.GetOrdinal("ATC")),
                                    ATC_Name = reader.IsDBNull(reader.GetOrdinal("ATC_Name")) ? null : reader.GetString(reader.GetOrdinal("ATC_Name")),
                                    RegistrationNumber = reader.IsDBNull(reader.GetOrdinal("RegistrationNumber")) ? null : reader.GetString(reader.GetOrdinal("RegistrationNumber")),
                                    RegistrationProcedure = reader.IsDBNull(reader.GetOrdinal("RegistrationProcedure")) ? null : reader.GetString(reader.GetOrdinal("RegistrationProcedure")),
                                    WHO_Index = reader.IsDBNull(reader.GetOrdinal("WHO_Index")) ? null : reader.GetString(reader.GetOrdinal("WHO_Index")),
                                    MedicalSubstances = reader.IsDBNull(reader.GetOrdinal("MedicalSubstances")) ? null : reader.GetString(reader.GetOrdinal("MedicalSubstances")),
                                    Dispensing = reader.IsDBNull(reader.GetOrdinal("Dispensing")) ? null : reader.GetString(reader.GetOrdinal("Dispensing")),
                                    Doping = reader.IsDBNull(reader.GetOrdinal("Doping")) ? null : reader.GetString(reader.GetOrdinal("Doping")),
                                    Expiration = reader.IsDBNull(reader.GetOrdinal("Expiration")) ? null : reader.GetString(reader.GetOrdinal("Expiration")),
                                    Expoiration_Type = reader.IsDBNull(reader.GetOrdinal("Expoiration_Type")) ? null : reader.GetString(reader.GetOrdinal("Expoiration_Type")),
                                    RegisteredName = reader.IsDBNull(reader.GetOrdinal("RegisteredName")) ? null : reader.GetString(reader.GetOrdinal("RegisteredName")),
                                    Indications = reader.IsDBNull(reader.GetOrdinal("Indications")) ? null : reader.GetString(reader.GetOrdinal("Indications")),
                                    Contraindications = reader.IsDBNull(reader.GetOrdinal("Contraindications")) ? null : reader.GetString(reader.GetOrdinal("Contraindications")),
                                    SideEffects = reader.IsDBNull(reader.GetOrdinal("SideEffects")) ? null : reader.GetString(reader.GetOrdinal("SideEffects")),
                                    Applicability = reader.IsDBNull(reader.GetOrdinal("Applicability")) ? null : reader.GetString(reader.GetOrdinal("Applicability")),
                                    Warnings = reader.IsDBNull(reader.GetOrdinal("Warnings")) ? null : reader.GetString(reader.GetOrdinal("Warnings")),
                                    Interactions = reader.IsDBNull(reader.GetOrdinal("Interactions")) ? null : reader.GetString(reader.GetOrdinal("Interactions")),
                                    Dosage = reader.IsDBNull(reader.GetOrdinal("Dosage")) ? null : reader.GetString(reader.GetOrdinal("Dosage")),
                                    Compositions = reader.IsDBNull(reader.GetOrdinal("Compositions")) ? null : reader.GetString(reader.GetOrdinal("Compositions")),
                                    Substances = reader.IsDBNull(reader.GetOrdinal("Substances")) ? null : reader.GetString(reader.GetOrdinal("Substances")),
                                    Overdose = reader.IsDBNull(reader.GetOrdinal("Overdose")) ? null : reader.GetString(reader.GetOrdinal("Overdose")),
                                    DocumentFile = new DocumentFile()
                                    {
                                        FileName = reader.IsDBNull(reader.GetOrdinal("DocumentName")) ? null : reader.GetString(reader.GetOrdinal("DocumentName")),
                                        FileType = reader.IsDBNull(reader.GetOrdinal("FileType")) ? null : reader.GetString(reader.GetOrdinal("FileType")),
                                        FileContent = reader.IsDBNull(reader.GetOrdinal("FileContent")) ? null : (byte[])reader["FileContent"],
                                        Size = reader.IsDBNull(reader.GetOrdinal("Size")) ? null : reader.GetString(reader.GetOrdinal("Size")),
                                        CreatedOn = reader.IsDBNull(reader.GetOrdinal("CreatedOn")) ? null : reader.GetDateTime(reader.GetOrdinal("CreatedOn"))
                                    }
                                });
                            }
                            reader.Close();
                        }
                        cmd.Dispose();
                    }

                    conn.Close();
                }
                return medicines;
            }
            catch (Exception e)
            {
                Console.WriteLine($"{this} -> Load medicines failed: {e.Message}");
                throw new Exception(e.Message);
            }
        }
    }
}
