using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using MedicineDatabase.Pharmacies.Models;
using MedicineDatabase.Pharmacies.Controllers;

namespace MedicineDatabase.Pharmacies.Services
{
    public class PharmacyService : IPharmacyService
    {
        private PharmacyController pharmacyController;
        public PharmacyService(PharmacyController controller) 
        {
            pharmacyController = controller;
        }

        /// <summary>
        /// This function loads all pharmacies from database and returns them as a list
        /// </summary>
        /// <returns>List of Pharmacy objects/returns>
        /// <exception cref="Exception">Thrown when loading pharmacies from db failed</exception>
        public List<PharmacyModel> LoadPharmacies()
        {
            List<PharmacyModel> pharmacies = new List<PharmacyModel>();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["AppDatabase"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    if (conn.State != ConnectionState.Open) conn.Open();


                    using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[GetAllPharmacies]", Connection = conn, CommandType = CommandType.StoredProcedure })
                    {
                        cmd.CommandTimeout = 0;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pharmacies.Add(new PharmacyModel()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    Name = reader.GetString(reader.GetOrdinal("Name")),
                                    WorkPlaceCode = reader.IsDBNull(reader.GetOrdinal("WorkPlaceCode")) ? null : reader.GetString(reader.GetOrdinal("WorkPlaceCode")),
                                    PharmacyCode = reader.IsDBNull(reader.GetOrdinal("PharmacyCode")) ? null : reader.GetString(reader.GetOrdinal("PharmacyCode")),
                                    Icz = reader.IsDBNull(reader.GetOrdinal("Icz")) ? null : reader.GetString(reader.GetOrdinal("Icz")),
                                    Ico = reader.IsDBNull(reader.GetOrdinal("Ico")) ? null : reader.GetString(reader.GetOrdinal("Ico")),
                                    PharmacyType = reader.IsDBNull(reader.GetOrdinal("PharmacyType")) ? null : reader.GetString(reader.GetOrdinal("PharmacyType")),
                                    Coordinates = new(
                                        double.Parse(reader.GetString(reader.GetOrdinal("Latitude"))),
                                        double.Parse(reader.GetString(reader.GetOrdinal("Longitude")))
                                    ),
                                    Emergency = reader.GetBoolean(reader.GetOrdinal("HasEmergency")),
                                    ExtendedWorkTime = reader.GetBoolean(reader.GetOrdinal("ExtendedWorkTime")),
                                    Address = new()
                                    {
                                        City = reader.IsDBNull(reader.GetOrdinal("City")) ? null : reader.GetString(reader.GetOrdinal("City")),
                                        Street = reader.IsDBNull(reader.GetOrdinal("Street")) ? null : reader.GetString(reader.GetOrdinal("Street")),
                                        OrientationNumber = reader.IsDBNull(reader.GetOrdinal("OrientationNumber")) ? null : reader.GetString(reader.GetOrdinal("OrientationNumber")),
                                        DescriptiveNumber = reader.IsDBNull(reader.GetOrdinal("DescriptiveNumber")) ? null : reader.GetString(reader.GetOrdinal("DescriptiveNumber")),
                                        PostalCode = reader.IsDBNull(reader.GetOrdinal("PostalCode")) ? null : reader.GetString(reader.GetOrdinal("PostalCode"))
                                    },
                                    MainPharmacist = new()
                                    {
                                        Name = reader.IsDBNull(reader.GetOrdinal("PharmacistName")) ? null : reader.GetString(reader.GetOrdinal("PharmacistName")),
                                        Surname = reader.IsDBNull(reader.GetOrdinal("PharmacistSurname")) ? null : reader.GetString(reader.GetOrdinal("PharmacistSurname")),
                                        TitleBefore = reader.IsDBNull(reader.GetOrdinal("TitleBefore")) ? null : reader.GetString(reader.GetOrdinal("TitleBefore")),
                                        TitleAfter = reader.IsDBNull(reader.GetOrdinal("TitleAfter")) ? null : reader.GetString(reader.GetOrdinal("TitleAfter"))
                                    },
                                    Distance = null
                                });
                            }
                            reader.Close();
                        }
                        cmd.Dispose();
                    }

