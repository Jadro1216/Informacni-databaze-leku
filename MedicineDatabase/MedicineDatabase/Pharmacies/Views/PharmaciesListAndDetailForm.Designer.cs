namespace MedicineDatabase.Pharmacies.Views
{
    partial class PharmaciesListAndDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmaciesListAndDetailForm));
            tableLayoutPanel2 = new TableLayoutPanel();
            gmapPharmacies = new GMap.NET.WindowsForms.GMapControl();
            tableLayoutPanel3 = new TableLayoutPanel();
            pharmacyWebLabel = new Label();
            pharmacyNameLabel = new Label();
            addressPharmacyLabel = new Label();
            distancePharmacyLabel = new Label();
            webListBox = new MaterialSkin.Controls.MaterialListBox();
            pharmacyHoursLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            mondayLabel = new Label();
            tuesdayLabel = new Label();
            wednesdayLabel = new Label();
            thursdayLabel = new Label();
            fridayLabel = new Label();
            saturdayLabel = new Label();
            sundayLabel = new Label();
            holidayLabel = new Label();
            emailPharmacyLabel = new Label();
            emailListBox = new MaterialSkin.Controls.MaterialListBox();
            phoneListBox = new MaterialSkin.Controls.MaterialListBox();
            phonePharmacyLabel = new Label();
            pharmacyListHelpButton = new MaterialSkin.Controls.MaterialButton();
            routeButton = new MaterialSkin.Controls.MaterialButton();
            pharmaciesList = new FlowLayoutPanel();
            goBackButton = new MaterialSkin.Controls.MaterialButton();
            hoursTooltip = new ToolTip(components);
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.Controls.Add(gmapPharmacies, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(pharmaciesList, 1, 2);
            tableLayoutPanel2.Controls.Add(goBackButton, 0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            hoursTooltip.SetToolTip(tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            // 
            // gmapPharmacies
            // 
            resources.ApplyResources(gmapPharmacies, "gmapPharmacies");
            gmapPharmacies.Bearing = 0F;
            gmapPharmacies.CanDragMap = true;
            gmapPharmacies.EmptyTileColor = Color.Navy;
            gmapPharmacies.GrayScaleMode = false;
            gmapPharmacies.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gmapPharmacies.LevelsKeepInMemory = 5;
            gmapPharmacies.MarkersEnabled = true;
            gmapPharmacies.MaxZoom = 20;
            gmapPharmacies.MinZoom = 0;
            gmapPharmacies.MouseWheelZoomEnabled = true;
            gmapPharmacies.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gmapPharmacies.Name = "gmapPharmacies";
            gmapPharmacies.NegativeMode = false;
            gmapPharmacies.PolygonsEnabled = true;
            gmapPharmacies.RetryLoadTile = 0;
            gmapPharmacies.RoutesEnabled = true;
            tableLayoutPanel2.SetRowSpan(gmapPharmacies, 2);
            gmapPharmacies.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gmapPharmacies.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gmapPharmacies.ShowTileGridLines = false;
            hoursTooltip.SetToolTip(gmapPharmacies, resources.GetString("gmapPharmacies.ToolTip"));
            gmapPharmacies.Zoom = 14D;
            gmapPharmacies.Load += gmapPharmacies_Load;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(pharmacyWebLabel, 0, 6);
            tableLayoutPanel3.Controls.Add(pharmacyNameLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(addressPharmacyLabel, 0, 2);
            tableLayoutPanel3.Controls.Add(distancePharmacyLabel, 0, 4);
            tableLayoutPanel3.Controls.Add(webListBox, 0, 7);
            tableLayoutPanel3.Controls.Add(pharmacyHoursLabel, 2, 6);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 2, 7);
            tableLayoutPanel3.Controls.Add(emailPharmacyLabel, 2, 4);
            tableLayoutPanel3.Controls.Add(emailListBox, 3, 4);
            tableLayoutPanel3.Controls.Add(phoneListBox, 3, 2);
            tableLayoutPanel3.Controls.Add(phonePharmacyLabel, 2, 2);
            tableLayoutPanel3.Controls.Add(pharmacyListHelpButton, 3, 0);
            tableLayoutPanel3.Controls.Add(routeButton, 2, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel2.SetRowSpan(tableLayoutPanel3, 2);
            hoursTooltip.SetToolTip(tableLayoutPanel3, resources.GetString("tableLayoutPanel3.ToolTip"));
            // 
            // pharmacyWebLabel
            // 
            resources.ApplyResources(pharmacyWebLabel, "pharmacyWebLabel");
            tableLayoutPanel3.SetColumnSpan(pharmacyWebLabel, 2);
            pharmacyWebLabel.Name = "pharmacyWebLabel";
            hoursTooltip.SetToolTip(pharmacyWebLabel, resources.GetString("pharmacyWebLabel.ToolTip"));
            pharmacyWebLabel.SizeChanged += mediumLabel_SizeChanged;
            // 
            // pharmacyNameLabel
            // 
            resources.ApplyResources(pharmacyNameLabel, "pharmacyNameLabel");
            tableLayoutPanel3.SetColumnSpan(pharmacyNameLabel, 2);
            pharmacyNameLabel.Name = "pharmacyNameLabel";
            tableLayoutPanel3.SetRowSpan(pharmacyNameLabel, 2);
            hoursTooltip.SetToolTip(pharmacyNameLabel, resources.GetString("pharmacyNameLabel.ToolTip"));
            pharmacyNameLabel.SizeChanged += pharmacyNameLabel_SizeChanged;
            // 
            // addressPharmacyLabel
            // 
            resources.ApplyResources(addressPharmacyLabel, "addressPharmacyLabel");
            tableLayoutPanel3.SetColumnSpan(addressPharmacyLabel, 2);
            addressPharmacyLabel.Name = "addressPharmacyLabel";
            tableLayoutPanel3.SetRowSpan(addressPharmacyLabel, 2);
            hoursTooltip.SetToolTip(addressPharmacyLabel, resources.GetString("addressPharmacyLabel.ToolTip"));
            addressPharmacyLabel.SizeChanged += largeLabel_SizeChanged;
            // 
            // distancePharmacyLabel
            // 
            resources.ApplyResources(distancePharmacyLabel, "distancePharmacyLabel");
            tableLayoutPanel3.SetColumnSpan(distancePharmacyLabel, 2);
            distancePharmacyLabel.Name = "distancePharmacyLabel";
            tableLayoutPanel3.SetRowSpan(distancePharmacyLabel, 2);
            hoursTooltip.SetToolTip(distancePharmacyLabel, resources.GetString("distancePharmacyLabel.ToolTip"));
            distancePharmacyLabel.SizeChanged += largeLabel_SizeChanged;
            // 
            // webListBox
            // 
            resources.ApplyResources(webListBox, "webListBox");
            webListBox.BackColor = Color.White;
            webListBox.BorderColor = Color.LightGray;
            tableLayoutPanel3.SetColumnSpan(webListBox, 2);
            webListBox.Depth = 0;
            webListBox.MouseState = MaterialSkin.MouseState.HOVER;
            webListBox.Name = "webListBox";
            webListBox.SelectedIndex = -1;
            webListBox.SelectedItem = null;
            hoursTooltip.SetToolTip(webListBox, resources.GetString("webListBox.ToolTip"));
            webListBox.SelectedIndexChanged += webListBox_SelectedIndexChanged;
            // 
            // pharmacyHoursLabel
            // 
            resources.ApplyResources(pharmacyHoursLabel, "pharmacyHoursLabel");
            tableLayoutPanel3.SetColumnSpan(pharmacyHoursLabel, 2);
            pharmacyHoursLabel.Name = "pharmacyHoursLabel";
            hoursTooltip.SetToolTip(pharmacyHoursLabel, resources.GetString("pharmacyHoursLabel.ToolTip"));
            pharmacyHoursLabel.SizeChanged += mediumLabel_SizeChanged;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(tableLayoutPanel4, "tableLayoutPanel4");
            tableLayoutPanel3.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.Controls.Add(mondayLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(tuesdayLabel, 0, 1);
            tableLayoutPanel4.Controls.Add(wednesdayLabel, 0, 2);
            tableLayoutPanel4.Controls.Add(thursdayLabel, 0, 3);
            tableLayoutPanel4.Controls.Add(fridayLabel, 1, 0);
            tableLayoutPanel4.Controls.Add(saturdayLabel, 1, 1);
            tableLayoutPanel4.Controls.Add(sundayLabel, 1, 2);
            tableLayoutPanel4.Controls.Add(holidayLabel, 1, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            hoursTooltip.SetToolTip(tableLayoutPanel4, resources.GetString("tableLayoutPanel4.ToolTip"));
            // 
            // mondayLabel
            // 
            resources.ApplyResources(mondayLabel, "mondayLabel");
            mondayLabel.Name = "mondayLabel";
            hoursTooltip.SetToolTip(mondayLabel, resources.GetString("mondayLabel.ToolTip"));
            mondayLabel.SizeChanged += openHoursLabel_SizeChanged;
            // 
            // tuesdayLabel
            // 
            resources.ApplyResources(tuesdayLabel, "tuesdayLabel");
            tuesdayLabel.Name = "tuesdayLabel";
            hoursTooltip.SetToolTip(tuesdayLabel, resources.GetString("tuesdayLabel.ToolTip"));
            tuesdayLabel.SizeChanged += openHoursLabel_SizeChanged;
            // 
            // wednesdayLabel
            // 
            resources.ApplyResources(wednesdayLabel, "wednesdayLabel");
            wednesdayLabel.Name = "wednesdayLabel";
            hoursTooltip.SetToolTip(wednesdayLabel, resources.GetString("wednesdayLabel.ToolTip"));
            wednesdayLabel.SizeChanged += openHoursLabel_SizeChanged;
            // 
            // thursdayLabel
            // 
            resources.ApplyResources(thursdayLabel, "thursdayLabel");
            thursdayLabel.Name = "thursdayLabel";
            hoursTooltip.SetToolTip(thursdayLabel, resources.GetString("thursdayLabel.ToolTip"));
            thursdayLabel.SizeChanged += openHoursLabel_SizeChanged;
            // 
            // fridayLabel
            // 
            resources.ApplyResources(fridayLabel, "fridayLabel");
            fridayLabel.Name = "fridayLabel";
            hoursTooltip.SetToolTip(fridayLabel, resources.GetString("fridayLabel.ToolTip"));
            fridayLabel.SizeChanged += openHoursLabel_SizeChanged;
            // 
            // saturdayLabel
            // 
            resources.ApplyResources(saturdayLabel, "saturdayLabel");
            saturdayLabel.Name = "saturdayLabel";
            hoursTooltip.SetToolTip(saturdayLabel, resources.GetString("saturdayLabel.ToolTip"));
            saturdayLabel.SizeChanged += openHoursLabel_SizeChanged;
            // 
            // sundayLabel
            // 
            resources.ApplyResources(sundayLabel, "sundayLabel");
            sundayLabel.Name = "sundayLabel";
            hoursTooltip.SetToolTip(sundayLabel, resources.GetString("sundayLabel.ToolTip"));
            sundayLabel.SizeChanged += openHoursLabel_SizeChanged;
            // 
            // holidayLabel
            // 
            resources.ApplyResources(holidayLabel, "holidayLabel");
            holidayLabel.Name = "holidayLabel";
            hoursTooltip.SetToolTip(holidayLabel, resources.GetString("holidayLabel.ToolTip"));
            holidayLabel.SizeChanged += openHoursLabel_SizeChanged;
            // 
            // emailPharmacyLabel
            // 
            resources.ApplyResources(emailPharmacyLabel, "emailPharmacyLabel");
            emailPharmacyLabel.Name = "emailPharmacyLabel";
            tableLayoutPanel3.SetRowSpan(emailPharmacyLabel, 2);
            hoursTooltip.SetToolTip(emailPharmacyLabel, resources.GetString("emailPharmacyLabel.ToolTip"));
            emailPharmacyLabel.SizeChanged += smallLabel_SizeChanged;
            // 
            // emailListBox
            // 
            resources.ApplyResources(emailListBox, "emailListBox");
            emailListBox.BackColor = Color.White;
            emailListBox.BorderColor = Color.LightGray;
            emailListBox.Depth = 0;
            emailListBox.MouseState = MaterialSkin.MouseState.HOVER;
            emailListBox.Name = "emailListBox";
            tableLayoutPanel3.SetRowSpan(emailListBox, 2);
            emailListBox.SelectedIndex = -1;
            emailListBox.SelectedItem = null;
            hoursTooltip.SetToolTip(emailListBox, resources.GetString("emailListBox.ToolTip"));
            // 
            // phoneListBox
            // 
            resources.ApplyResources(phoneListBox, "phoneListBox");
            phoneListBox.BackColor = Color.White;
            phoneListBox.BorderColor = Color.LightGray;
            phoneListBox.Depth = 0;
            phoneListBox.MouseState = MaterialSkin.MouseState.HOVER;
            phoneListBox.Name = "phoneListBox";
            tableLayoutPanel3.SetRowSpan(phoneListBox, 2);
            phoneListBox.SelectedIndex = -1;
            phoneListBox.SelectedItem = null;
            hoursTooltip.SetToolTip(phoneListBox, resources.GetString("phoneListBox.ToolTip"));
            // 
            // phonePharmacyLabel
            // 
            resources.ApplyResources(phonePharmacyLabel, "phonePharmacyLabel");
            phonePharmacyLabel.Name = "phonePharmacyLabel";
            tableLayoutPanel3.SetRowSpan(phonePharmacyLabel, 2);
            hoursTooltip.SetToolTip(phonePharmacyLabel, resources.GetString("phonePharmacyLabel.ToolTip"));
            phonePharmacyLabel.SizeChanged += smallLabel_SizeChanged;
            // 
            // pharmacyListHelpButton
            // 
            resources.ApplyResources(pharmacyListHelpButton, "pharmacyListHelpButton");
            pharmacyListHelpButton.Cursor = Cursors.Hand;
            pharmacyListHelpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            pharmacyListHelpButton.Depth = 0;
            pharmacyListHelpButton.HighEmphasis = true;
            pharmacyListHelpButton.Icon = null;
            pharmacyListHelpButton.MouseState = MaterialSkin.MouseState.HOVER;
            pharmacyListHelpButton.Name = "pharmacyListHelpButton";
            pharmacyListHelpButton.NoAccentTextColor = Color.Empty;
            tableLayoutPanel3.SetRowSpan(pharmacyListHelpButton, 2);
            hoursTooltip.SetToolTip(pharmacyListHelpButton, resources.GetString("pharmacyListHelpButton.ToolTip"));
            pharmacyListHelpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            pharmacyListHelpButton.UseAccentColor = false;
            pharmacyListHelpButton.UseVisualStyleBackColor = true;
            pharmacyListHelpButton.Click += pharmacyListHelpButton_Click;
            // 
            // routeButton
            // 
            resources.ApplyResources(routeButton, "routeButton");
            routeButton.Cursor = Cursors.Hand;
            routeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            routeButton.Depth = 0;
            routeButton.HighEmphasis = true;
            routeButton.Icon = null;
            routeButton.MouseState = MaterialSkin.MouseState.HOVER;
            routeButton.Name = "routeButton";
            routeButton.NoAccentTextColor = Color.Empty;
            tableLayoutPanel3.SetRowSpan(routeButton, 2);
            hoursTooltip.SetToolTip(routeButton, resources.GetString("routeButton.ToolTip"));
            routeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            routeButton.UseAccentColor = false;
            routeButton.UseVisualStyleBackColor = true;
            routeButton.Click += routeButton_Click;
            // 
            // pharmaciesList
            // 
            resources.ApplyResources(pharmaciesList, "pharmaciesList");
            pharmaciesList.BackColor = Color.White;
            pharmaciesList.Name = "pharmaciesList";
            hoursTooltip.SetToolTip(pharmaciesList, resources.GetString("pharmaciesList.ToolTip"));
            pharmaciesList.SizeChanged += pharmaciesList_SizeChanged;
            // 
            // goBackButton
            // 
            resources.ApplyResources(goBackButton, "goBackButton");
            goBackButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            goBackButton.Depth = 0;
            goBackButton.HighEmphasis = true;
            goBackButton.Icon = Properties.Resources.whiteBackArrow;
            goBackButton.Image = Properties.Resources.whiteBackArrow;
            goBackButton.MouseState = MaterialSkin.MouseState.HOVER;
            goBackButton.Name = "goBackButton";
            goBackButton.NoAccentTextColor = Color.Empty;
            hoursTooltip.SetToolTip(goBackButton, resources.GetString("goBackButton.ToolTip"));
            goBackButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            goBackButton.UseAccentColor = false;
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // PharmaciesListAndDetailForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel2);
            Name = "PharmaciesListAndDetailForm";
            hoursTooltip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            Load += PharmaciesListAndDetail_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        public GMap.NET.WindowsForms.GMapControl gmapPharmacies;
        private TableLayoutPanel tableLayoutPanel3;
        private Label pharmacyWebLabel;
        private Label pharmacyNameLabel;
        private Label addressPharmacyLabel;
        private Label distancePharmacyLabel;
        private MaterialSkin.Controls.MaterialListBox webListBox;
        private Label pharmacyHoursLabel;
        private TableLayoutPanel tableLayoutPanel4;
        private Label mondayLabel;
        private Label tuesdayLabel;
        private Label wednesdayLabel;
        private Label thursdayLabel;
        private Label fridayLabel;
        private Label saturdayLabel;
        private Label sundayLabel;
        private Label holidayLabel;
        private Label emailPharmacyLabel;
        private MaterialSkin.Controls.MaterialListBox emailListBox;
        private MaterialSkin.Controls.MaterialListBox phoneListBox;
        private Label phonePharmacyLabel;
        private MaterialSkin.Controls.MaterialButton pharmacyListHelpButton;
        private MaterialSkin.Controls.MaterialButton routeButton;
        public FlowLayoutPanel pharmaciesList;
        private ToolTip hoursTooltip;
        private MaterialSkin.Controls.MaterialButton goBackButton;
    }
}