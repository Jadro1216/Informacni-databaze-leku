using MedicineDatabase.MedicineManager.Services;

namespace MedicineDatabase.MedicineManager.Controllers
{
    public class DataController
    {
        private readonly IDataService _dataService;

        public DataController()
        {
            _dataService = new DataService();
        }
    }
}
