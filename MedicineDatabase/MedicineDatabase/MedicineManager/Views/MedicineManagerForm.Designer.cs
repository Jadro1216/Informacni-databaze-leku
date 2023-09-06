namespace MedicineDatabase.MedicineManager.Views
{
    partial class MedicineManagerForm
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineManagerForm));
            sideMenuPanel = new Panel();
            panel1 = new Panel();
            slovakLanguageButton = new Button();
            czechLanguageButton = new Button();
            exitButton = new Button();
            helpSubMenuPanel = new Panel();
            helpPillListButton = new Button();
            helpPharmaciesButton = new Button();
            helpPillsButton = new Button();
            helpButton = new Button();
            pillsListButton = new Button();
            pharmaciesSubMenuPanel = new Panel();
            pharmaciesListButton = new Button();
            pharmaciesLocationButton = new Button();
            pharmaciesButton = new Button();
            pillsSubMenuPanel = new Panel();
            detailPillButton = new Button();
            searchPillsButton = new Button();
            pillsButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            findPharmaciesButton = new MaterialSkin.Controls.MaterialButton();
            getLocationButton = new MaterialSkin.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            containerPanel = new Panel();
            sideMenuPanel.SuspendLayout();
            panel1.SuspendLayout();
            helpSubMenuPanel.SuspendLayout();
            pharmaciesSubMenuPanel.SuspendLayout();
            pillsSubMenuPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // sideMenuPanel
            // 
            resources.ApplyResources(sideMenuPanel, "sideMenuPanel");
            sideMenuPanel.BackColor = Color.FromArgb(33, 150, 243);
            sideMenuPanel.Controls.Add(panel1);
            sideMenuPanel.Controls.Add(exitButton);
            sideMenuPanel.Controls.Add(helpSubMenuPanel);
            sideMenuPanel.Controls.Add(helpButton);
            sideMenuPanel.Controls.Add(pillsListButton);
            sideMenuPanel.Controls.Add(pharmaciesSubMenuPanel);
            sideMenuPanel.Controls.Add(pharmaciesButton);
            sideMenuPanel.Controls.Add(pillsSubMenuPanel);
            sideMenuPanel.Controls.Add(pillsButton);
            sideMenuPanel.Name = "sideMenuPanel";
            // 
            // panel1
            // 
            panel1.Controls.Add(slovakLanguageButton);
            panel1.Controls.Add(czechLanguageButton);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // slovakLanguageButton
            // 
            slovakLanguageButton.Cursor = Cursors.Hand;
            resources.ApplyResources(slovakLanguageButton, "slovakLanguageButton");
            slovakLanguageButton.ForeColor = Color.Transparent;
            slovakLanguageButton.Image = Properties.Resources.slovak;
            slovakLanguageButton.Name = "slovakLanguageButton";
            slovakLanguageButton.UseVisualStyleBackColor = true;
            slovakLanguageButton.Click += slovakLanguageButton_Click;
            // 
            // czechLanguageButton
            // 
            czechLanguageButton.Cursor = Cursors.Hand;
            resources.ApplyResources(czechLanguageButton, "czechLanguageButton");
            czechLanguageButton.ForeColor = Color.Transparent;
            czechLanguageButton.Image = Properties.Resources.czech;
            czechLanguageButton.Name = "czechLanguageButton";
            czechLanguageButton.UseVisualStyleBackColor = true;
            czechLanguageButton.Click += czechLanguageButton_Click;
            // 
            // exitButton
            // 
            exitButton.Cursor = Cursors.Hand;
            resources.ApplyResources(exitButton, "exitButton");
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.ForeColor = Color.White;
            exitButton.Image = Properties.Resources.whiteExit;
            exitButton.Name = "exitButton";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // helpSubMenuPanel
            // 
            resources.ApplyResources(helpSubMenuPanel, "helpSubMenuPanel");
            helpSubMenuPanel.BackColor = Color.FromArgb(129, 212, 250);
            helpSubMenuPanel.Controls.Add(helpPillListButton);
            helpSubMenuPanel.Controls.Add(helpPharmaciesButton);
            helpSubMenuPanel.Controls.Add(helpPillsButton);
            helpSubMenuPanel.Name = "helpSubMenuPanel";
            // 
            // helpPillListButton
            // 
            helpPillListButton.Cursor = Cursors.Hand;
            resources.ApplyResources(helpPillListButton, "helpPillListButton");
            helpPillListButton.FlatAppearance.BorderSize = 0;
            helpPillListButton.ForeColor = Color.White;
            helpPillListButton.Image = Properties.Resources.whitePillsList;
            helpPillListButton.Name = "helpPillListButton";
            helpPillListButton.UseVisualStyleBackColor = true;
            helpPillListButton.Click += helpPillListButton_Click;
            // 
            // helpPharmaciesButton
            // 
            helpPharmaciesButton.Cursor = Cursors.Hand;
            resources.ApplyResources(helpPharmaciesButton, "helpPharmaciesButton");
            helpPharmaciesButton.FlatAppearance.BorderSize = 0;
            helpPharmaciesButton.ForeColor = Color.White;
            helpPharmaciesButton.Image = Properties.Resources.whitePharmacy;
            helpPharmaciesButton.Name = "helpPharmaciesButton";
            helpPharmaciesButton.UseVisualStyleBackColor = true;
            helpPharmaciesButton.Click += helpPharmaciesButton_Click;
            // 
            // helpPillsButton
            // 
            helpPillsButton.Cursor = Cursors.Hand;
            resources.ApplyResources(helpPillsButton, "helpPillsButton");
            helpPillsButton.FlatAppearance.BorderSize = 0;
            helpPillsButton.ForeColor = Color.White;
            helpPillsButton.Image = Properties.Resources.pills_white;
            helpPillsButton.Name = "helpPillsButton";
            helpPillsButton.UseVisualStyleBackColor = true;
            helpPillsButton.Click += helpPillsButton_Click;
            // 
            // helpButton
            // 
            helpButton.Cursor = Cursors.Hand;
            resources.ApplyResources(helpButton, "helpButton");
            helpButton.FlatAppearance.BorderSize = 0;
            helpButton.ForeColor = Color.White;
            helpButton.Image = Properties.Resources.whiteHelp;
            helpButton.Name = "helpButton";
            helpButton.UseVisualStyleBackColor = false;
            helpButton.Click += helpButton_Click;
            // 
            // pillsListButton
            // 
            pillsListButton.Cursor = Cursors.Hand;
            resources.ApplyResources(pillsListButton, "pillsListButton");
            pillsListButton.FlatAppearance.BorderSize = 0;
            pillsListButton.ForeColor = Color.White;
            pillsListButton.Image = Properties.Resources.whitePillsList;
            pillsListButton.Name = "pillsListButton";
            pillsListButton.UseVisualStyleBackColor = false;
            pillsListButton.Click += pillsListButton_Click;
            // 
            // pharmaciesSubMenuPanel
            // 
            resources.ApplyResources(pharmaciesSubMenuPanel, "pharmaciesSubMenuPanel");
            pharmaciesSubMenuPanel.BackColor = Color.FromArgb(129, 212, 250);
            pharmaciesSubMenuPanel.Controls.Add(pharmaciesListButton);
            pharmaciesSubMenuPanel.Controls.Add(pharmaciesLocationButton);
            pharmaciesSubMenuPanel.Name = "pharmaciesSubMenuPanel";
            // 
            // pharmaciesListButton
            // 
            pharmaciesListButton.Cursor = Cursors.Hand;
            resources.ApplyResources(pharmaciesListButton, "pharmaciesListButton");
            pharmaciesListButton.FlatAppearance.BorderSize = 0;
            pharmaciesListButton.ForeColor = Color.White;
            pharmaciesListButton.Image = Properties.Resources.whiteList;
            pharmaciesListButton.Name = "pharmaciesListButton";
            pharmaciesListButton.UseVisualStyleBackColor = true;
            pharmaciesListButton.Click += pharmaciesListButton_Click;
            // 
            // pharmaciesLocationButton
            // 
            pharmaciesLocationButton.Cursor = Cursors.Hand;
            resources.ApplyResources(pharmaciesLocationButton, "pharmaciesLocationButton");
            pharmaciesLocationButton.FlatAppearance.BorderSize = 0;
            pharmaciesLocationButton.ForeColor = Color.White;
            pharmaciesLocationButton.Image = Properties.Resources.whiteLocation;
            pharmaciesLocationButton.Name = "pharmaciesLocationButton";
            pharmaciesLocationButton.UseVisualStyleBackColor = true;
            pharmaciesLocationButton.Click += pharmaciesLocationButton_Click;
            // 
            // pharmaciesButton
            // 
            pharmaciesButton.Cursor = Cursors.Hand;
            resources.ApplyResources(pharmaciesButton, "pharmaciesButton");
            pharmaciesButton.FlatAppearance.BorderSize = 0;
            pharmaciesButton.ForeColor = Color.White;
            pharmaciesButton.Image = Properties.Resources.whitePharmacy;
            pharmaciesButton.Name = "pharmaciesButton";
            pharmaciesButton.UseVisualStyleBackColor = false;
            pharmaciesButton.Click += pharmaciesButton_Click;
            // 
            // pillsSubMenuPanel
            // 
            resources.ApplyResources(pillsSubMenuPanel, "pillsSubMenuPanel");
            pillsSubMenuPanel.BackColor = Color.FromArgb(129, 212, 250);
            pillsSubMenuPanel.Controls.Add(detailPillButton);
            pillsSubMenuPanel.Controls.Add(searchPillsButton);
            pillsSubMenuPanel.Name = "pillsSubMenuPanel";
            // 
            // detailPillButton
            // 
            detailPillButton.Cursor = Cursors.Hand;
            resources.ApplyResources(detailPillButton, "detailPillButton");
            detailPillButton.FlatAppearance.BorderSize = 0;
            detailPillButton.ForeColor = Color.White;
            detailPillButton.Image = Properties.Resources.whiteDetail;
            detailPillButton.Name = "detailPillButton";
            detailPillButton.UseVisualStyleBackColor = true;
            detailPillButton.Click += detailPillButton_Click;
            // 
            // searchPillsButton
            // 
            searchPillsButton.Cursor = Cursors.Hand;
            resources.ApplyResources(searchPillsButton, "searchPillsButton");
            searchPillsButton.FlatAppearance.BorderSize = 0;
            searchPillsButton.ForeColor = Color.White;
            searchPillsButton.Image = Properties.Resources.whiteSearch;
            searchPillsButton.Name = "searchPillsButton";
            searchPillsButton.UseVisualStyleBackColor = true;
            searchPillsButton.Click += searchPillsButton_Click;
            // 
            // pillsButton
            // 
            pillsButton.BackColor = Color.FromArgb(33, 150, 243);
            pillsButton.Cursor = Cursors.Hand;
            resources.ApplyResources(pillsButton, "pillsButton");
            pillsButton.FlatAppearance.BorderSize = 0;
            pillsButton.ForeColor = Color.White;
            pillsButton.Image = Properties.Resources.pills_white;
            pillsButton.Name = "pillsButton";
            pillsButton.UseVisualStyleBackColor = false;
            pillsButton.Click += pillsButton_Click;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(findPharmaciesButton, 2, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // findPharmaciesButton
            // 
            resources.ApplyResources(findPharmaciesButton, "findPharmaciesButton");
            findPharmaciesButton.BackColor = Color.Silver;
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
            // 
            // getLocationButton
            // 
            resources.ApplyResources(getLocationButton, "getLocationButton");
            getLocationButton.BackColor = Color.Silver;
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
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "information.png");
            imageList1.Images.SetKeyName(1, "pharmacy.png");
            imageList1.Images.SetKeyName(2, "location.png");
            imageList1.Images.SetKeyName(3, "pills.png");
            imageList1.Images.SetKeyName(4, "bulletList.png");
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(materialButton1, 2, 10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // materialButton1
            // 
            resources.ApplyResources(materialButton1, "materialButton1");
            materialButton1.BackColor = Color.Silver;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = false;
            // 
            // materialButton2
            // 
            resources.ApplyResources(materialButton2, "materialButton2");
            materialButton2.BackColor = Color.Silver;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = false;
            // 
            // containerPanel
            // 
            containerPanel.BackColor = Color.White;
            resources.ApplyResources(containerPanel, "containerPanel");
            containerPanel.Name = "containerPanel";
            // 
            // MedicineManagerForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(containerPanel);
            Controls.Add(sideMenuPanel);
            HelpButton = true;
            Name = "MedicineManagerForm";
            WindowState = FormWindowState.Maximized;
            sideMenuPanel.ResumeLayout(false);
            sideMenuPanel.PerformLayout();
            panel1.ResumeLayout(false);
            helpSubMenuPanel.ResumeLayout(false);
            pharmaciesSubMenuPanel.ResumeLayout(false);
            pillsSubMenuPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideMenuPanel;
        private Button pillsButton;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton findPharmaciesButton;
        private MaterialSkin.Controls.MaterialButton getLocationButton;
        private ImageList imageList1;
        private Panel pillsSubMenuPanel;
        private Button searchPillsButton;
        private Panel pharmaciesSubMenuPanel;
        private Button pharmaciesListButton;
        private Button pharmaciesLocationButton;
        private Button pharmaciesButton;
        private Button detailPillButton;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        public Panel containerPanel;
        private Button pillsListButton;
        private Button exitButton;
        private Panel helpSubMenuPanel;
        private Button helpPharmaciesButton;
        private Button helpPillsButton;
        private Button helpButton;
        private Button helpPillListButton;
        private Panel panel1;
        private Button czechLanguageButton;
        private Button slovakLanguageButton;
    }
}