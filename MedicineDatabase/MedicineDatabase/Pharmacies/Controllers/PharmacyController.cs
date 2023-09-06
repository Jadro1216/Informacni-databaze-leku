using GMap.NET.WindowsForms;
using GMap.NET;
using MaterialSkin.Controls;
using MedicineDatabase.Pharmacies.Views;
using System.Device.Location;
using System.Text;
using MedicineDatabase.Properties;
using MedicineDatabase.Languages;
using MedicineDatabase.Pharmacies.Services;
using MedicineDatabase.Pharmacies.Models;
using MedicineDatabase.Pharmacies.Components;
using MedicineDatabase.MedicineManager.Controllers;
using MedicineDatabase.MedicineManager.Views;
using MedicineDatabase.MedicineManager.Services;

namespace MedicineDatabase.Pharmacies.Controllers
{
    public class PharmacyController
    {
        private readonly IPharmacyService _pharmacyService;
        private readonly IDataService _dataService;
        private MedicineManagerController _medicineManagerController;
        public GeoCoordinate Coordinates { get; set; }
        public PointLatLng Location { get; set; }
        public GMapOverlay Markers { get; set; } = new GMapOverlay("Markers");
        public GMapOverlay Routes { get; set; } = new GMapOverlay("Routes");
        public List<PharmacyModel> Pharmacies { get; set; }
        public GMapMarker OldMarker { get; set; }
        public GMapRoute OldRoute { get; set; }
        public bool UseApi { get; set; } = true;
        public PharmaciesLocationForm PharmaciesLocationForm { get; set; } = new PharmaciesLocationForm();
        public PharmaciesListAndDetailForm PharmaciesListAndDetailForm { get; set; } = new PharmaciesListAndDetailForm();
        public PharmaciesHelpForm PharmaciesHelpForm { get; set; } = new PharmaciesHelpForm();

        public PharmacyController(MedicineManagerController medicineManagerController)
        {
            _pharmacyService = new PharmacyService(this);
            _dataService = new DataService();
            PharmaciesLocationForm._pharmacyController = this;
            PharmaciesListAndDetailForm._pharmacyController = this;
            PharmaciesLocationForm.loadPharmaciesWorker.RunWorkerAsync();
            _medicineManagerController = medicineManagerController;
            //pharmaciesListAndDetailForm = new PharmaciesListAndDetailForm();
            //pharmaciesLocationForm = new PharmaciesLocationForm();
        }

        /// <summary>
        /// This function calls <see cref="_pharmacyService"/> to get user's coordinates according to address he wrote
        /// </summary>
        /// <param name="street">String representing street name</param>
        /// <param name="number">String representing street number</param>
        /// <param name="city">String representing city</param>
        /// <param name="postalCode">String representing zip/postal code</param>
        /// <returns>String array of coordinations</returns>
        public string[] GetUserLocationCoordinates(string street, string number, string city, string postalCode)
        {
            return _pharmacyService.GetUserLocationCoordinates(street, number, city, postalCode);
        }

        /// <summary>
        /// This function calls <see cref="_pharmacyService"/> to reset markers and routes of map
        /// </summary>
        public void ResetMarkersAndRoutes()
        {
            _pharmacyService.ResetMarkersAndRoutes();
        }

        /// <summary>
        /// This function calculates distances between user's and pharmacies coordinates
        /// </summary>
        public void CalculateDistances()
        {
            foreach (var pharma in Pharmacies)
            {
                pharma.Distance = Math.Round(Coordinates.GetDistanceTo(pharma.Coordinates), 4);
            }
        }

