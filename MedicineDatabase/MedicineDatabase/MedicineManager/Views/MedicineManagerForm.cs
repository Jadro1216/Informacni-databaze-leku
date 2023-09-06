using MaterialSkin;
using MaterialSkin.Controls;
using MedicineDatabase.Pharmacies.Views;
using MedicineDatabase.MedicineManager.Components;
using System.Globalization;
using MedicineDatabase.MedicineInformation.Views;
using MedicineDatabase.Pharmacies.Controllers;
using MedicineDatabase.MedicineManager.Controllers;
using MedicineDatabase.Pharmacies;

namespace MedicineDatabase.MedicineManager.Views
{

    public partial class MedicineManagerForm : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        private MedicineManagerController _medicineManagerController;
        private PharmacyController _pharmacyController;
        private dynamic activeForm = null;
        private Thread loadingThread;
        private bool isLoading;
        public SearchLoadingPanel LoadingPanel { get; set; }

        public MedicineManagerForm(MedicineManagerController medicineManagerController)
        {
            _medicineManagerController = medicineManagerController;
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

            medicineManagerController.MedicineManagerForm = this;
            //Shared.MainForm = this;
            //_medicineManagerController
            _pharmacyController = medicineManagerController._pharmacyController;     //new PharmacyController();
            var form = _medicineManagerController.GetFormInstance<SearchPillsForm>();
            _medicineManagerController.OpenChildForm(form);
            containerPanel.Controls.Add(form);
            containerPanel.Tag = form;
            //Shared.OpenChildForm(Shared.SearchPillsForm);
            //containerPanel.Controls.Add(Shared.SearchPillsForm);
            //containerPanel.Tag = Shared.SearchPillsForm;

        }

