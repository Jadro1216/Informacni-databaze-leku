using MedicineDatabase.MedicineInformation.Domain;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineDatabase.MedicineInformation.Models
{
    /// <summary>
    /// This class represents medicine pill item with multiple properties
    /// </summary>
    public class MedicineModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SUKLCode { get; set; }
        public string? MedicalPower { get; set; }
        public string? Form { get; set; }
        public string? Packing { get; set; }
        public string? WayOfUse { get; set; }
        public string? Supplement { get; set; }
        public string? Cover { get; set; }
        public string? RegistrationHolder { get; set; }
        public string? HolderCountry { get; set; }
        public string? RegistrationState { get; set; }
        public string? RegistrationValidTo_DDMMYY { get; set; }
        public string? UnlimitedRegistration { get; set; }
        public string? IndicationGroup { get; set; }
        public string? ATC { get; set; }
        public string? ATC_Name { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? RegistrationProcedure { get; set; }
        public string? WHO_Index { get; set; }
        public string? MedicalSubstances { get; set; }
        public string? Dispensing { get; set; }
        public string? Doping { get; set; }
        public string? Expiration { get; set; }
        public string? Expoiration_Type { get; set; }
        public string? RegisteredName { get; set; }
        public string? Indications { get; set; }
        public string? Contraindications { get; set; }
        public string? SideEffects { get; set; }
        public string? Applicability { get; set; }
        public string? Warnings { get; set; }
        public string? Interactions { get; set; }
        public string? Dosage { get; set; }
        public string? Compositions { get; set; }
        public string? Substances { get; set; }
        public string? Overdose { get; set; }
        public DocumentFile? DocumentFile { get; set; }
        public List<MedicineModel> Simmiar { get; set; }
        public string? Problem { get; set; }     //indicates wheter medicine is problematic to users health
    }
}
