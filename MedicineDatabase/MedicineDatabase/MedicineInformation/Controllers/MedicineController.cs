using MaterialSkin.Controls;
using MedicineDatabase.Languages;
using MedicineDatabase.MedicineInformation.Services;
using MedicineDatabase.Properties;
using MedicineDatabase.MedicineManager.Views;
using MedicineDatabase.MedicineInformation.Views;
using MedicineDatabase.MedicineManager.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicineDatabase.MedicineInformation.Models;
using MedicineDatabase.MedicineInformation.Components;
using MedicineDatabase.MedicineManager.Controllers;
using MedicineDatabase.MedicineManager.Services;

namespace MedicineDatabase.MedicineInformation.Controllers
{
    public class MedicineController
    {
        private readonly IMedicineService _medicineService;
        private readonly IDataService _dataService;
        public MedicineManagerController _medicineManagerController;
        public SearchPillsForm SearchPillsForm { get; set; } = new SearchPillsForm();
        public PillsDetailForm PillsDetailForm { get; set; } = new PillsDetailForm();
        public MedicineHelpForm MedicineHelpForm { get; set; } = new MedicineHelpForm();
        public FileModalBox fileModalBox;
        public List<MedicineModel> Pills { get; set; }
        public bool SearchingPills { get; set; }

        public MedicineController(MedicineManagerController medicineManagerController)
        {
            _dataService = new DataService();
            _medicineService = new MedicineService(this);
            SearchPillsForm._medicineController = this;
            PillsDetailForm._medicineController = this;
            _medicineManagerController = medicineManagerController;
        }

        /// <summary>
        /// This function searches medicine pills in database according to searched text and filter, that user filled in 
        /// </summary>
        /// <param name="searchText">Searched text</param>
        /// <param name="filter">String representation of filter type</param>
        /// <exception cref="Exception">Thrown when getting medicine pills from db failed</exception>
        public void GetMedicinePills(string searchText, string filter)
        {
            try
            {
                var alergies = _medicineManagerController.GetAlergies();
                var healthProblems = _medicineManagerController.GetHealthProblems();
                List<MedicineModel> pills = _medicineService.LoadMedicinePills(searchText, filter, healthProblems, alergies);
                pills.GroupBy(m => new { m.Name, m.DocumentFile.FileName })
                    .Select(g => new MedicineModel
                    {
                        Name = g.Key.Name,
                        Packing = null,
                        Simmiar = g.ToList()
                    })
                    .ToList().ForEach(g =>
                    {
                        foreach (var item in g.Simmiar)
                        {
                            item.Simmiar = g.Simmiar.Where(itm => itm != item).ToList();
                        }
                    });
                var groupped = pills.GroupBy(m => new { m.Name, m.DocumentFile.FileName }).Select(g => g.First()).ToList();
                Pills = groupped;

                Console.WriteLine("Loading medicines was successful.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Load medicines failed: {ex.Message}");
            }
        }


        /// <summary>
        /// This funciton will create <see cref="PillsListItem"/> for every searched pill and add it to the pills list <see cref="SearchPillsForm.pillsLayoutPanel"/>
        /// </summary>
        public void FillMedicineList()
        {
            SearchPillsForm.pillsLayoutPanel.Invoke(new Action(() => SearchPillsForm.pillsLayoutPanel.SuspendLayout()));

            SearchPillsForm.pillsLayoutPanel.Invoke(new Action(() => SearchPillsForm.pillsLayoutPanel.Controls.Clear()));

            foreach (var item in Pills)
            {
                PillsListItem pillItem = new PillsListItem();
                if (item.Problem != null)
                {
                    pillItem.tableLayoutPanel1.BackColor = Color.Red;
                    pillItem.pillListItemToolTip.SetToolTip(pillItem, Language.ProblemPillTolltipText);
                    pillItem.pillListItemToolTip.SetToolTip(pillItem.pillNameLabel, Language.ProblemPillTolltipText);
                    pillItem.pillListItemToolTip.SetToolTip(pillItem.pillATCLabel, Language.ProblemPillTolltipText);
                    pillItem.pillListItemToolTip.SetToolTip(pillItem.pillSuklLabel, Language.ProblemPillTolltipText);
                    pillItem.pillListItemToolTip.SetToolTip(pillItem.pillPictureBox, Language.ProblemPillTolltipText);
                    pillItem.pillListItemToolTip.SetToolTip(pillItem.tableLayoutPanel1, Language.ProblemPillTolltipText);
                }
                pillItem.Name = item.Name;
                pillItem.SUKLCode = Language.PillListItem_SUKLCode + item.SUKLCode;
                pillItem.ATC = "ATC: " + item.ATC;
                pillItem.Pill = item;
                pillItem.Icon = Resources.Pill_Item;
                pillItem.pillNameLabel.Text = item.Name + "\n" + item.Supplement;
                pillItem.PillListItemClick += new EventHandler(PillsDetailForm.ShowDetails_Handler);
                SearchPillsForm.pillsLayoutPanel.Invoke(new Action(() => SearchPillsForm.pillsLayoutPanel.Controls.Add(pillItem)));
            }
            SearchPillsForm.pillsLayoutPanel.Invoke(new Action(() => SearchPillsForm.pillsLayoutPanel.ResumeLayout()));
        }

        /// <summary>
        /// This function gets and returns form instance of type T
        /// </summary>
        /// <typeparam name="T">Form of type T</typeparam>
        /// <returns></returns>
        public T GetFormInstance<T>() where T : MaterialForm
        {
            if (typeof(T) == typeof(SearchPillsForm))
            {
                return SearchPillsForm as T;
            }
            else if (typeof(T) == typeof(PillsDetailForm))
            {
                return PillsDetailForm as T;
            }
            else if (typeof(T) == typeof(MedicineHelpForm))
            {
                return MedicineHelpForm as T;
            }
            else if (typeof(T) == typeof(MyHealthForm))
            {
                return _medicineManagerController.GetFormInstance<T>();
            }
            return null;
        }

        /// <summary>
        /// This function set enabled property to main form 
        /// </summary>
        /// <param name="enable">Bool value to set</param>
        public void SetMainFormEnabled(bool enable)
        {
            _medicineManagerController.SetMainFormEnabled(enable);
        }

        /// <summary>
        /// This function opens sub-form in the main form
        /// </summary>
        /// <param name="form">Form to be opened</param>
        public void OpenFormInMainForm(dynamic form)
        {
            _medicineManagerController.OpenChildForm(form);
            _medicineManagerController.SetPostOpenChildProperties(form);
        }

        /// <summary>
        /// This function adds pill, as type <see cref="SmallPillListItem"/>, to user's list of medicine pills
        /// </summary>
        /// <param name="item">Pill to add to the list</param>
        public void AddPillToList(SmallPillListItem item)
        {
            _medicineManagerController.AddPillToList(item);
        }


        /// <summary>
        /// This form returns instance of the main form <see cref="MedicineManagerForm"/>
        /// </summary>
        /// <returns></returns>
        public MedicineManagerForm GetMainForm()
        {
            return _medicineManagerController.GetMainFormInstance();
        }

        /// <summary>
        /// This function ensures to change language of the application in all forms and controls.
        /// </summary>
        public void ChangeLanguageInitialization()
        {
            SearchPillsForm.Controls.Clear();
            SearchPillsForm.InitializeComponent();
            PillsDetailForm.Controls.Clear();
            PillsDetailForm.InitializeComponent();
            MedicineHelpForm = new MedicineHelpForm();
        }
    }
}
