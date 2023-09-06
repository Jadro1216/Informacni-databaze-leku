namespace MedicineDatabase.MedicineManager.Components
{
    partial class SmallPillListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmallPillListItem));
            tableLayoutPanel1 = new TableLayoutPanel();
            deleteItemButton = new MaterialSkin.Controls.MaterialButton();
            countButtonPanel = new Panel();
            decreaseCountButton = new MaterialSkin.Controls.MaterialButton();
            increaseCountButton = new MaterialSkin.Controls.MaterialButton();
            countLabel = new Label();
            nameLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            countButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.Controls.Add(deleteItemButton, 3, 0);
            tableLayoutPanel1.Controls.Add(countButtonPanel, 2, 0);
            tableLayoutPanel1.Controls.Add(countLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // deleteItemButton
            // 
            resources.ApplyResources(deleteItemButton, "deleteItemButton");
            deleteItemButton.Cursor = Cursors.Hand;
            deleteItemButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteItemButton.Depth = 0;
            deleteItemButton.HighEmphasis = true;
            deleteItemButton.Icon = null;
            deleteItemButton.MouseState = MaterialSkin.MouseState.HOVER;
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.NoAccentTextColor = Color.Empty;
            deleteItemButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            deleteItemButton.UseAccentColor = false;
            deleteItemButton.UseVisualStyleBackColor = true;
            deleteItemButton.Click += deleteItemButton_Click;
            // 
            // countButtonPanel
            // 
            resources.ApplyResources(countButtonPanel, "countButtonPanel");
            countButtonPanel.Controls.Add(decreaseCountButton);
            countButtonPanel.Controls.Add(increaseCountButton);
            countButtonPanel.Name = "countButtonPanel";
            // 
            // decreaseCountButton
            // 
            resources.ApplyResources(decreaseCountButton, "decreaseCountButton");
            decreaseCountButton.Cursor = Cursors.Hand;
            decreaseCountButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            decreaseCountButton.Depth = 0;
            decreaseCountButton.HighEmphasis = true;
            decreaseCountButton.Icon = null;
            decreaseCountButton.MouseState = MaterialSkin.MouseState.HOVER;
            decreaseCountButton.Name = "decreaseCountButton";
            decreaseCountButton.NoAccentTextColor = Color.Empty;
            decreaseCountButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            decreaseCountButton.UseAccentColor = false;
            decreaseCountButton.UseVisualStyleBackColor = true;
            decreaseCountButton.Click += decreaseCountButton_Click;
            // 
            // increaseCountButton
            // 
            resources.ApplyResources(increaseCountButton, "increaseCountButton");
            increaseCountButton.Cursor = Cursors.Hand;
            increaseCountButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            increaseCountButton.Depth = 0;
            increaseCountButton.HighEmphasis = true;
            increaseCountButton.Icon = null;
            increaseCountButton.MouseState = MaterialSkin.MouseState.HOVER;
            increaseCountButton.Name = "increaseCountButton";
            increaseCountButton.NoAccentTextColor = Color.Empty;
            increaseCountButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            increaseCountButton.UseAccentColor = false;
            increaseCountButton.UseVisualStyleBackColor = true;
            increaseCountButton.Click += increaseCountButton_Click;
            // 
            // countLabel
            // 
            resources.ApplyResources(countLabel, "countLabel");
            countLabel.Name = "countLabel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(nameLabel, "nameLabel");
            nameLabel.Name = "nameLabel";
            // 
            // SmallPillListItem
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "SmallPillListItem";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            countButtonPanel.ResumeLayout(false);
            countButtonPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton deleteItemButton;
        private Panel countButtonPanel;
        private MaterialSkin.Controls.MaterialButton increaseCountButton;
        private MaterialSkin.Controls.MaterialButton decreaseCountButton;
        public Label countLabel;
        public Label nameLabel;
    }
}
