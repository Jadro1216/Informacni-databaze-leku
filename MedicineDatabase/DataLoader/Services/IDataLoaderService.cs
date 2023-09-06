using DataLoader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader.Services
{
    internal interface IDataLoaderService
    {
        public void SaveMedicineToDatabase(List<string[]> data);
        public void SaveStructuredDataToDatabase(Dictionary<string, Dictionary<string, string>> structured);
        public void SaveMappingToDatabase(List<string[]> mapping);
        public void SaveFilesToDatabase(string[] files);
        public void SavePharmacies(List<PharmacyObject> data);
        public string GetPharmacies();
    }
}
