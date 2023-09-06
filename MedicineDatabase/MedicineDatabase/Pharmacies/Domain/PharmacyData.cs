using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineDatabase.Pharmacies.Domain
{
    public class PharmacyData
    {
        public List<PharmacyObject> Data { get; set; }
        public int Celkem { get; set; }
    }

    public class PharmacyObject
    {
        public string Nazev { get; set; }
        public string KodPracoviste { get; set; }
        public string KodLekarny { get; set; }
        public string Icz { get; set; }
        public string Ico { get; set; }
        public string TypLekarny { get; set; }
        public AddressObject Adresa { get; set; }
        public PharmacistObject VedouciLekarnik { get; set; }
        public ContactObject Kontakty { get; set; }
        public OpeningHoursObject OteviraciDoba { get; set; }
        public bool Pohotovost { get; set; }
        public bool RozsirenaPracDoba { get; set; }
        public List<string> Eshop { get; set; }
        public CoordinatesObject Souradnice { get; set; }
    }

    public class AddressObject
    {
        public string Obec { get; set; }
        public string Ulice { get; set; }
        public string CisloOrientacni { get; set; }
        public string CisloPopisne { get; set; }
        public string Psc { get; set; }
    }

    public class PharmacistObject
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string TitulPred { get; set; }
        public string TitulZa { get; set; }
    }

    public class ContactObject
    {
        public List<string> Telefon { get; set; }
        public List<string> Email { get; set; }
        public List<string> Web { get; set; }
        public List<string> Fb { get; set; }
        public List<string> Twitter { get; set; }
    }

    public class OpeningHoursObject
    {
        public List<OpeningHoursItem> Polozky { get; set; }
        public bool Pohotovost { get; set; }
        public bool RozsirenaPracDoba { get; set; }
    }

    public class OpeningHoursItem
    {
        public int Den { get; set; }
        public List<OpeningHoursTime> Doby { get; set; }
        public string Poznamka { get; set; }
    }

    public class OpeningHoursTime
    {
        public string Od { get; set; }
        public string Do { get; set; }
    }

    public class CoordinatesObject
    {
        public double? Gpsn { get; set; }
        public double? Gpse { get; set; }
    }
}
