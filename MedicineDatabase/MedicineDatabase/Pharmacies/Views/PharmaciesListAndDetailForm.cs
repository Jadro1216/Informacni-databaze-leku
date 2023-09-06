using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.Net;
using MedicineDatabase.Languages;
using MedicineDatabase.Pharmacies.Controllers;
using MedicineDatabase.Pharmacies.Components;

namespace MedicineDatabase.Pharmacies.Views
{
    public partial class PharmaciesListAndDetailForm : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        public PharmacyController _pharmacyController;
        public PharmaciesListAndDetailForm()
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

        private void PharmaciesListAndDetail_Load(object sender, EventArgs e)
        {
            gmapPharmacies.MapProvider = GMapProviders.GoogleMap;

        }

        private void gmapPharmacies_Load(object sender, EventArgs e)
        {
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmapPharmacies.Zoom = 17;
            gmapPharmacies.ShowCenter = false;
            gmapPharmacies.DragButton = MouseButtons.Left;
        }

        private void webListBox_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            Uri urlCheck = new Uri(webListBox.SelectedItem.Text);
            WebRequest request = WebRequest.Create(urlCheck);
            request.Timeout = 15000;

            WebResponse response;
            try
            {
                response = request.GetResponse();
                Process.Start(new ProcessStartInfo(urlCheck.ToString()) { UseShellExecute = true });
                Console.WriteLine("ok");
            }
            catch (Exception)
            {
                Console.WriteLine("error"); //url does not exist
            }

        }

        private void routeButton_Click(object sender, EventArgs e)
        {
            GMapMarker tmp;
            foreach (var marker in _pharmacyController.Markers.Markers)
            {
                if (marker.IsVisible && !marker.Tag.Equals("location"))
                {
                    var tag = marker.Tag;
                    GMapRoute tmpRoute;
                    try
                    {
                        tmpRoute = _pharmacyController.Routes.Routes.First(r => r.Tag == tag);
                        ToggleRouteVisibility(tmpRoute);
                        _pharmacyController.OldRoute = tmpRoute;
                        _pharmacyController.Routes.Routes.Add(tmpRoute);
                    }
                    catch (Exception)
                    { //no matching elements -> route does not exists
                        var route = GoogleMapProvider.Instance
                            .GetRoute(_pharmacyController.Location, marker.Position, false, true, 14);
                        tmpRoute = new GMapRoute(route.Points, "Route to " + marker.ToolTipText)
                        {
                            Stroke = new Pen(Color.Red, 5)
                        };
                        tmpRoute.Tag = marker.Tag;
                        _pharmacyController.OldRoute = tmpRoute;
                        _pharmacyController.Routes.Routes.Add(tmpRoute);
                    }
                    gmapPharmacies.RefreshMap();
                    return;
                }
            }
        }

        #region No control event functions
        private void ToggleMarkerVisibility(GMapMarker marker)
        {
            if (marker.IsVisible) marker.IsVisible = false;
            else marker.IsVisible = true;
        }

        private void ToggleRouteVisibility(GMapRoute route)
        {
            if (route != null)
            {
                if (route.IsVisible) route.IsVisible = false;
                else route.IsVisible = true;
            }
        }

        internal void ShowDetails(ListItem item)
        {
            webListBox.Items.Clear();
            phoneListBox.Items.Clear();
            emailListBox.Items.Clear();
            pharmacyNameLabel.Text = item.Name;
            addressPharmacyLabel.Text = item.Address;
            distancePharmacyLabel.Text = item.Distance;
            mondayLabel.Text = $"{Language.DayMondayShort} " + item.Hours["PO"];
            hoursTooltip.SetToolTip(mondayLabel, $"{Language.DayMonday} {item.Hours["PO"]}");
            tuesdayLabel.Text = $"{Language.DayTuesdayShort} " + item.Hours["UT"];
            hoursTooltip.SetToolTip(tuesdayLabel, $"{Language.DayTuesday} {item.Hours["UT"]}");
            wednesdayLabel.Text = $"{Language.DayWednesdayShort} " + item.Hours["ST"];
            hoursTooltip.SetToolTip(wednesdayLabel, $"{Language.DayWednesday} {item.Hours["ST"]}");
            thursdayLabel.Text = $"{Language.DayThursdayShort} " + item.Hours["ŠT"];
            hoursTooltip.SetToolTip(thursdayLabel, $"{Language.DayThursday} {item.Hours["ŠT"]}");
            fridayLabel.Text = $"{Language.DayFridayShort} " + item.Hours["PI"];
            hoursTooltip.SetToolTip(fridayLabel, $"{Language.DayFriday} {item.Hours["PI"]}");
            saturdayLabel.Text = $"{Language.DaySaturdayShort} " + item.Hours["SO"];
            hoursTooltip.SetToolTip(saturdayLabel, $"{Language.DaySaturday} {item.Hours["SO"]}");
            sundayLabel.Text = $"{Language.DaySundayShort} " + item.Hours["NE"];
            hoursTooltip.SetToolTip(sundayLabel, $"{Language.DaySunday} {item.Hours["NE"]}");
            holidayLabel.Text = $"{Language.DayHolidayShort} " + item.Hours["SVIATOK"];
            hoursTooltip.SetToolTip(holidayLabel, $"{Language.DayHoliday} {item.Hours["SVIATOK"]}");
            foreach (var www in item.Web)
            {
                webListBox.Items.Add(new MaterialListBoxItem(www));
            }
            foreach (var tel in item.Phone)
            {
                phoneListBox.Items.Add(new MaterialListBoxItem(tel));
            }
            foreach (var email in item.Email)
            {
                emailListBox.Items.Add(new MaterialListBoxItem(email));
            }
        }

        internal void SwitchMarkers(int newMarkerId)
        {
            GMapMarker tmp = null;
            foreach (var marker in _pharmacyController.Markers.Markers)
            {
                if (_pharmacyController.OldMarker != null && marker.Tag.Equals(_pharmacyController.OldMarker.Tag))
                    ToggleMarkerVisibility(marker);
                if (marker.Tag is int && (int)marker.Tag == newMarkerId)
                {
                    ToggleMarkerVisibility(marker);
                    SetPosition(marker);
                    tmp = marker;
                }
            }
            gmapPharmacies.RefreshMap();
            _pharmacyController.OldMarker = tmp;
        }

        public void AddOverlay(GMapOverlay overlay)
        {
            gmapPharmacies.Overlays.Add(overlay);
        }

        private void SetPosition(GMapMarker marker)
        {
            gmapPharmacies.Position = marker.Position;
        }
        #endregion

        #region Other Events
        private void pharmacyListHelpButton_Click(object sender, EventArgs e)
        {
            var form = _pharmacyController.GetFormInstance<PharmaciesHelpForm>();
            _pharmacyController.OpenFormInMainForm(form);
        }

        private void pharmacyNameLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 212, (float)label.Height / 48);

            float newFontSize = 14F * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize);

            label.Font = newFont;
        }

        private void largeLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 212, (float)label.Height / 48);

            float newFontSize = 10F * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize);

            label.Font = newFont;
        }

        private void mediumLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 212, (float)label.Height / 22);

            float newFontSize = 10F * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize);

            label.Font = newFont;
        }

        private void smallLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 82, (float)label.Height / 48);

            float newFontSize = 10F * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize);

            label.Font = newFont;
        }

        private void openHoursLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 101, (float)label.Height / 16);

            float newFontSize = 7 * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize, FontStyle.Regular, GraphicsUnit.Point);

            label.Font = newFont;
        }

        public void ShowDetails_Handler(object sender, EventArgs e)
        {
            var item = (ListItem)sender;
            if (_pharmacyController.Routes.Routes.Any(r => r.IsVisible))
            {
                ToggleRouteVisibility(_pharmacyController.Routes.Routes.First(r => r.IsVisible));
            }

            ShowDetails(item);
            SwitchMarkers(item.Id);
        }

        #endregion

        private void pharmaciesList_SizeChanged(object sender, EventArgs e)
        {
            int itemWidth = pharmaciesList.ClientSize.Width;

            foreach (Control item in pharmaciesList.Controls)
            {
                item.Width = itemWidth;
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            var form = _pharmacyController.GetFormInstance<PharmaciesLocationForm>();
            _pharmacyController.OpenFormInMainForm(form);

            _pharmacyController.ResetMarkersAndRoutes();

            if (_pharmacyController.PharmaciesLocationForm.gmapLocation.Overlays.Count > 0)
            {
                _pharmacyController.PharmaciesLocationForm.gmapLocation.Overlays.RemoveAt(0);
                _pharmacyController.PharmaciesLocationForm.gmapLocation.RefreshMap();
            }
            if (_pharmacyController.PharmaciesListAndDetailForm.gmapPharmacies.Overlays.Count > 0)
            {
                _pharmacyController.PharmaciesListAndDetailForm.gmapPharmacies.Overlays.RemoveAt(0);  //remove Markers
                _pharmacyController.PharmaciesListAndDetailForm.gmapPharmacies.Overlays.RemoveAt(0);  // remove Routes
                _pharmacyController.PharmaciesListAndDetailForm.gmapPharmacies.RefreshMap();
            }
        }
    }
}
