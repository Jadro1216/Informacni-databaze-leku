namespace MedicineDatabase.MedicineInformation.Views
{
    partial class SearchPillsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPillsForm));
            topPanel = new Panel();
            topTableLayout = new TableLayoutPanel();
            searchLabel = new Label();
            searchTextLabel = new Label();
            searchTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            filterLabel = new Label();
            filterComboBox = new MaterialSkin.Controls.MaterialComboBox();
            searchPillsButton = new MaterialSkin.Controls.MaterialButton();
            searchPillsHelpButton = new MaterialSkin.Controls.MaterialButton();
            healthInformationsLabel = new Label();
            panel1 = new Panel();
            healthInfoButton = new MaterialSkin.Controls.MaterialButton();
            medicineListPanel = new Panel();
            badSearchPanel = new Panel();
            badSearchLabel = new Label();
            badSearchButtonPanel = new Panel();
            closeButton = new MaterialSkin.Controls.MaterialButton();
            noSearchResultsLabel = new Label();
            pillsLayoutPanel = new FlowLayoutPanel();
            loadMedicineWorker = new System.ComponentModel.BackgroundWorker();
            pillListItemToolTip = new ToolTip(components);
            topPanel.SuspendLayout();
            topTableLayout.SuspendLayout();
            panel1.SuspendLayout();
            medicineListPanel.SuspendLayout();
            badSearchPanel.SuspendLayout();
            badSearchButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(topTableLayout);
            resources.ApplyResources(topPanel, "topPanel");
            topPanel.Name = "topPanel";
            // 
            // topTableLayout
            // 
            resources.ApplyResources(topTableLayout, "topTableLayout");
            topTableLayout.Controls.Add(searchLabel, 0, 0);
            topTableLayout.Controls.Add(searchTextLabel, 0, 2);
            topTableLayout.Controls.Add(searchTextBox, 0, 3);
            topTableLayout.Controls.Add(filterLabel, 1, 2);
            topTableLayout.Controls.Add(filterComboBox, 1, 3);
            topTableLayout.Controls.Add(searchPillsButton, 2, 3);
            topTableLayout.Controls.Add(searchPillsHelpButton, 2, 0);
            topTableLayout.Controls.Add(healthInformationsLabel, 0, 1);
            topTableLayout.Controls.Add(panel1, 2, 1);
            topTableLayout.Name = "topTableLayout";
            // 
            // searchLabel
            // 
            resources.ApplyResources(searchLabel, "searchLabel");
            topTableLayout.SetColumnSpan(searchLabel, 2);
            searchLabel.Name = "searchLabel";
            searchLabel.SizeChanged += searchLabel_SizeChanged;
            // 
            // searchTextLabel
            // 
            resources.ApplyResources(searchTextLabel, "searchTextLabel");
            searchTextLabel.Name = "searchTextLabel";
            searchTextLabel.SizeChanged += searchTextLabel_SizeChanged;
            // 
            // searchTextBox
            // 
            searchTextBox.AnimateReadOnly = false;
            resources.ApplyResources(searchTextBox, "searchTextBox");
            searchTextBox.CharacterCasing = CharacterCasing.Normal;
            searchTextBox.Depth = 0;
            searchTextBox.HideSelection = true;
            searchTextBox.LeadingIcon = null;
            searchTextBox.MaxLength = 100;
            searchTextBox.MouseState = MaterialSkin.MouseState.OUT;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.ReadOnly = false;
            searchTextBox.SelectedText = "";
            searchTextBox.SelectionLength = 0;
            searchTextBox.SelectionStart = 0;
            searchTextBox.ShortcutsEnabled = true;
            searchTextBox.TabStop = false;
            searchTextBox.TextAlign = HorizontalAlignment.Left;
            searchTextBox.TrailingIcon = Properties.Resources.search;
            searchTextBox.UseSystemPasswordChar = false;
            // 
            // filterLabel
            // 
            resources.ApplyResources(filterLabel, "filterLabel");
            topTableLayout.SetColumnSpan(filterLabel, 2);
            filterLabel.Name = "filterLabel";
            filterLabel.SizeChanged += filterLabel_SizeChanged;
            // 
            // filterComboBox
            // 
            filterComboBox.AutoResize = false;
            filterComboBox.BackColor = Color.FromArgb(255, 255, 255);
            filterComboBox.Depth = 0;
            resources.ApplyResources(filterComboBox, "filterComboBox");
            filterComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            filterComboBox.DropDownHeight = 432;
            filterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filterComboBox.DropDownWidth = 121;
            filterComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Items.AddRange(new object[] { resources.GetString("filterComboBox.Items"), resources.GetString("filterComboBox.Items1"), resources.GetString("filterComboBox.Items2"), resources.GetString("filterComboBox.Items3"), resources.GetString("filterComboBox.Items4"), resources.GetString("filterComboBox.Items5"), resources.GetString("filterComboBox.Items6") });
            filterComboBox.MouseState = MaterialSkin.MouseState.OUT;
            filterComboBox.Name = "filterComboBox";
            filterComboBox.StartIndex = 0;
            filterComboBox.Tag = "Filters";
            filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
            // 
            // searchPillsButton
            // 
            resources.ApplyResources(searchPillsButton, "searchPillsButton");
            searchPillsButton.Cursor = Cursors.Hand;
            searchPillsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchPillsButton.Depth = 0;
            searchPillsButton.HighEmphasis = true;
            searchPillsButton.Icon = null;
            searchPillsButton.MouseState = MaterialSkin.MouseState.HOVER;
            searchPillsButton.Name = "searchPillsButton";
            searchPillsButton.NoAccentTextColor = Color.Empty;
            searchPillsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            searchPillsButton.UseAccentColor = false;
            searchPillsButton.UseVisualStyleBackColor = true;
            searchPillsButton.Click += searchPillsButton_Click;
            // 
            // searchPillsHelpButton
            // 
            resources.ApplyResources(searchPillsHelpButton, "searchPillsHelpButton");
            searchPillsHelpButton.Cursor = Cursors.Hand;
            searchPillsHelpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchPillsHelpButton.Depth = 0;
            searchPillsHelpButton.HighEmphasis = true;
            searchPillsHelpButton.Icon = null;
            searchPillsHelpButton.MouseState = MaterialSkin.MouseState.HOVER;
            searchPillsHelpButton.Name = "searchPillsHelpButton";
            searchPillsHelpButton.NoAccentTextColor = Color.Empty;
            searchPillsHelpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            searchPillsHelpButton.UseAccentColor = false;
            searchPillsHelpButton.UseVisualStyleBackColor = true;
            searchPillsHelpButton.Click += searchPillsHelpButton_Click;
            // 
            // healthInformationsLabel
            // 
            resources.ApplyResources(healthInformationsLabel, "healthInformationsLabel");
            healthInformationsLabel.BackColor = Color.FromArgb(255, 238, 88);
            topTableLayout.SetColumnSpan(healthInformationsLabel, 2);
            healthInformationsLabel.Image = Properties.Resources.rightArrow;
            healthInformationsLabel.Name = "healthInformationsLabel";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.FromArgb(255, 238, 88);
            panel1.Controls.Add(healthInfoButton);
            panel1.Name = "panel1";
            // 
            // healthInfoButton
            // 
            resources.ApplyResources(healthInfoButton, "healthInfoButton");
            healthInfoButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            healthInfoButton.Depth = 0;
            healthInfoButton.HighEmphasis = true;
            healthInfoButton.Icon = null;
            healthInfoButton.MouseState = MaterialSkin.MouseState.HOVER;
            healthInfoButton.Name = "healthInfoButton";
            healthInfoButton.NoAccentTextColor = Color.Empty;
            healthInfoButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            healthInfoButton.UseAccentColor = false;
            healthInfoButton.UseVisualStyleBackColor = true;
            healthInfoButton.Click += healthInfoButton_Click;
            // 
            // medicineListPanel
            // 
            medicineListPanel.BackColor = Color.White;
            medicineListPanel.Controls.Add(badSearchPanel);
            medicineListPanel.Controls.Add(noSearchResultsLabel);
            medicineListPanel.Controls.Add(pillsLayoutPanel);
            resources.ApplyResources(medicineListPanel, "medicineListPanel");
            medicineListPanel.Name = "medicineListPanel";
            // 
            // badSearchPanel
            // 
            resources.ApplyResources(badSearchPanel, "badSearchPanel");
            badSearchPanel.BackColor = Color.OldLace;
            badSearchPanel.BorderStyle = BorderStyle.FixedSingle;
            badSearchPanel.Controls.Add(badSearchLabel);
            badSearchPanel.Controls.Add(badSearchButtonPanel);
            badSearchPanel.ForeColor = Color.White;
            badSearchPanel.Name = "badSearchPanel";
            // 
            // badSearchLabel
            // 
            resources.ApplyResources(badSearchLabel, "badSearchLabel");
            badSearchLabel.ForeColor = SystemColors.ControlText;
            badSearchLabel.Name = "badSearchLabel";
            badSearchLabel.SizeChanged += badSearchLabel_SizeChanged;
            // 
            // badSearchButtonPanel
            // 
            badSearchButtonPanel.BackColor = Color.OldLace;
            badSearchButtonPanel.Controls.Add(closeButton);
            resources.ApplyResources(badSearchButtonPanel, "badSearchButtonPanel");
            badSearchButtonPanel.Name = "badSearchButtonPanel";
            // 
            // closeButton
            // 
            resources.ApplyResources(closeButton, "closeButton");
            closeButton.BackColor = Color.White;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            closeButton.Depth = 0;
            closeButton.ForeColor = SystemColors.ControlText;
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
            // noSearchResultsLabel
            // 
            resources.ApplyResources(noSearchResultsLabel, "noSearchResultsLabel");
            noSearchResultsLabel.Name = "noSearchResultsLabel";
            // 
            // pillsLayoutPanel
            // 
            resources.ApplyResources(pillsLayoutPanel, "pillsLayoutPanel");
            pillsLayoutPanel.Name = "pillsLayoutPanel";
            // 
            // loadMedicineWorker
            // 
            loadMedicineWorker.WorkerReportsProgress = true;
            loadMedicineWorker.DoWork += loadMedicineWorker_DoWork;
            loadMedicineWorker.ProgressChanged += loadMedicineWorker_ProgressChanged;
            loadMedicineWorker.RunWorkerCompleted += loadMedicineWorker_RunWorkerCompleted;
            // 
            // SearchPillsForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(medicineListPanel);
            Controls.Add(topPanel);
            Name = "SearchPillsForm";
            Resize += SearchPillsForm_Resize;
            topPanel.ResumeLayout(false);
            topTableLayout.ResumeLayout(false);
            topTableLayout.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            medicineListPanel.ResumeLayout(false);
            medicineListPanel.PerformLayout();
            badSearchPanel.ResumeLayout(false);
            badSearchButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private TableLayoutPanel topTableLayout;
        private Label searchLabel;
        private MaterialSkin.Controls.MaterialButton searchPillsHelpButton;
        private Label searchTextLabel;
        private MaterialSkin.Controls.MaterialTextBox2 searchTextBox;
        private Label filterLabel;
        private MaterialSkin.Controls.MaterialComboBox filterComboBox;
        private Panel medicineListPanel;
        private MaterialSkin.Controls.MaterialButton searchPillsButton;
        public FlowLayoutPanel pillsLayoutPanel;
        private Label noSearchResultsLabel;
        private Panel badSearchPanel;
        private Label badSearchLabel;
        private Panel badSearchButtonPanel;
        private MaterialSkin.Controls.MaterialButton closeButton;
        public System.ComponentModel.BackgroundWorker loadMedicineWorker;
        private Label healthInformationsLabel;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton healthInfoButton;
        public ToolTip pillListItemToolTip;
    }
}