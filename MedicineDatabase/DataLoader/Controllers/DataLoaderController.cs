using DataLoader.Services;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Microsoft.Office.Interop.Word;
using Path = System.IO.Path;
using System.Text;
using System.Text.RegularExpressions;
using Task = System.Threading.Tasks.Task;
using System.Collections.Concurrent;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using DataLoader.Model;

namespace DataLoader.Controllers
{
    internal class DataLoaderController
    {
        private readonly IDataLoaderService _dataLoaderService;
        private static object lockObject = new object();
        public DataLoaderController()
        {
            _dataLoaderService = new DataLoaderService();
        }

        /// <summary>
        /// This function will process medicine files and will create 'processedData.csv' that will contain 
        /// medicine data used in application
        /// </summary>
        public void ProcessMedicine()
        {
            string projectPath = Directory.GetCurrentDirectory();
            // Read the second CSV file into a dictionary
            //Dictionary<string, string> dictionary = ReadDictionaryFromCSV("second_file.csv");
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../data/Medicine");
            Dictionary<string, string> csvFormy = ReadDictionaryFromCSV(Path.Combine(folderPath, "dlp_formy.csv"), 1);
            Dictionary<string, string> csvCesty = ReadDictionaryFromCSV(Path.Combine(folderPath, "dlp_cesty.csv"), 1);
            Dictionary<string, string> csvObal = ReadDictionaryFromCSV(Path.Combine(folderPath, "dlp_obaly.csv"), 1);
            Dictionary<string, string> csvOrganizace = ReadDictionaryFromCSV(Path.Combine(folderPath, "dlp_organizace.csv"), 2);
            Dictionary<string, string> csvZeme = ReadDictionaryFromCSV(Path.Combine(folderPath, "dlp_zeme.csv"), 1);
            Dictionary<string, string> csvStavyRegistrace = ReadDictionaryFromCSV(Path.Combine(folderPath, "dlp_stavyreg.csv"), 1);
            Dictionary<string, string> csvIndikacniSkupina = ReadDictionaryFromCSV(Path.Combine(folderPath, "dlp_indikacniskupiny.csv"), 1);
            Dictionary<string, string> csvAtc = ReadDictionaryFromCSV(Path.Combine(folderPath, "dlp_atc.csv"), 2);
            Dictionary<string, string> csvRegProcedura = ReadDictionaryFromCSV(Path.Combine(folderPath, "dlp_regproc.csv"), 1);
            Dictionary<string, string> csvLeciveLatky = ReadDictionaryFromCSV(Path.Combine(folderPath, "dlp_lecivelatky.csv"), 3);
            Dictionary<string, string> csvVydej = ReadDictionaryFromCSV(Path.Combine(folderPath, "dlp_vydej.csv"), 1);
            Dictionary<string, string> csvDoping = ReadDictionaryFromCSV(Path.Combine(folderPath, "dlp_doping.csv"), 1);

            // Read and process the first CSV file
            List<string[]> csvData = ReadCSV(Path.Combine(folderPath, "dlp_lecivepripravky.csv"));

            // Find the indexes of the columns in the CSV file
            int vydejIndex = Array.IndexOf(csvData[0], "VYDEJ");
            int cestyIndex = Array.IndexOf(csvData[0], "CESTA");
            int dopingIndex = Array.IndexOf(csvData[0], "DOPING");
            int formyIndex = Array.IndexOf(csvData[0], "FORMA");
            int zemeIndex = Array.IndexOf(csvData[0], "ZEMDRZ");
            int aktualZemIndex = Array.IndexOf(csvData[0], "AKT_ZEM");
            int indikSkupIndex = Array.IndexOf(csvData[0], "IS_");
            int atcIndex = Array.IndexOf(csvData[0], "ATC_WHO");
            int leciveLatkyIndex = Array.IndexOf(csvData[0], "LL");
            int obalIndex = Array.IndexOf(csvData[0], "OBAL");
            int drzitelIndex = Array.IndexOf(csvData[0], "DRZ");
            int aktualDrzIndex = Array.IndexOf(csvData[0], "AKT_DRZ");
            int regIndex = Array.IndexOf(csvData[0], "REG");
            int regProcIndex = Array.IndexOf(csvData[0], "REG_PROC");

            // Replace the values in columns with the corresponding values from the dictionaries
            for (int i = 1; i < csvData.Count; i++)
            {
                string vydejValue = csvData[i][vydejIndex];
                if (csvVydej.ContainsKey(vydejValue))
                    csvData[i][vydejIndex] = csvVydej[vydejValue];

                string dopingValue = csvData[i][dopingIndex];
                if (csvDoping.ContainsKey(dopingValue))
                    csvData[i][dopingIndex] = csvDoping[dopingValue];

                string cestyValue = csvData[i][cestyIndex];
                if (csvCesty.ContainsKey(cestyValue))
                    csvData[i][cestyIndex] = csvCesty[cestyValue];

                string formyValue = csvData[i][formyIndex];
                if (csvFormy.ContainsKey(formyValue))
                    csvData[i][formyIndex] = csvFormy[formyValue];

                string zemeValue = csvData[i][zemeIndex];
                if (csvZeme.ContainsKey(zemeValue))
                    csvData[i][zemeIndex] = csvZeme[zemeValue];

                string aktZemeValue = csvData[i][aktualZemIndex];
                if (csvZeme.ContainsKey(aktZemeValue))
                    csvData[i][aktualZemIndex] = csvZeme[aktZemeValue];

                string obalValue = csvData[i][obalIndex];
                if (csvObal.ContainsKey(obalValue))
                    csvData[i][obalIndex] = csvObal[obalValue];

                string drzitelValue = csvData[i][drzitelIndex];
                if (csvOrganizace.ContainsKey(drzitelValue))
                    csvData[i][drzitelIndex] = csvOrganizace[drzitelValue];

                string aktualDrzValue = csvData[i][aktualDrzIndex];
                if (csvOrganizace.ContainsKey(aktualDrzValue))
                    csvData[i][aktualDrzIndex] = csvOrganizace[aktualDrzValue];

                string regValue = csvData[i][regIndex];
                if (csvStavyRegistrace.ContainsKey(regValue))
                    csvData[i][regIndex] = csvStavyRegistrace[regValue];

                string regProcValue = csvData[i][regProcIndex];
                if (csvRegProcedura.ContainsKey(regProcValue))
                    csvData[i][regProcIndex] = csvRegProcedura[regProcValue];

                string indikSkupValue = csvData[i][indikSkupIndex];
                if (csvIndikacniSkupina.ContainsKey(indikSkupValue))
                    csvData[i][indikSkupIndex] = csvIndikacniSkupina[indikSkupValue];

                string[] leciveLatky = csvData[i][leciveLatkyIndex].Split(',');
                for (int j = 0; j < leciveLatky.Length; j++)
                {
                    if (csvLeciveLatky.ContainsKey(leciveLatky[j]))
                        leciveLatky[j] = csvLeciveLatky[leciveLatky[j]];
                }
                csvData[i][leciveLatkyIndex] = string.Join(',', leciveLatky);

                string atcValue = csvData[i][atcIndex];
                string[] newValues = new string[csvData[i].Length + 1];
                // TODO: FIRST ROW ADD ATC_NAZEV
                Array.Copy(csvData[i], newValues, atcIndex + 1);
                if (csvAtc.ContainsKey(atcValue))
                {
                    newValues[atcIndex + 1] = csvAtc[atcValue];
                }
                else
                {
                    newValues[atcIndex + 1] = "";
                }
                Array.Copy(csvData[i], atcIndex + 1, newValues, atcIndex + 2, csvData[i].Length - (atcIndex + 1));
                csvData[i] = newValues;
            }

            // Write the modified CSV data back to a file
            WriteCSV(Path.Combine(projectPath, "../../../ProcessedData/Medicine/processedData.csv"), csvData);
        }

