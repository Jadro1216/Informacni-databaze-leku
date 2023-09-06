using MedicineDatabase.MedicineManager.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineDatabase.MedicineManager.Models
{
    public class MedicineManagerModel
    {
        /// <summary>
        /// User's list of medicines
        /// </summary>
        public List<SmallPillListItem> PillList { get; set; }
        /// <summary>
        /// User's health problems he is already healing, that he filled in as health info
        /// </summary>
        public string[] HealthProblems { get; set; }
        /// <summary>
        /// User's allergies, that he filled in as health info
        /// </summary>
        public string[] Allergies { get; set; }
        /// <summary>
        /// Last active sub-form opened in the main form.
        /// </summary>
        public dynamic? LastForm { get; set; }

        public MedicineManagerModel()
        {
            PillList = new List<SmallPillListItem>();
            LastForm = null;
        }

    }
}
