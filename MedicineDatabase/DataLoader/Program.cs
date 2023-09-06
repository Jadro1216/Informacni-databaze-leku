using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using DataLoader.Controllers;
using Microsoft.Office.Interop.Word;

namespace DataLoader
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataLoaderController controller = new DataLoaderController();
            // uncomment this if there is no file in ProcessedData/Medicine
            //controller.ProcessMedicine();

            controller.SaveMedicineToDatabase();

            // uncomment this if there is no file in ProcessedData/StructuredData
            //controller.ProcessDocuments();

            controller.SaveDocumentDataToDatabase();

            controller.GetPharmaciesFromApi();
        }

        
    }
}