        private void hideSubMenu()
        {
            if (pillsSubMenuPanel.Visible)
            {
                pillsSubMenuPanel.Visible = false;
            }
            if (pharmaciesSubMenuPanel.Visible)
            {
                pharmaciesSubMenuPanel.Visible = false;
            }
            if (helpSubMenuPanel.Visible)
            {
                helpSubMenuPanel.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }
        #region Pills sub-menu
        private void pillsButton_Click(object sender, EventArgs e)
        {
            showSubMenu(pillsSubMenuPanel);
        }

        private void searchPillsButton_Click(object sender, EventArgs e)
        {
            // code
            //Shared.OpenChildForm(Shared.SearchPillsForm);
            //containerPanel.Controls.Add(Shared.SearchPillsForm);
            //containerPanel.Tag = Shared.SearchPillsForm;
            var form = _medicineManagerController.GetFormInstance<SearchPillsForm>();
            _medicineManagerController.OpenChildForm(form);
            containerPanel.Controls.Add(form);
            containerPanel.Tag = form;

            hideSubMenu();
        }

        private void detailPillButton_Click(object sender, EventArgs e)
        {
            // code
            var form = _medicineManagerController.GetFormInstance<PillsDetailForm>();
            _medicineManagerController.OpenChildForm(form);
            form.Dock = DockStyle.Top;
            containerPanel.Controls.Add(form);
            containerPanel.Tag = form;
            //Shared.OpenChildForm(Shared.PillsDetailForm);
            //Shared.PillsDetailForm.Dock = DockStyle.Top;
            //containerPanel.Controls.Add(Shared.PillsDetailForm);
            //containerPanel.Tag = Shared.PillsDetailForm;
            containerPanel.AutoScroll = true;

            hideSubMenu();
        }
        #endregion
        #region Pharmacy sub-menu
        private void pharmaciesButton_Click(object sender, EventArgs e)
        {
            showSubMenu(pharmaciesSubMenuPanel);
        }

        private void pharmaciesLocationButton_Click(object sender, EventArgs e)
        {
            StartLoadingAnimation();

            var form = _medicineManagerController.GetFormInstance<PharmaciesLocationForm>();
            _medicineManagerController.OpenChildForm(form);
            containerPanel.Controls.Add(form);
            containerPanel.Tag = form;
            //var form = new PharmaciesLocationForm();
            //Shared.OpenChildForm(Shared.PharmaciesLocationForm);
            //containerPanel.Controls.Add(Shared.PharmaciesLocationForm);
            //containerPanel.Tag = Shared.PharmaciesLocationForm;
            // code

            // reseting markers
            _pharmacyController.ResetMarkersAndRoutes();
            //if (Shared.PharmaciesLocationForm.gmapLocation.Overlays.Count > 0)
            //{
            //    Shared.PharmaciesLocationForm.gmapLocation.Overlays.RemoveAt(0);
            //    Shared.PharmaciesLocationForm.gmapLocation.RefreshMap();
            //}
            //if (Shared.PharmaciesListAndDetailForm.gmapPharmacies.Overlays.Count > 0)
            //{
            //    Shared.PharmaciesListAndDetailForm.gmapPharmacies.Overlays.RemoveAt(0);  //remove Markers
            //    Shared.PharmaciesListAndDetailForm.gmapPharmacies.Overlays.RemoveAt(0);  // remove Routes
            //    Shared.PharmaciesListAndDetailForm.gmapPharmacies.RefreshMap();
            //}
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
            hideSubMenu();
            StopLoadingAnimation();
        }

        private void pharmaciesListButton_Click(object sender, EventArgs e)
        {
            //var form = new PharmaciesListAndDetailForm();
            //Shared.OpenChildForm(Shared.PharmaciesListAndDetailForm);
            //containerPanel.Controls.Add(Shared.PharmaciesListAndDetailForm);
            //containerPanel.Tag = Shared.PharmaciesListAndDetailForm;
            var form = _medicineManagerController.GetFormInstance<PharmaciesListAndDetailForm>();
            _medicineManagerController.OpenChildForm(form);
            containerPanel.Controls.Add(form);
            containerPanel.Tag = form;
            // code

            hideSubMenu();
        }
        #endregion
        #region Help sub-menu
        private void helpButton_Click(object sender, EventArgs e)
        {
            // code
            showSubMenu(helpSubMenuPanel);
            //hideSubMenu();
        }


        private void helpPillsButton_Click(object sender, EventArgs e)
        {
            var form = _medicineManagerController.GetFormInstance<MedicineHelpForm>();
            _medicineManagerController.OpenChildForm(form);
            containerPanel.Controls.Add(form);
            containerPanel.Tag = form;
            //Shared.OpenChildForm(Shared.MedicineHelpForm);
            //containerPanel.Controls.Add(Shared.MedicineHelpForm);
            //containerPanel.Tag = Shared.MedicineHelpForm;
            hideSubMenu();
        }

        private void helpPharmaciesButton_Click(object sender, EventArgs e)
        {
            var form = _medicineManagerController.GetFormInstance<PharmaciesHelpForm>();
            _medicineManagerController.OpenChildForm(form);
            containerPanel.Controls.Add(form);
            containerPanel.Tag = form;
            //Shared.OpenChildForm(Shared.PharmaciesHelpForm);
            //containerPanel.Controls.Add(Shared.PharmaciesHelpForm);
            //containerPanel.Tag = Shared.PharmaciesHelpForm;
            hideSubMenu();
        }

        private void helpPillListButton_Click(object sender, EventArgs e)
        {
            var form = _medicineManagerController.GetFormInstance<MyHealthHelpForm>();
            _medicineManagerController.OpenChildForm(form);
            containerPanel.Controls.Add(form);
            containerPanel.Tag = form;
            //Shared.OpenChildForm(Shared.MyHealthHelpForm);
            //containerPanel.Controls.Add(Shared.MyHealthHelpForm);
            //containerPanel.Tag = Shared.MyHealthHelpForm;
            hideSubMenu();
        }
        #endregion

        private void openChildForm(dynamic form)
        {
            // TODO multitype variable handler (stackowerflow/questions/22417222)
            if (activeForm != null)
            {
                activeForm.Close();
            }
            if (form.GetType() == typeof(PharmaciesLocationForm)) form.FormStyle = MaterialForm.FormStyles.StatusAndActionBar_None;
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.ControlBox = false;
            form.Dock = DockStyle.Fill;

            form.BringToFront();
            form.Show();
        }

        public void StartLoadingAnimation()
        {
            LoadingPanel = new SearchLoadingPanel();
            LoadingPanel.Location = new Point(60, 60);
            LoadingPanel.Show();
            LoadingPanel.BringToFront();
            containerPanel.Controls.Add(LoadingPanel);
            //loadingBar.Style = ProgressBarStyle.Marquee;
            isLoading = true;
            //loadingPanel.BringToFront();
            //loadingLabel.BringToFront();
            //loadingBar.BringToFront();
            //loadingPanel.Visible = true;
            //loadingTimer.Start();
        }

        public void StopLoadingAnimation()
        {
            LoadingPanel.Hide();
            containerPanel.Controls.Remove(LoadingPanel);
            isLoading = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pillsListButton_Click(object sender, EventArgs e)
        {
            var form = _medicineManagerController.GetFormInstance<MyHealthForm>();
            form.list = _medicineManagerController.MedicineModel.PillList;
            form.CreateDynamicTableLayout();
            _medicineManagerController.OpenChildForm(form);
            _medicineManagerController.SetPostOpenChildProperties(form);

            //Shared.MyHealthForm.list = Shared.PillList;
            //Shared.MyHealthForm.CreateDynamicTableLayout();
            //Shared.OpenChildForm(Shared.MyHealthForm);
            //containerPanel.Controls.Add(Shared.MyHealthForm);
            //containerPanel.Tag = Shared.MyHealthForm;
        }

        private void czechLanguageButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("cs-CS");
            _medicineManagerController.ChangeLanguageInitialization();
            containerPanel.Controls.Clear();
            this.Controls.Clear();
            this.InitializeComponent();
            var form = _medicineManagerController.GetFormInstance<SearchPillsForm>();
            _medicineManagerController.OpenChildForm(form);
            containerPanel.Controls.Add(form);
            containerPanel.Tag = form;
            //TODO
        }

        private void slovakLanguageButton_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("sk-SK");
            _medicineManagerController.ChangeLanguageInitialization();
            containerPanel.Controls.Clear();
            this.Controls.Clear();
            this.InitializeComponent();
            var form = _medicineManagerController.GetFormInstance<SearchPillsForm>();
            _medicineManagerController.OpenChildForm(form);
            containerPanel.Controls.Add(form);
            containerPanel.Tag = form;
        }
    }
}
