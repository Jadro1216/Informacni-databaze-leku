using MedicineDatabase.Pharmacies.Domain;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineDatabase.Pharmacies.Models
{
    /// <summary>
    /// This class represents pharmacy object with appropriate properties
    /// </summary>
    public class PharmacyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string WorkPlaceCode { get; set; }
        public string PharmacyCode { get; set; }
        public string Icz { get; set; }
        public string Ico { get; set; }     //company identification number
        public string PharmacyType { get; set; }
        public Address Address { get; set; }
        public GeoCoordinate Coordinates { get; set; }
        public Pharmacist MainPharmacist { get; set; }
        public List<string> Web { get; set; }
        public List<string> Email { get; set; }
        public List<string> Phone { get; set; }
        public Dictionary<string, string> Hours { get; set; }
        public bool? Emergency { get; set; }
        public bool? ExtendedWorkTime { get; set; }
        public double? Distance { get; set; } //in meters
    }
}
