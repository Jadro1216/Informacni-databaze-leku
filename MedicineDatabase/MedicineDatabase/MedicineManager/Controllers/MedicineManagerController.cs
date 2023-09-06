using MaterialSkin.Controls;
using MedicineDatabase.MedicineInformation.Views;
using MedicineDatabase.MedicineManager.Views;
using MedicineDatabase.Pharmacies.Views;
using MedicineDatabase.Pharmacies.Controllers;
using MedicineDatabase.MedicineInformation.Controllers;
using MedicineDatabase.MedicineManager.Models;
using MedicineDatabase.MedicineManager.Services;
using MedicineDatabase.MedicineManager.Components;

namespace MedicineDatabase.MedicineManager.Controllers
{
    public class MedicineManagerController
    {
        /// <summary>
        /// Main app form
        /// </summary>
        public MedicineManagerForm MedicineManagerForm { get; set; }
        public MyHealthForm MyHealthForm { get; set; } = new MyHealthForm();
        public MyHealthHelpForm MyHealthHelpForm { get; set; } = new MyHealthHelpForm();

        private IMedicineManagerService _medicineManagerService;
        public MedicineController _medicineController;
        public PharmacyController _pharmacyController;
        public HelpController _helpController;
        public DataController _dataController;
        public static dynamic lastForm = null;
        public MedicineManagerModel MedicineModel { get; set; }


        public MedicineManagerController()
        {
            _medicineManagerService = new MedicineManagerService();
            _medicineController = new MedicineController(this);
            _pharmacyController = new PharmacyController(this);
            MedicineModel = new MedicineManagerModel();
            MyHealthForm._medicineManagerController = this;
        }

        /// <summary>
        /// This function opens sub-form in the main form
        /// </summary>
        /// <param name="form">Form to be opened</param>
        public void OpenChildForm(dynamic form)
        {
            if (MedicineModel.LastForm != null)
            {
                MedicineModel.LastForm.Hide();
            }
            form.FormStyle = MaterialForm.FormStyles.StatusAndActionBar_None;
            MedicineModel.LastForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.ControlBox = false;
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
        }

        /// <summary>
        /// This function gets instance of a form according to type.
        /// </summary>
        /// <typeparam name="T">Form with the type T to get the instance of</typeparam>
        /// <returns></returns>
        public T? GetFormInstance<T>() where T : MaterialForm
        {
            MaterialForm form = null;

            if(typeof(T) == typeof(SearchPillsForm) || typeof(T) == typeof(PillsDetailForm) || typeof(T) == typeof(MedicineHelpForm))
            {
                return _medicineController.GetFormInstance<T>();
            }
            else if (typeof(T) == typeof(PharmaciesLocationForm) || typeof(T) == typeof(PharmaciesListAndDetailForm) || typeof(T) == typeof(PharmaciesHelpForm))
            {
                return _pharmacyController.GetFormInstance<T>();
            }
            else if (typeof(T) == typeof(MyHealthHelpForm))
            {
                return MyHealthHelpForm as T;
            }
            else if (typeof(T) == typeof(MyHealthForm))
            {
                return MyHealthForm as T;
            }
            return (T)form;
        }

        /// <summary>
        /// This function enables main form.
        /// </summary>
        /// <param name="enabled"></param>
        public void SetMainFormEnabled(bool enabled)
        {
            MedicineManagerForm.Enabled = enabled;
        }

        /// <summary>
        /// This function sets opened sub-form some properties to open and show it correctly
        /// </summary>
        /// <param name="form">Form to set properties to</param>
        public void SetPostOpenChildProperties(dynamic form)
        {
            MedicineManagerForm.containerPanel.Controls.Add(form);
            MedicineManagerForm.containerPanel.Tag = this;
            MedicineManagerForm.containerPanel.AutoScroll = true;
        }

        /// <summary>
        /// Thus function adds pill to user's list
        /// </summary>
        /// <param name="item"></param>
        public void AddPillToList(SmallPillListItem item)
        {
            if (MedicineModel.PillList.Any(itm => itm.SUKL.Equals(item.SUKL)))
            {
                var increaseItem = MedicineModel.PillList.FirstOrDefault(itm => itm.SUKL.Equals(item.SUKL));
                increaseItem.Count++;
            }
            else
            {
                MedicineModel.PillList.Add(item);
            }
        }

        /// <summary>
        /// This function hides active sub-form 
        /// </summary>
        public void HideActiveFormInMainForm()
        {
            MedicineModel.LastForm.Hide();
            MedicineModel.LastForm = null;
        }
        
        /// <summary>
        /// This function returns the instance of the main form <see cref="MedicineManagerForm"/> 
        /// </summary>
        /// <returns></returns>
        public MedicineManagerForm GetMainFormInstance()
        {
            return MedicineManagerForm;
        }


        /// <summary>
        /// This function ensures to change language in all application forms and controls
        /// </summary>
        public void ChangeLanguageInitialization()
        {
            MyHealthHelpForm = new MyHealthHelpForm();
            _pharmacyController.ChangeLanguageInitialization();
            _medicineController.ChangeLanguageInitialization();
        }

        /// <summary>
        /// This function returns allergies, that user filled in as health info
        /// </summary>
        /// <returns>Array of allergies</returns>
        public string[] GetAlergies()
        {
            return MedicineModel.Allergies;
        }

        /// <summary>
        /// This function returns health problems user is already healing, that user filled in as health info
        /// </summary>
        /// <returns></returns>
        public string[] GetHealthProblems()
        {
            return MedicineModel.HealthProblems;
        }
    }
}