        /// <summary>
        /// This function creates <see cref="ListItem"/> for every pharmacy and appends it to <see cref="PharmaciesListAndDetailForm.pharmaciesList"/>
        /// </summary>
        public void FillPharmaciesList()
        {
            PharmaciesListAndDetailForm.pharmaciesList.Controls.Clear();
            int k = Const.NumOfPharmacies;
            var nearest = Pharmacies;
            var adr = new StringBuilder();
            var vzd = new StringBuilder();
            for (int i = 0; i < k; i++)
            {
                var item = new ListItem();
                item.Name = nearest[i].Name;
                item.Icon = Resources.drugstore;
                
                if (nearest[i].Address.Street == null)
                {
                    adr.Append(nearest[i].Address.City + " ");
                    if (nearest[i].Address.OrientationNumber == null)
                    {
                        adr.Append(nearest[i].Address.DescriptiveNumber + ", ");
                    }
                    else
                    {
                        adr.Append(nearest[i].Address.DescriptiveNumber + "/" + nearest[i].Address.OrientationNumber + ", ");
                    }
                    adr.Append(nearest[i].Address.PostalCode);
                    adr.Append(' ');
                    adr.Append(nearest[i].Address.City);
                }
                else
                {
                    adr.Append(nearest[i].Address.Street + " ");
                    if (nearest[i].Address.OrientationNumber == null)
                    {
                        adr.Append(nearest[i].Address.DescriptiveNumber + ", ");
                    }
                    else
                    {
                        adr.Append(nearest[i].Address.DescriptiveNumber + "/" + nearest[i].Address.OrientationNumber + ", ");
                    }
                    adr.Append(nearest[i].Address.PostalCode);
                    adr.Append(' ');
                    adr.Append(nearest[i].Address.City);
                }
                item.Address = adr.ToString();
                adr.Clear();
                vzd.Append(Language.DistanceText);
                vzd.Append(nearest[i].Distance);
                vzd.Append(" m");
                item.Distance = vzd.ToString();
                vzd.Clear();
                item.Id = nearest[i].Id;
                item.CIN = nearest[i].Ico;      //copany identification number
                item.Web = nearest[i].Web;
                item.Email = nearest[i].Email;
                item.Phone = nearest[i].Phone;
                item.Coordinates = nearest[i].Coordinates;
                item.Hours = nearest[i].Hours;
                item.ListItemClick += new EventHandler(PharmaciesListAndDetailForm.ShowDetails_Handler);
                PharmaciesListAndDetailForm.pharmaciesList.Controls.Add(item);
            }
        }

        /// <summary>
        /// This function calls <see cref="_pharmacyService"/> to load pharmacies from database
        /// </summary>
        /// <exception cref="Exception">Thrown when loading data from database failed</exception>
        public void LoadPharmacies()
        {
            try
            {
                var pharmacies = _pharmacyService.LoadPharmacies();
                Pharmacies = pharmacies;
            }
            catch (Exception ex)
            {
                throw new Exception($"Load pharmacies failed: {ex.Message}");
            }

        }

        /// <summary>
        /// This function calls <see cref="_pharmacyService"/> to add markers to all pharmacies
        /// </summary>
        public void AddMarkers()
        {
            _pharmacyService.AddMarkers();
        }

        /// <summary>
        /// This function gets instance of a form according to type 
        /// </summary>
        /// <typeparam name="T">Form of type T to get instance of</typeparam>
        /// <returns>Returns appropriate form instance</returns>
        public T? GetFormInstance<T>() where T : MaterialForm
        {
            if (typeof(T) == typeof(PharmaciesLocationForm))
            {
                return PharmaciesLocationForm as T;
            }
            else if (typeof(T) == typeof(PharmaciesListAndDetailForm))
            {
                return PharmaciesListAndDetailForm as T;
            }
            else if (typeof(T) == typeof(PharmaciesHelpForm))
            {
                return PharmaciesHelpForm as T;
            }
            return null;
        }

        /// <summary>
        /// This function will ensure that the active sub-form will hide.
        /// </summary>
        public void HideActiveFormInMainForm()
        {
            _medicineManagerController.HideActiveFormInMainForm();
        }

        /// <summary>
        /// This function returns instance of <see cref="MedicineManagerForm"/>
        /// </summary>
        /// <returns></returns>
        public MedicineManagerForm GetMainFormInstance()
        {
            return _medicineManagerController.GetMainFormInstance();
        }

        /// <summary>
        /// This function ensures to open sub-form in the main form
        /// </summary>
        /// <param name="form">Form to be opened</param>
        public void OpenFormInMainForm(dynamic form)
        {
            _medicineManagerController.OpenChildForm(form);
            _medicineManagerController.SetPostOpenChildProperties(form);
        }

        /// <summary>
        /// This function ensures to change language of the application in all forms and controls.
        /// </summary>
        public void ChangeLanguageInitialization()
        {
            PharmaciesLocationForm.Controls.Clear();
            PharmaciesLocationForm.InitializeComponent();
            PharmaciesListAndDetailForm.Controls.Clear();
            PharmaciesListAndDetailForm.InitializeComponent();
            PharmaciesHelpForm = new PharmaciesHelpForm();
        }
    }
}
