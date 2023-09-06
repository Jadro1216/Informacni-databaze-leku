using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineDatabase.Pharmacies.Domain
{
    public class Address
    {
        public string? Street { get; set; }
        public string? OrientationNumber { get; set; }
        public string? DescriptiveNumber { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
    }
}
