using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineDatabase.Pharmacies.Domain
{
    public class Pharmacist
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? TitleBefore { get; set; }
        public string? TitleAfter { get; set; }
    }
}
