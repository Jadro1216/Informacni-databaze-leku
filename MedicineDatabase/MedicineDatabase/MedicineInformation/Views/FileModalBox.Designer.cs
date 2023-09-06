namespace MedicineDatabase.MedicineInformation.Views
{
    partial class FileModalBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileModalBox));
            panel1 = new Panel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            downloadFileButton = new MaterialSkin.Controls.MaterialButton();
            saveFileDialog = new SaveFileDialog();
            fileContentText = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(materialButton1);
            panel1.Controls.Add(downloadFileButton);
            panel1.Name = "panel1";
            // 
            // materialButton1
            // 
            resources.ApplyResources(materialButton1, "materialButton1");
            materialButton1.Cursor = Cursors.Hand;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // downloadFileButton
            // 
            resources.ApplyResources(downloadFileButton, "downloadFileButton");
            downloadFileButton.Cursor = Cursors.Hand;
            downloadFileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            downloadFileButton.Depth = 0;
            downloadFileButton.HighEmphasis = true;
            downloadFileButton.Icon = null;
            downloadFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            downloadFileButton.Name = "downloadFileButton";
            downloadFileButton.NoAccentTextColor = Color.Empty;
            downloadFileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            downloadFileButton.UseAccentColor = false;
            downloadFileButton.UseVisualStyleBackColor = true;
            downloadFileButton.Click += downloadFileButton_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "pdf|doc";
            resources.ApplyResources(saveFileDialog, "saveFileDialog");
            // 
            // fileContentText
            // 
            resources.ApplyResources(fileContentText, "fileContentText");
            fileContentText.BackColor = Color.White;
            fileContentText.Name = "fileContentText";
            fileContentText.ReadOnly = true;
            // 
            // FileModalBox
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(fileContentText);
            Controls.Add(panel1);
            Name = "FileModalBox";
            ShowIcon = false;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton downloadFileButton;
        private SaveFileDialog saveFileDialog;
        public RichTextBox fileContentText;
    }
}