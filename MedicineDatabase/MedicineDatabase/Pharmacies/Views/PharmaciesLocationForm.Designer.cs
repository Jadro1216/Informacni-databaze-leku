namespace MedicineDatabase.Pharmacies.Views
{
    partial class PharmaciesLocationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmaciesLocationForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            findPharmaciesButton = new MaterialSkin.Controls.MaterialButton();
            getLocationButton = new MaterialSkin.Controls.MaterialButton();
            firstTabHelp = new MaterialSkin.Controls.MaterialButton();
            postalCodeText = new MaterialSkin.Controls.MaterialTextBox();
            cityText = new MaterialSkin.Controls.MaterialTextBox();
            streetText = new MaterialSkin.Controls.MaterialTextBox();
            locationTitle = new MaterialSkin.Controls.MaterialLabel();
            postalCodeLabel = new MaterialSkin.Controls.MaterialLabel();
            cityLabel = new MaterialSkin.Controls.MaterialLabel();
            addressNumberLabel = new MaterialSkin.Controls.MaterialLabel();
            streetLabel = new MaterialSkin.Controls.MaterialLabel();
            gmapLocation = new GMap.NET.WindowsForms.GMapControl();
            addressNumberText = new MaterialSkin.Controls.MaterialTextBox();
            badAddressPanel = new Panel();
            badAddressLabel = new Label();
            badAddressButtonPanel = new Panel();
            closeButton = new MaterialSkin.Controls.MaterialButton();
            loadPharmaciesWorker = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1.SuspendLayout();
            badAddressPanel.SuspendLayout();
            badAddressButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.Controls.Add(findPharmaciesButton, 2, 10);
            tableLayoutPanel1.Controls.Add(getLocationButton, 1, 10);
            tableLayoutPanel1.Controls.Add(firstTabHelp, 1, 11);
            tableLayoutPanel1.Controls.Add(postalCodeText, 1, 9);
            tableLayoutPanel1.Controls.Add(cityText, 1, 7);
            tableLayoutPanel1.Controls.Add(streetText, 1, 3);
            tableLayoutPanel1.Controls.Add(locationTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(postalCodeLabel, 1, 8);
            tableLayoutPanel1.Controls.Add(cityLabel, 1, 6);
            tableLayoutPanel1.Controls.Add(addressNumberLabel, 1, 4);
            tableLayoutPanel1.Controls.Add(streetLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(gmapLocation, 0, 0);
            tableLayoutPanel1.Controls.Add(addressNumberText, 1, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // findPharmaciesButton
            // 
            resources.ApplyResources(findPharmaciesButton, "findPharmaciesButton");
            findPharmaciesButton.BackColor = Color.Silver;
            findPharmaciesButton.Cursor = Cursors.Hand;
            findPharmaciesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            findPharmaciesButton.Depth = 0;
            findPharmaciesButton.HighEmphasis = true;
            findPharmaciesButton.Icon = null;
            findPharmaciesButton.MouseState = MaterialSkin.MouseState.HOVER;
            findPharmaciesButton.Name = "findPharmaciesButton";
            findPharmaciesButton.NoAccentTextColor = Color.Empty;
            findPharmaciesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            findPharmaciesButton.UseAccentColor = false;
            findPharmaciesButton.UseVisualStyleBackColor = false;
            findPharmaciesButton.Click += findPharmaciesButton_Click;
            // 
            // getLocationButton
            // 
            resources.ApplyResources(getLocationButton, "getLocationButton");
            getLocationButton.BackColor = Color.Silver;
            getLocationButton.Cursor = Cursors.Hand;
            getLocationButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            getLocationButton.Depth = 0;
            getLocationButton.HighEmphasis = true;
            getLocationButton.Icon = null;
            getLocationButton.MouseState = MaterialSkin.MouseState.HOVER;
            getLocationButton.Name = "getLocationButton";
            getLocationButton.NoAccentTextColor = Color.Empty;
            getLocationButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            getLocationButton.UseAccentColor = false;
            getLocationButton.UseVisualStyleBackColor = false;
            getLocationButton.Click += getLocationButton_Click;
            // 
            // firstTabHelp
            // 
            resources.ApplyResources(firstTabHelp, "firstTabHelp");
            tableLayoutPanel1.SetColumnSpan(firstTabHelp, 2);
            firstTabHelp.Cursor = Cursors.Hand;
            firstTabHelp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            firstTabHelp.Depth = 0;
            firstTabHelp.HighEmphasis = true;
            firstTabHelp.Icon = null;
            firstTabHelp.MouseState = MaterialSkin.MouseState.HOVER;
            firstTabHelp.Name = "firstTabHelp";
            firstTabHelp.NoAccentTextColor = Color.Empty;
            firstTabHelp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            firstTabHelp.UseAccentColor = false;
            firstTabHelp.UseVisualStyleBackColor = true;
            firstTabHelp.Click += firstTabHelp_Click;
            // 
            // postalCodeText
            // 
            resources.ApplyResources(postalCodeText, "postalCodeText");
            postalCodeText.AnimateReadOnly = false;
            postalCodeText.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(postalCodeText, 2);
            postalCodeText.Depth = 0;
            postalCodeText.LeadingIcon = null;
            postalCodeText.MouseState = MaterialSkin.MouseState.OUT;
            postalCodeText.Name = "postalCodeText";
            postalCodeText.TrailingIcon = null;
            postalCodeText.TextChanged += AddressLabel_TextChanged;
            // 
            // cityText
            // 
            resources.ApplyResources(cityText, "cityText");
            cityText.AnimateReadOnly = false;
            cityText.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(cityText, 2);
            cityText.Depth = 0;
            cityText.LeadingIcon = null;
            cityText.MouseState = MaterialSkin.MouseState.OUT;
            cityText.Name = "cityText";
            cityText.TrailingIcon = null;
            cityText.TextChanged += AddressLabel_TextChanged;
            // 
            // streetText
            // 
            resources.ApplyResources(streetText, "streetText");
            streetText.AnimateReadOnly = false;
            streetText.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(streetText, 2);
            streetText.Depth = 0;
            streetText.LeadingIcon = null;
            streetText.MouseState = MaterialSkin.MouseState.OUT;
            streetText.Name = "streetText";
            streetText.TrailingIcon = null;
            streetText.TextChanged += AddressLabel_TextChanged;
            // 
            // locationTitle
            // 
            resources.ApplyResources(locationTitle, "locationTitle");
            tableLayoutPanel1.SetColumnSpan(locationTitle, 2);
            locationTitle.Depth = 0;
            locationTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            locationTitle.MouseState = MaterialSkin.MouseState.HOVER;
            locationTitle.Name = "locationTitle";
            tableLayoutPanel1.SetRowSpan(locationTitle, 2);
            locationTitle.SizeChanged += locationTitle_SizeChanged;
            // 
            // postalCodeLabel
            // 
            resources.ApplyResources(postalCodeLabel, "postalCodeLabel");
            tableLayoutPanel1.SetColumnSpan(postalCodeLabel, 2);
            postalCodeLabel.Depth = 0;
            postalCodeLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            postalCodeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            postalCodeLabel.Name = "postalCodeLabel";
            // 
            // cityLabel
            // 
            resources.ApplyResources(cityLabel, "cityLabel");
            tableLayoutPanel1.SetColumnSpan(cityLabel, 2);
            cityLabel.Depth = 0;
            cityLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            cityLabel.MouseState = MaterialSkin.MouseState.HOVER;
            cityLabel.Name = "cityLabel";
            // 
            // addressNumberLabel
            // 
            resources.ApplyResources(addressNumberLabel, "addressNumberLabel");
            tableLayoutPanel1.SetColumnSpan(addressNumberLabel, 2);
            addressNumberLabel.Depth = 0;
            addressNumberLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            addressNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
            addressNumberLabel.Name = "addressNumberLabel";
            // 
            // streetLabel
            // 
            resources.ApplyResources(streetLabel, "streetLabel");
            tableLayoutPanel1.SetColumnSpan(streetLabel, 2);
            streetLabel.Depth = 0;
            streetLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            streetLabel.MouseState = MaterialSkin.MouseState.HOVER;
            streetLabel.Name = "streetLabel";
            // 
            // gmapLocation
            // 
            resources.ApplyResources(gmapLocation, "gmapLocation");
            gmapLocation.Bearing = 0F;
            gmapLocation.CanDragMap = true;
            gmapLocation.EmptyTileColor = Color.Navy;
            gmapLocation.GrayScaleMode = false;
            gmapLocation.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gmapLocation.LevelsKeepInMemory = 5;
            gmapLocation.MarkersEnabled = true;
            gmapLocation.MaxZoom = 20;
            gmapLocation.MinZoom = 0;
            gmapLocation.MouseWheelZoomEnabled = true;
            gmapLocation.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gmapLocation.Name = "gmapLocation";
            gmapLocation.NegativeMode = false;
            gmapLocation.PolygonsEnabled = true;
            gmapLocation.RetryLoadTile = 0;
            gmapLocation.RoutesEnabled = true;
            tableLayoutPanel1.SetRowSpan(gmapLocation, 12);
            gmapLocation.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gmapLocation.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gmapLocation.ShowTileGridLines = false;
            gmapLocation.Zoom = 14D;
            gmapLocation.Load += gmapLocation_Load;
            // 
            // addressNumberText
            // 
            resources.ApplyResources(addressNumberText, "addressNumberText");
            addressNumberText.AnimateReadOnly = false;
            addressNumberText.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(addressNumberText, 2);
            addressNumberText.Depth = 0;
            addressNumberText.LeadingIcon = null;
            addressNumberText.MouseState = MaterialSkin.MouseState.OUT;
            addressNumberText.Name = "addressNumberText";
            addressNumberText.TrailingIcon = null;
            addressNumberText.TextChanged += AddressLabel_TextChanged;
            // 
            // badAddressPanel
            // 
            resources.ApplyResources(badAddressPanel, "badAddressPanel");
            badAddressPanel.BackColor = Color.OldLace;
            badAddressPanel.BorderStyle = BorderStyle.FixedSingle;
            badAddressPanel.Controls.Add(badAddressLabel);
            badAddressPanel.Controls.Add(badAddressButtonPanel);
            badAddressPanel.ForeColor = Color.White;
            badAddressPanel.Name = "badAddressPanel";
            // 
            // badAddressLabel
            // 
            resources.ApplyResources(badAddressLabel, "badAddressLabel");
            badAddressLabel.ForeColor = SystemColors.ControlText;
            badAddressLabel.Name = "badAddressLabel";
            badAddressLabel.SizeChanged += badAddressLabel_SizeChanged;
            // 
            // badAddressButtonPanel
            // 
            resources.ApplyResources(badAddressButtonPanel, "badAddressButtonPanel");
            badAddressButtonPanel.BackColor = Color.OldLace;
            badAddressButtonPanel.Controls.Add(closeButton);
            badAddressButtonPanel.Name = "badAddressButtonPanel";
            // 
            // closeButton
            // 
            resources.ApplyResources(closeButton, "closeButton");
            closeButton.BackColor = Color.MistyRose;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            closeButton.Depth = 0;
            closeButton.HighEmphasis = true;
            closeButton.Icon = null;
            closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            closeButton.Name = "closeButton";
            closeButton.NoAccentTextColor = Color.Empty;
            closeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            closeButton.UseAccentColor = false;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // loadPharmaciesWorker
            // 
            loadPharmaciesWorker.WorkerReportsProgress = true;
            loadPharmaciesWorker.DoWork += loadPharmaciesWorker_DoWork;
            loadPharmaciesWorker.ProgressChanged += loadPharmaciesWorker_ProgressChanged;
            loadPharmaciesWorker.RunWorkerCompleted += loadPharmaciesWorker_RunWorkerCompleted;
            // 
            // PharmaciesLocationForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(badAddressPanel);
            Controls.Add(tableLayoutPanel1);
            Name = "PharmaciesLocationForm";
            Load += PharaciesLocationForm_Load;
            Resize += PharaciesLocationForm_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            badAddressPanel.ResumeLayout(false);
            badAddressButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton findPharmaciesButton;
        private MaterialSkin.Controls.MaterialButton getLocationButton;
        private MaterialSkin.Controls.MaterialButton firstTabHelp;
        private MaterialSkin.Controls.MaterialTextBox postalCodeText;
        private MaterialSkin.Controls.MaterialTextBox cityText;
        private MaterialSkin.Controls.MaterialTextBox streetText;
        private MaterialSkin.Controls.MaterialLabel locationTitle;
        private MaterialSkin.Controls.MaterialLabel postalCodeLabel;
        private MaterialSkin.Controls.MaterialLabel cityLabel;
        private MaterialSkin.Controls.MaterialLabel addressNumberLabel;
        private MaterialSkin.Controls.MaterialLabel streetLabel;
        internal GMap.NET.WindowsForms.GMapControl gmapLocation;
        private MaterialSkin.Controls.MaterialTextBox addressNumberText;
        private Panel badAddressPanel;
        private Label badAddressLabel;
        private MaterialSkin.Controls.MaterialButton closeButton;
        private Panel badAddressButtonPanel;
        public System.ComponentModel.BackgroundWorker loadPharmaciesWorker;
    }
}