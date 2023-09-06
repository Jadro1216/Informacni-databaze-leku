using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;
using System.Device.Location;
using System.Globalization;
using System.ComponentModel;
using MedicineDatabase.Languages;
using MedicineDatabase.Pharmacies.Controllers;
using MedicineDatabase.Pharmacies.Components;

namespace MedicineDatabase.Pharmacies.Views
{
    public partial class PharmaciesLocationForm : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        public PharmacyController _pharmacyController;
        private string oldStreet = "";
        private string oldNumber = "";
        private string oldCity = "";
        private string oldPostalCode = "";
        private Thread loadingThread;
        private bool isLoading;

        public PharmaciesLocationForm()
        {

            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red400, Primary.Blue500, //#EF5350, #2196F3
                Primary.Yellow500, Accent.LightBlue200, //#FFEB3B, #81D4FA 
                TextShade.WHITE
            );

        }

        private void PharaciesLocationForm_Load(object sender, EventArgs e)
        {
            gmapLocation.MapProvider = GMapProviders.GoogleMap;

        }

        private void gmapLocation_Load(object sender, EventArgs e)
        {
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmapLocation.Position = new PointLatLng(50.07618937368463, 14.437019595569714);
            gmapLocation.ShowCenter = false;
            gmapLocation.DragButton = MouseButtons.Left;

            Console.WriteLine("gmapLocation Loaded!");
        }


        private void locationTitle_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 397, (float)label.Height / 120);

            float newFontSize = 45F * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize, FontStyle.Regular, GraphicsUnit.Pixel);

            label.Font = newFont;
        }

        private void getLocationButton_Click(object sender, EventArgs e)
        {
            string street = streetText.Text;
            string city = cityText.Text;
            string postalCode = postalCodeText.Text;
            string number = addressNumberText.Text;

            oldStreet = street;
            oldNumber = number;
            oldCity = city;
            oldPostalCode = postalCode;

            string[] results = _pharmacyController.GetUserLocationCoordinates(street, number, city, postalCode);

            var ci = CultureInfo.InvariantCulture;
            bool good = false;
            try
            {
                _pharmacyController.Coordinates = new GeoCoordinate(
                           Double.Parse(results[0], ci),
                           Double.Parse(results[1], ci)
                );
                good = true;
            }
            catch (Exception)
            {
                badAddressPanel.Visible = true;
                badAddressLabel.Visible = true;
                closeButton.Visible = true;
                good = false;
            }

            if (good)
            {
                _pharmacyController.Location = new PointLatLng(
                    _pharmacyController.Coordinates.Latitude,
                    _pharmacyController.Coordinates.Longitude
                );

                gmapLocation.Position = new PointLatLng(
                    _pharmacyController.Coordinates.Latitude,
                    _pharmacyController.Coordinates.Longitude
                );
                GMapMarker marker = new GMarkerGoogle(
                    new PointLatLng(_pharmacyController.Coordinates.Latitude, _pharmacyController.Coordinates.Longitude),
                    GMarkerGoogleType.red_big_stop);
                marker.Tag = "location";
                marker.IsVisible = true;
                marker.ToolTipText = $"{Language.MyLocationTooltip} Latitude: {_pharmacyController.Coordinates.Latitude}, \nLongitude: {_pharmacyController.Coordinates.Longitude}"; //Latitude: {Shared.Coordinates.Latitude}, \nLongitude: {Shared.Coordinates.Longitude}";
                _pharmacyController.Markers.Markers.Add(marker);
                gmapLocation.Overlays.Add(_pharmacyController.Markers);
                gmapLocation.Zoom = 17;
                gmapLocation.RefreshMap();

                findPharmaciesButton.Enabled = true;
            }
            Console.WriteLine("Done");
        }

        private void PharaciesLocationForm_Resize(object sender, EventArgs e)
        {
            int panelWidth = badAddressPanel.Width;
            int panelHeight = badAddressPanel.Height;

            badAddressPanel.Left = (this.ClientSize.Width - panelWidth) / 2;
            badAddressPanel.Top = (this.ClientSize.Height - panelHeight) / 2;
        }

        private void badAddressLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 312, (float)label.Height / 192);

            float newFontSize = 18 * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize, FontStyle.Regular, GraphicsUnit.Point);

            label.Font = newFont;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            badAddressPanel.Visible = false;
            badAddressLabel.Visible = false;
            closeButton.Visible = false;
        }

        private void findPharmaciesButton_Click(object sender, EventArgs e)
        {
            var form = _pharmacyController.GetFormInstance<PharmaciesListAndDetailForm>();
            var main = _pharmacyController.GetMainFormInstance();
            _pharmacyController.HideActiveFormInMainForm();

            main.StartLoadingAnimation();

            while (loadPharmaciesWorker.IsBusy)
            {
                Application.DoEvents();
                this.Enabled = false;
                main.Enabled = false;
            }
            this.Enabled = true;
            main.Enabled = true;

            _pharmacyController.CalculateDistances();
            _pharmacyController.Pharmacies = _pharmacyController.Pharmacies.OrderBy(x => x.Distance).ToList();
            _pharmacyController.FillPharmaciesList();


            form.AddOverlay(_pharmacyController.Markers);
            form.AddOverlay(_pharmacyController.Routes);
            ListItem first = (ListItem)form.pharmaciesList.Controls[0];
            form.SwitchMarkers(first.Id);
            form.ShowDetails(first);
            _pharmacyController.PharmaciesListAndDetailForm = form;
            _pharmacyController.OpenFormInMainForm(form);
            main.StopLoadingAnimation();
        }

        private void AddressLabel_TextChanged(object sender, EventArgs e)
        {
            string street = streetText.Text;
            string city = cityText.Text;
            string postalCode = postalCodeText.Text;
            string number = addressNumberText.Text;

            if (oldStreet != street || oldNumber != number || oldCity != city || oldPostalCode != postalCode)
            {
                findPharmaciesButton.Enabled = false;
            }
        }

        private void loadPharmaciesWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("Load pharmacies worker started. ");
            _pharmacyController.LoadPharmacies();
        }

        private void loadPharmaciesWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _pharmacyController.AddMarkers();
            Console.WriteLine("Load pharmacies worker finished.");
        }

        private void loadPharmaciesWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void firstTabHelp_Click(object sender, EventArgs e)
        {
            var form = _pharmacyController.GetFormInstance<PharmaciesHelpForm>();
            _pharmacyController.OpenFormInMainForm(form);
        }
    }
}
