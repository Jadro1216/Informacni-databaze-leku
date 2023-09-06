using MedicineDatabase.MedicineInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineDatabase.MedicineInformation.Services
{
    public interface IMedicineService
    {
        List<MedicineModel> LoadMedicinePills(string searchText, string filter, string[] healthProblems, string[] alergies);

    }
}