        /// <summary>
        /// This function will read .csv file and will return dictionary with the values from file
        /// </summary>
        /// <param name="filePath">Path to file to read</param>
        /// <param name="colNum">Column index of values to return from original file</param>
        /// <returns>Dictionary with string key and string value</returns>
        private Dictionary<string, string> ReadDictionaryFromCSV(string filePath, int colNum)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    string key = parts[0].Trim();
                    string value = parts[colNum].Trim();
                    dictionary[key] = value;
                }
            }

            return dictionary;
        }

        /// <summary>
        /// This function reads .csv file and returns List<string[]> of values
        /// </summary>
        /// <param name="filePath">File path to read</param>
        /// <returns>List of string arrays that represents one csv row</returns>
        private List<string[]> ReadCSV(string filePath)
        {
            List<string[]> csvData = new List<string[]>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    string key = parts[0].Trim();
                    string[] value = parts.Skip(1).ToArray();
                    csvData.Add(parts);
                }
            }

            return csvData;
        }

        /// <summary>
        /// This function will write csvData to the file specified as first argument -> filePath
        /// </summary>
        /// <param name="filePath">File name where to write csv data</param>
        /// <param name="csvData">CSV data to write to the file</param>
        private void WriteCSV(string filePath, List<string[]> csvData)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string[] parts in csvData)
                {
                    writer.WriteLine(string.Join(";", parts));
                }
            }
        }

        /// <summary>
        /// This function will read processed medicine data and saves it to database
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void SaveMedicineToDatabase()
        {
            try
            {
                string folderPath = Directory.GetCurrentDirectory();
                List<string[]> data = ReadCSV(Path.Combine(folderPath, "../../../ProcessedData/Medicine/processedData.csv"));

                _dataLoaderService.SaveMedicineToDatabase(data);
            }
            catch (Exception ex)
            {

                throw new Exception($"Saving medicines to db failed: {ex.Message}.");
            }
        }


        /// <summary>
        /// This function will create structured data from files id folder data/Documents
        /// </summary>
        public void ProcessDocuments()
        {

            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../data/Documents");
            string[] files = Directory.GetFiles(folderPath);
            ConcurrentDictionary<string, Dictionary<string, string>> docsSections = new ConcurrentDictionary<string, Dictionary<string, string>>();

            Application wordApp = new Application();
            wordApp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            wordApp.Visible = false;
            
            int maxConcurrentFiles = Environment.ProcessorCount; // Adjust as needed

            // Create a BlockingCollection to store the files
            BlockingCollection<string> fileCollection = new BlockingCollection<string>(maxConcurrentFiles);
            try
            {
                // Start a task to enqueue the files
                Task enqueueTask = Task.Run(() =>
                {
                    // Enqueue each file
                    foreach (string filePath in files)
                    {
                        fileCollection.Add(filePath);
                    }

                    // Mark the collection as completed
                    fileCollection.CompleteAdding();
                });

                // Start tasks to process the files
                List<Task> processingTasks = new List<Task>();
                for (int i = 0; i < maxConcurrentFiles; i++)
                {
                    Task processingTask = Task.Run(() =>
                    {
                        while (!fileCollection.IsCompleted)
                        {
                            try
                            {
                                // Dequeue a file
                                string file = fileCollection.Take();


                                if (Path.GetExtension(file).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                                {
                                    Dictionary<string, string> sections = ProcessPDF(file);
                                    string fileName = Path.GetFileName(file);
                                    docsSections.TryAdd(fileName, sections);
                                    //Console.WriteLine("Processed file: " + fileName);
                                }
                                else
                                {
                                    Dictionary<string, string> sections = ProcessDOC(file, wordApp);
                                    string fileName = Path.GetFileName(file);
                                    docsSections.TryAdd(fileName, sections);
                                    //Console.WriteLine("Processed file: " + fileName);
                                }
                            }
                            catch (InvalidOperationException)
                            {
                                // The collection may be empty or completed by another thread
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("An error occurred: " + ex.Message);
                            }
                        }
                    });

                    processingTasks.Add(processingTask);
                }

                // Wait for all processing tasks to complete
                Task.WaitAll(processingTasks.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the Word application
                lock (lockObject)
                {
                    wordApp.Quit();
                    ReleaseObject(wordApp);
                }
                Console.WriteLine("File processing finished.");
            }

            #region Helping processing code - documents devided by number of sections
            var lessThan_10 = docsSections.Where(itm => itm.Value.Count < 10).ToList();
            var between10_and_25 = docsSections.Where(itm => itm.Value.Count >= 10 && itm.Value.Count < 25).ToList();
            var moreThan_25 = docsSections.Where(itm => itm.Value.Count >= 26).ToList();
            var errorDocs2 = docsSections.Where(itm => itm.Value.Count < 25).ToDictionary(x => x.Key, x => x.Value);
            #endregion

            #region Helping processing code - dictionaries of items of wanted sections to see how many are recognized or unrecognized  
            var kvalitatSlozeni = docsSections.Where(itm =>
            {
                bool result = false;
                foreach (var x in itm.Value.Keys.ToList())
                {
                    var trimemdKey = Regex.Replace(x, @"^(\d*\.*\s*)*", "").ToLower();
                    var tmp = string.Join("", trimemdKey.Split(' '));
                    tmp = Regex.Replace(tmp, @"\W", "");
                    //if (tmp.Equals("kvalitativníakvantitativnísložení"))
                    //{
                    //    result = true;
                    //    break;
                    //}
                    string normalized = tmp.Normalize(NormalizationForm.FormD);
                    if (tmp.StartsWith("kvalitativníakvantitativnísložení".Normalize(NormalizationForm.FormD)) ||
                        tmp.StartsWith("kvantitativníakvalitativnísložení".Normalize(NormalizationForm.FormD)) ||
                        tmp.StartsWith("složeníkvalitativníikvantitativní".Normalize(NormalizationForm.FormD)) ||
                        tmp.StartsWith("kvalitativníikvantitativnísložení".Normalize(NormalizationForm.FormD)) ||
                        tmp.StartsWith("kvantitativníikvalitativnísložení".Normalize(NormalizationForm.FormD)) ||
                        tmp.StartsWith("složeníkvalitativníakvantitativní".Normalize(NormalizationForm.FormD)))
                    {
                        result = true;
                        break;
                    }
                }
                return result;
            }).ToList();
            var indikace = docsSections.Where(itm =>
            {
                bool result = false;
                foreach (var x in itm.Value.Keys.ToList())
                {
                    var trimemdKey = Regex.Replace(x, @"^(\d*\.*\s*)*", "").ToLower();
                    var tmp = string.Join("", trimemdKey.Split(' '));
                    tmp = Regex.Replace(tmp, @"\W", "");
                    //if (tmp.Equals("terapeutickéindikace"))
                    //{
                    //    result = true;
                    //    break;
                    //}
                    string normalized = tmp.Normalize(NormalizationForm.FormD);
                    List<string> possibilities = new List<string>()
                    {
                        "terapeutickéindikace".Normalize(NormalizationForm.FormD),
                        "terapeutickáindikace".Normalize(NormalizationForm.FormD),
                        "oblastipoužití".Normalize(NormalizationForm.FormD),
                        "oblastpoužití".Normalize(NormalizationForm.FormD),

                    };
                    string pattern = @"(terapeutick[áé]indikace|oblast[íi]použit[íi]|indikaceapoužit[íi]|léčebn[éé]indikace)";
                    if (Regex.IsMatch(tmp, pattern))
                    {
                        result = true;
                        break;
                    }
                }
                return result;
            }).ToList();
            var davkovanie = docsSections.Where(itm =>
            {
                bool result = false;
                foreach (var x in itm.Value.Keys.ToList())
                {
                    var trimemdKey = Regex.Replace(x, @"^(\d*\.*\s*)*", "").ToLower();
                    var tmp = string.Join("", trimemdKey.Split(' '));
                    tmp = Regex.Replace(tmp, @"\W", "");
                    //if (tmp.Equals("dávkováníazpůsobpodání"))
                    //{
                    //    result = true;
                    //    break;
                    //}
                    string normalized = tmp.Normalize(NormalizationForm.FormD);
                    if (normalized.StartsWith("dávkováníazpůsob".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dávkováníatyp".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dávkovánízpůsob".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dávkováníapodávání".Normalize(NormalizationForm.FormD)))
                    {
                        result = true;
                        break;
                    }
                }
                return result;
            }).ToList();
            var kontraindikace = docsSections.Where(itm =>
            {
                bool result = false;
                foreach (var x in itm.Value.Keys.ToList())
                {
                    var trimemdKey = Regex.Replace(x, @"^(\d*\.*\s*)*", "").ToLower();
                    var tmp = string.Join("", trimemdKey.Split(' '));
                    tmp = Regex.Replace(tmp, @"\W", "");
                    if (tmp.Equals("kontraindikace"))
                    {
                        result = true;
                        break;
                    }
                }
                return result;
            }).ToList();
            var upozorneni = docsSections.Where(itm =>
            {
                bool result = false;
                foreach (var x in itm.Value.Keys.ToList())
                {
                    var trimemdKey = Regex.Replace(x, @"^(\d*\.*\s*)*", "").ToLower();
                    var tmp = string.Join("", trimemdKey.Split(' '));
                    tmp = Regex.Replace(tmp, @"\W", "");
                    //if (tmp.Equals("zvláštníupozorněníaopatřenípropoužití") || tmp.Equals("zvláštníupozorněníazvláštníopatřenípropoužití"))
                    //{
                    //    result = true;
                    //    break;
                    //}
                    string normalized = tmp.Normalize(NormalizationForm.FormD);
                    if (normalized.StartsWith("zvláštníupozornění".Normalize(NormalizationForm.FormD)))
                    {
                        result = true;
                        break;
                    }
                }
                return result;
            }).ToList();
            var interakce = docsSections.Where(itm =>
            {
                bool result = false;
                foreach (var x in itm.Value.Keys.ToList())
                {
                    var trimemdKey = Regex.Replace(x, @"^(\d*\.*\s*)*", "").ToLower();
                    var tmp = string.Join("", trimemdKey.Split(' '));
                    tmp = Regex.Replace(tmp, @"\W", "");
                    //if (tmp.Equals("interakcesjinýmiléčivýmipřípravkyajinéformyinterakce"))
                    //{
                    //    result = true;
                    //    break;
                    //}
                    string normalized = tmp.Normalize(NormalizationForm.FormD);
                    if (normalized.StartsWith("interakcesjinými".Normalize(NormalizationForm.FormD)) || normalized.StartsWith("lékovéajiné".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("lékovéinterakce".Normalize(NormalizationForm.FormD)))
                    {
                        result = true;
                        break;
                    }
                }
                return result;
            }).ToList();
            var nezadouci = docsSections.Where(itm =>
            {
                bool result = false;
                foreach (var x in itm.Value.Keys.ToList())
                {
                    var trimemdKey = Regex.Replace(x, @"^(\d*\.*\s*)*", "").ToLower();
                    var tmp = string.Join("", trimemdKey.Split(' '));
                    tmp = Regex.Replace(tmp, @"\W", "");
                    string normalized = tmp.Normalize(NormalizationForm.FormD);
                    //if (tmp.Equals("nežádoucíúčinky"))
                    //{
                    //    result = true;
                    //    break;
                    //}
                    if (normalized.StartsWith("nežádoucíúčinky".Normalize(NormalizationForm.FormD)) || normalized.StartsWith("vedlejšíúčinky".Normalize(NormalizationForm.FormD)))
                    {
                        result = true;
                        break;
                    }
                }
                return result;
            }).ToList();
            var predavkovani = docsSections.Where(itm =>
            {
                bool result = false;
                foreach (var x in itm.Value.Keys.ToList())
                {
                    var trimemdKey = Regex.Replace(x, @"^(\d*\.*\s*)*", "").ToLower();
                    var tmp = string.Join("", trimemdKey.Split(' '));
                    tmp = Regex.Replace(tmp, @"\W", "");
                    //if (tmp.Equals("předávkování"))
                    //{
                    //    result = true;
                    //    break;
                    //}
                    string normalized = tmp.Normalize(NormalizationForm.FormD);
                    if (normalized.StartsWith("předávkování".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("předávkovaní".Normalize(NormalizationForm.FormD)))
                    {
                        result = true;
                        break;
                    }
                }
                return result;
            }).ToList();
            var seznampomoclatek = docsSections.Where(itm =>
            {
                bool result = false;
                foreach (var x in itm.Value.Keys.ToList())
                {
                    var trimemdKey = Regex.Replace(x, @"^(\d*\.*\s*)*", "").ToLower();
                    var tmp = string.Join("", trimemdKey.Split(' '));
                    tmp = Regex.Replace(tmp, @"\W", "");
                    //if (tmp.Equals("seznampomocnýchlátek"))
                    //{
                    //    result = true;
                    //    break;
                    //}
                    string normalized = tmp.Normalize(NormalizationForm.FormD);
                    if (normalized.StartsWith("seznampomocnýchlátek".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("seznamvšechpomocnýchlátek".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("úplnýseznampomocnýchlátek".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("seznamostatnímsložek".Normalize(NormalizationForm.FormD)))
                    {
                        result = true;
                        break;
                    }
                }
                return result;
            }).ToList();
            var pouzitelnost = docsSections.Where(itm =>
            {
                bool result = false;
                foreach (var x in itm.Value.Keys.ToList())
                {
                    var trimemdKey = Regex.Replace(x, @"^(\d*\.*\s*)*", "").ToLower();
                    var tmp = string.Join("", trimemdKey.Split(' '));
                    //tmp = Regex.Replace(tmp, @"\W", "");
                    string normalized = tmp.Normalize(NormalizationForm.FormD);
                    //if (tmp.Equals("dobapoužitelnosti"))
                    //{
                    //    result = true;
                    //    break;
                    //}
                    if (normalized.StartsWith("dobapoužitelnosti".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dobapožitelnosti".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dobatrvanlivosti".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dobauchovávání".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dobaplatnosti".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("skladovatelnost".Normalize(NormalizationForm.FormD)))
                    {
                        result = true;
                        break;
                    }
                }
                return result;
            }).ToList();

            Dictionary<string, Dictionary<string, string>> kontraindikaceDict = kontraindikace.ToDictionary(yy => yy.Key, yy => yy.Value);
            var notkontraindikaceDict = docsSections.Except(kontraindikaceDict).ToDictionary(yy => yy.Key, yy => yy.Value);
            Dictionary<string, Dictionary<string, string>> upozorDict = upozorneni.ToDictionary(yy => yy.Key, yy => yy.Value);
            var notUpozorDict = docsSections.Except(upozorDict).ToDictionary(yy => yy.Key, yy => yy.Value);
            Dictionary<string, Dictionary<string, string>> indikaceDict = indikace.ToDictionary(yy => yy.Key, yy => yy.Value);
            var notIndikaceDict = docsSections.Except(indikaceDict).ToDictionary(yy => yy.Key, yy => yy.Value);
            Dictionary<string, Dictionary<string, string>> davkovanieDict = davkovanie.ToDictionary(yy => yy.Key, yy => yy.Value);
            var notDavkovanieDict = docsSections.Except(davkovanieDict).ToDictionary(yy => yy.Key, yy => yy.Value);
            Dictionary<string, Dictionary<string, string>> interakceDict = interakce.ToDictionary(yy => yy.Key, yy => yy.Value);
            var notInterakceDict = docsSections.Except(interakceDict).ToDictionary(yy => yy.Key, yy => yy.Value);
            Dictionary<string, Dictionary<string, string>> kvalitatDict = kvalitatSlozeni.ToDictionary(yy => yy.Key, yy => yy.Value);
            var notkvalitatDict = docsSections.Except(kvalitatDict).ToDictionary(yy => yy.Key, yy => yy.Value);
            Dictionary<string, Dictionary<string, string>> nezadouciDict = nezadouci.ToDictionary(yy => yy.Key, yy => yy.Value);
            var notnezadouciDict = docsSections.Except(nezadouciDict).ToDictionary(yy => yy.Key, yy => yy.Value);
            Dictionary<string, Dictionary<string, string>> predavkovaniDict = predavkovani.ToDictionary(yy => yy.Key, yy => yy.Value);
            var notpredavkovaniDict = docsSections.Except(predavkovaniDict).ToDictionary(yy => yy.Key, yy => yy.Value);
            Dictionary<string, Dictionary<string, string>> seznamLatekDict = seznampomoclatek.ToDictionary(yy => yy.Key, yy => yy.Value);
            var notseznamLatekDict = docsSections.Except(seznamLatekDict).ToDictionary(yy => yy.Key, yy => yy.Value);
            Dictionary<string, Dictionary<string, string>> pouzitelnostDict = pouzitelnost.ToDictionary(yy => yy.Key, yy => yy.Value);
            var notpouzitelnostDict = docsSections.Except(pouzitelnostDict).ToDictionary(yy => yy.Key, yy => yy.Value);
            #endregion

            #region Helping processing code - each section unrecognized keys 
            //List<string> notKontraindikaceKeys = notkontraindikaceDict.Values.SelectMany(innerDict => innerDict.Keys).Distinct().ToList();
            //List<string> notUpozorKeys = notUpozorDict.Values.SelectMany(innerDict => innerDict.Keys).Distinct().ToList();
            //List<string> notIndikaceKeys = notIndikaceDict.Values.SelectMany(innerDict => innerDict.Keys).Distinct().ToList();
            //List<string> notDavkovanieKeys = notDavkovanieDict.Values.SelectMany(innerDict => innerDict.Keys).Distinct().ToList();
            //List<string> notInterakceKeys = notInterakceDict.Values.SelectMany(innerDict => innerDict.Keys).Distinct().ToList();
            //List<string> notkvalitatKeys = notkvalitatDict.Values.SelectMany(innerDict => innerDict.Keys).Distinct().ToList();
            //List<string> notnezadouciKeys = notnezadouciDict.Values.SelectMany(innerDict => innerDict.Keys).Distinct().ToList();
            //List<string> notpredavkovaniKeys = notpredavkovaniDict.Values.SelectMany(innerDict => innerDict.Keys).Distinct().ToList();
            //List<string> notseznamLatekKeys = notseznamLatekDict.Values.SelectMany(innerDict => innerDict.Keys).Distinct().ToList();
            //List<string> notpouzitelnostDictKeys = notpouzitelnostDict.Values.SelectMany(innerDict => innerDict.Keys).Distinct().ToList();
            #endregion


            Dictionary<string, Dictionary<string, string>> structured = GetStructuredDocumentSections(docsSections);
            SaveStructuredData(structured);
        }

        /// <summary>
        /// This function will return Dictionary where the key is file name and value is dictionary of specified sections from file
        /// </summary>
        /// <param name="docsSections">Dictionary of files and its sections</param>
        /// <returns></returns>
        private Dictionary<string, Dictionary<string, string>> GetStructuredDocumentSections(ConcurrentDictionary<string, Dictionary<string, string>> docsSections)
        {
            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();

            foreach (KeyValuePair<string, Dictionary<string, string>> entry in docsSections)
            {
                string key = entry.Key;
                var wantedSections = new Dictionary<string, string>
                {
                    { "indications", "" }, { "contraindications", "" },{ "sideEffects", "" }, { "validity", "" }, { "warnings", "" },
                    { "interactions", "" }, { "dosage", "" }, { "composition", "" }, { "substanceList", "" }, { "overdose", "" }
                };

                foreach (KeyValuePair<string, string> item in entry.Value)
                {
                    string innerKey = item.Key;
                    string innerValue = item.Value;
                    var trimemdKey = Regex.Replace(innerKey, @"^(\d*\.*\s*)*", "").ToLower();
                    var tmp = string.Join("", trimemdKey.Split(' '));

                    string normalized = tmp.Normalize(NormalizationForm.FormD);

                    if (normalized.StartsWith("kontraindikace".Normalize(NormalizationForm.FormD)))
                    {
                        if (innerValue != "" && wantedSections["contraindications"] == "")
                            wantedSections["contraindications"] = innerValue;
                        continue;
                    }

                    if (normalized.StartsWith("nežádoucíúčinky".Normalize(NormalizationForm.FormD)) || normalized.StartsWith("vedlejšíúčinky".Normalize(NormalizationForm.FormD))
                        || normalized.StartsWith("možnénežádoucíúčinky".Normalize(NormalizationForm.FormD)))
                    {
                        if (innerValue != "" && wantedSections["sideEffects"] == "")
                            wantedSections["sideEffects"] = innerValue;
                        continue;
                    }

                    if (normalized.StartsWith("zvláštníupozornění".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("upozorněníabezpečnostní".Normalize(NormalizationForm.FormD)))
                    {
                        if (innerValue != "" && wantedSections["warnings"] == "")
                            wantedSections["warnings"] = innerValue;
                        continue;
                    }

                    if (normalized.StartsWith("dobapoužitelnosti".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dobapožitelnosti".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dobatrvanlivosti".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dobauchovávání".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dobaplatnosti".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("skladovatelnost".Normalize(NormalizationForm.FormD)))
                    {
                        if (innerValue != "" && wantedSections["validity"] == "")
                            wantedSections["validity"] = innerValue;
                        continue;
                    }

                    if (normalized.StartsWith("terapeutickéindikace".Normalize(NormalizationForm.FormD)) || normalized.StartsWith("terapeutickáindikace".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("oblastipoužití".Normalize(NormalizationForm.FormD)) || normalized.StartsWith("oblastpoužití".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("oblastiužívání".Normalize(NormalizationForm.FormD)) || normalized.StartsWith("léčebnéindikace".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("indikace".Normalize(NormalizationForm.FormD)))
                    {
                        if (innerValue != "" && wantedSections["indications"] == "")
                            wantedSections["indications"] = innerValue;
                        continue;
                    }

                    tmp = Regex.Replace(tmp, @"\W", "");
                    normalized = tmp.Normalize(NormalizationForm.FormD);

                    if (normalized.StartsWith("dávkováníazpůsob".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dávkováníatyp".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dávkovánízpůsob".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("dávkováníapodávání".Normalize(NormalizationForm.FormD)))
                    {
                        if (innerValue != "" && wantedSections["dosage"] == "")
                            wantedSections["dosage"] = innerValue;
                        continue;
                    }

                    if (normalized.StartsWith("interakcesjinými".Normalize(NormalizationForm.FormD)) || normalized.StartsWith("lékovéajiné".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("lékovéinterakce".Normalize(NormalizationForm.FormD)))
                    {
                        if (innerValue != "" && wantedSections["interactions"] == "")
                            wantedSections["interactions"] = innerValue;
                        continue;
                    }

                    if (tmp.StartsWith("kvalitativníakvantitativnísložení".Normalize(NormalizationForm.FormD)) ||
                        tmp.StartsWith("kvantitativníakvalitativnísložení".Normalize(NormalizationForm.FormD)) ||
                        tmp.StartsWith("složeníkvalitativníikvantitativní".Normalize(NormalizationForm.FormD)) ||
                        tmp.StartsWith("kvalitativníikvantitativnísložení".Normalize(NormalizationForm.FormD)) ||
                        tmp.StartsWith("kvantitativníikvalitativnísložení".Normalize(NormalizationForm.FormD)) ||
                        tmp.StartsWith("složeníkvalitativníakvantitativní".Normalize(NormalizationForm.FormD)))
                    {
                        if (innerValue != "" && wantedSections["composition"] == "")
                            wantedSections["composition"] = innerValue;
                        continue;
                    }

                    if (normalized.StartsWith("předávkování".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("předávkovaní".Normalize(NormalizationForm.FormD)))
                    {
                        if (innerValue != "" && wantedSections["overdose"] == "")
                            wantedSections["overdose"] = innerValue;
                        continue;
                    }

                    if (normalized.StartsWith("seznampomocnýchlátek".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("seznamvšechpomocnýchlátek".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("úplnýseznampomocnýchlátek".Normalize(NormalizationForm.FormD)) ||
                        normalized.StartsWith("seznamostatnímsložek".Normalize(NormalizationForm.FormD)))
                    {
                        if (innerValue != "" && wantedSections["substanceList"] == "")
                            wantedSections["substanceList"] = innerValue;
                    }
                }

                result.Add(key, wantedSections);
            }

            return result;
        }


        /// <summary>
        /// This function will save created structured data to a file
        /// </summary>
        /// <param name="structured">Structured data to save into the file</param>
        private void SaveStructuredData(Dictionary<string, Dictionary<string, string>> structured)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../data");
            string destinationFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../ProcessedData/StructuredData");
            string fileName = "structuredDocuments.json";
            string filePath = Path.Combine(destinationFolderPath, fileName);
            string json = JsonConvert.SerializeObject(structured, Formatting.Indented);

            try
            {
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Saving structured document data to file failed: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// This function will process PDF file to extract its sections
        /// </summary>
        /// <param name="file">Path to the file to extract sections</param>
        /// <returns>Returns sections in dictionary, where key is title of the section and value is the section itself</returns>
        private Dictionary<string, string> ProcessPDF(string file)
        {
            StringBuilder text = new StringBuilder();
            // Open the PDF file
            using (PdfReader reader = new PdfReader(file))
            {
                // Iterate through each page of the PDF
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    // Extract the text from the current page
                    string pageText = PdfTextExtractor.GetTextFromPage(reader, i);

                    text.AppendLine(pageText);
                }
            }

            List<string> sections = ExtractSections(text.ToString());
            Dictionary<string, string> resultSections = ExtractSectionTitle(sections);

            return resultSections;
        }

        /// <summary>
        /// This function will extract sections from a file content by regex
        /// </summary>
        /// <param name="content">String file content to extract sections</param>
        /// <returns>List of sections</returns>
        private List<string> ExtractSections(string content)
        {
            List<string> sections = new List<string>();
            
            string pattern = @"^(?:\d{1,2}(\.)?\s*(\p{Lu}{2,}|\p{Lu}\p{Ll}+))|^(?:(\d{1,2}\.\s?)|(\d{1,2}\.?\s?)){2}\s*(\p{Lu}\p{Ll}+|\p{Lu}{2,})"; // Matches the section numbering pattern
            content = content.Replace("\r", "\n").Replace("\f", "\n");
            string[] lines = content.Split('\n');
            string currentSection = "";
            
            foreach (string line in lines)
            {
                string trimmed = Regex.Replace(line, @"^(\d*\.*\s*)*", "").ToLower();
                trimmed = Regex.Replace(trimmed, @"\s", "");
                trimmed = Regex.Replace(trimmed, @"\W", "");
                string trimmedLine = line.Trim();
                if (Regex.IsMatch(trimmedLine, pattern))
                {
                    if (!string.IsNullOrEmpty(currentSection))
                    {
                        sections.Add(currentSection.Trim());
                        currentSection = "";
                    }
                }
                //else if (titles.Contains(trimmed))
                //{
                //    if (!string.IsNullOrEmpty(currentSection))
                //    {
                //        sections.Add(currentSection.Trim());
                //        currentSection = "";
                //    }
                //}

                currentSection += trimmedLine + "\n";
            }

            if (!string.IsNullOrEmpty(currentSection))
            {
                sections.Add(currentSection.Trim());
            }

            return sections;
        }        


        /// <summary>
        /// This function will extract titles from sections.
        /// </summary>
        /// <param name="sections">List of sections to extract titles from</param>
        /// <returns>Dictionary<string, string> where key is section title and value is section text</returns>
        private Dictionary<string, string> ExtractSectionTitle(List<string> sections)
        {
            try
            {
                Dictionary<string, string> result = new Dictionary<string, string>();

                foreach (string section in sections.Skip(0))
                {
                    string[] lines = section.Trim().Split('\n', 2);
                    string title = lines[0].Trim();
                    string text = (lines.Length > 1) ? lines[1].Trim() : string.Empty;
                    if(result.ContainsKey(title))
                    {
                        result[title] += text;
                    }
                    else
                    {
                        result.Add(title, text);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        /// <summary>
        /// This function will process .doc document and extract its sections
        /// </summary>
        /// <param name="file">Path to file to process</param>
        /// <param name="wordApp">Instance of Microsoft.Office.Interop.Word.Application</param>
        /// <returns>Dictionary where key is section title and value is the section itself</returns>
        private Dictionary<string, string> ProcessDOC(string file, Application wordApp)
        {
            Document doc = null;
            // Open the document
            Dictionary<string, string> resultSections = new Dictionary<string, string>();
            try
            {
                lock (lockObject)
                {
                    doc = wordApp.Documents.Open(file);

                    string content = doc.Content.Text.Trim();

                    // Extract sections
                    List<string> sections = ExtractSections(content);
                    resultSections = ExtractSectionTitle(sections);
                    doc.Close();
                }
                //ReleaseObject(doc);
            }
            finally
            {
                //doc.Close();
                //ReleaseObject(doc);
            }

            return resultSections;
        }

        /// <summary>
        /// This function releases unnecessary object and calls garbage collector
        /// </summary>
        /// <param name="obj">Object to release</param>
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Error releasing object: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        /// <summary>
        /// This function saves structured data to database.
        /// </summary>
        /// <exception cref="Exception">Thrown when saving to database failed</exception>
        public void SaveDocumentDataToDatabase()
        {
            try
            {
                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../data");
                string[] files = Directory.GetFiles(folderPath + "/Documents");
                _dataLoaderService.SaveFilesToDatabase(files);
                string fileName = "structuredDocuments.json";
                string destinationFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../ProcessedData/StructuredData");
                string filePath = Path.Combine(destinationFolderPath, fileName);
                string json = File.ReadAllText(filePath);

                Dictionary<string, Dictionary<string, string>> data = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
                _dataLoaderService.SaveStructuredDataToDatabase(data);
                Console.WriteLine("Structured data successfully saved to database.");

                List<string[]> documentMapping = ReadCSV(Path.Combine(folderPath, "Medicine/dlp_nazvydokumentu.csv"));
                _dataLoaderService.SaveMappingToDatabase(documentMapping);
                Console.WriteLine("Document mapping successfully saved to database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Saving medicines to db failed: {ex.Message}.");
                throw new Exception($"Saving medicines to db failed: {ex.Message}.");
            }


        }

        /// <summary>
        /// This function gets pharmacy data by API call and saves them to database
        /// </summary>
        public void GetPharmaciesFromApi()
        {
            try
            {
                var dataObjects = _dataLoaderService.GetPharmacies();
                PharmacyData pharmacyData = JsonConvert.DeserializeObject<PharmacyData>(dataObjects);
                pharmacyData.Data = pharmacyData.Data.Where(x => x.Souradnice.Gpsn != null && x.Souradnice.Gpse != null).ToList();
                pharmacyData.Celkem = pharmacyData.Data.Count;

                _dataLoaderService.SavePharmacies(pharmacyData.Data);
            }
            catch (Exception e)
            {
                Console.WriteLine("Get pharmacies from api failed {0}", e.Message);
            }
        }
    }
}
