using MedicineDatabase.Pharmacies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineDatabase.Pharmacies.Services
{
    public interface IPharmacyService
    {
        List<PharmacyModel> LoadPharmacies();
        string[] GetUserLocationCoordinates(string street, string number, string city, string postalCode);
        void ResetMarkersAndRoutes();
        void HideMarkers();
        //void LoadPharmacies();
        void AddMarkers();
    }
}