                    foreach (var p in pharmacies)
                    {
                        using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[GetPharmacyEmail]", Connection = conn, CommandType = CommandType.StoredProcedure })
                        {
                            cmd.CommandTimeout = 0;
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "PharmacyId", Value = p.Id, SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input });
                            List<string> emails = new List<string>();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal("Email")))
                                        emails.Add(reader.GetString(reader.GetOrdinal("Email")));
                                }
                                reader.Close();
                            }
                            cmd.Dispose();
                            p.Email = emails;
                        }

                        using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[GetPharmacyPhone]", Connection = conn, CommandType = CommandType.StoredProcedure })
                        {
                            cmd.CommandTimeout = 0;
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "PharmacyId", Value = p.Id, SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input });
                            List<string> phones = new List<string>();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal("Phone")))
                                        phones.Add(reader.GetString(reader.GetOrdinal("Phone")));
                                }
                                reader.Close();
                            }
                            cmd.Dispose();
                            p.Phone = phones;
                        }

                        using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[GetPharmacyWeb]", Connection = conn, CommandType = CommandType.StoredProcedure })
                        {
                            cmd.CommandTimeout = 0;
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "PharmacyId", Value = p.Id, SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input });
                            List<string> webs = new List<string>();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal("Web")))
                                        webs.Add(reader.GetString(reader.GetOrdinal("Web")));
                                }
                                reader.Close();
                            }
                            cmd.Dispose();
                            p.Web = webs;
                        }

                        using (SqlCommand cmd = new SqlCommand() { CommandText = "[dbo].[GetPharmacyHours]", Connection = conn, CommandType = CommandType.StoredProcedure })
                        {
                            cmd.CommandTimeout = 0;
                            cmd.Parameters.Add(new SqlParameter() { ParameterName = "PharmacyId", Value = p.Id, SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input });
                            Dictionary<string, string> hours = new Dictionary<string, string>();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    hours.Add(
                                        reader.GetString(reader.GetOrdinal("Day")),
                                        reader.GetString(reader.GetOrdinal("Time"))
                                    );
                                }
                                reader.Close();
                            }
                            cmd.Dispose();
                            p.Hours = hours;
                        }
                    }
                    conn.Close();
                }
                return pharmacies;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// This function gets user's location coordinates according to address he filled in. Function calls API to get coordinates.
        /// </summary>
        /// <param name="street">String representing street name</param>
        /// <param name="number">String representing street number</param>
        /// <param name="city">String representing city</param>
        /// <param name="postalCode">String representing zip/postal code</param>
        /// <returns></returns>
        public string[] GetUserLocationCoordinates(string street, string number, string city, string postalCode)
        {
            string url = "https://nominatim.openstreetmap.org/search?";
            street = Uri.EscapeDataString(street);
            number = Uri.EscapeDataString(number);
            city = Uri.EscapeDataString(city);
            postalCode = Uri.EscapeDataString(postalCode);

            if (street != "")
            {
                if (number != "")
                    url += "street=" + number + "+" + street + "&";
                else
                    url += "street=" + street + "&";
            }

            if (city != "")
                url += "city=" + city + "&";
            if (postalCode != "")
                url += "postalcode=" + postalCode + "&";

            url += "format=json";
            string latitude = "";
            string longitude = "";
            try
            {
                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("MedicineDatabase", "1.0"));
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var dataObjects = response.Content.ReadAsStringAsync().Result;
                    JArray res = JArray.Parse(dataObjects);
                    JObject result = (JObject)res[0];

                    // Get the latitude and longitude
                    latitude = result["lat"].ToString();
                    longitude = result["lon"].ToString();
                }
                else
                {
                    throw new Exception($"Get GeoCoordinates response status code {(int)response.StatusCode} ({response.ReasonPhrase})");
                }

                client.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Get pharmacies from api failed {0}", e.Message);
            }

            string[] results = new string[] { latitude, longitude };

            return results;
        }

        /// <summary>
        /// This function resets markers and routes on the map
        /// </summary>
        public void ResetMarkersAndRoutes()
        {
            foreach (var marker in pharmacyController.Markers.Markers)
            {
                if (marker.Tag.Equals("location"))
                {
                    pharmacyController.Markers.Markers.Remove(marker);
                    break;
                }
            }
            HideMarkers();
        }

        /// <summary>
        /// This function hides visible markers
        /// </summary>
        public void HideMarkers()
        {
            foreach (var marker in pharmacyController.Markers.Markers)
            {
                if (marker.IsVisible)
                    marker.IsVisible = false;
            }
            pharmacyController.OldMarker = null;
        }

        /// <summary>
        /// This function add marker to all pharmacy objects, so it can be visible on map
        /// </summary>
        public void AddMarkers()
        {
            GMarkerGoogle marker;
            foreach (var item in pharmacyController.Pharmacies)
            {
                marker = new GMarkerGoogle(
                new PointLatLng(item.Coordinates.Latitude, item.Coordinates.Longitude),
                GMarkerGoogleType.green_big_go);
                marker.Tag = item.Id;   // db table ID (1,2,...)
                marker.IsVisible = false;
                marker.ToolTipText =
                    $"\n{item.Name} \nLatitude: {item.Coordinates.Latitude}, \nLongitude: {item.Coordinates.Longitude}";
                pharmacyController.Markers.Markers.Add(marker);
            }
        }
    }
}
