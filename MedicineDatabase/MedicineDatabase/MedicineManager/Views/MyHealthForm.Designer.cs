namespace MedicineDatabase.MedicineManager.Views
{
    partial class MyHealthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyHealthForm));
            printPanel = new Panel();
            printButton = new MaterialSkin.Controls.MaterialButton();
            pillListHelpButton = new MaterialSkin.Controls.MaterialButton();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            myHealthTableLayout = new TableLayoutPanel();
            pillListPanel = new Panel();
            myHealthLabel = new Label();
            myProblemsLabel = new Label();
            myAlergiesLabel = new Label();
            myAlergiesText = new TextBox();
            myPillListLabel = new Label();
            myProblemsText = new TextBox();
            saveMyHealthInformationsButton = new MaterialSkin.Controls.MaterialButton();
            printPanel.SuspendLayout();
            myHealthTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // printPanel
            // 
            printPanel.Controls.Add(printButton);
            resources.ApplyResources(printPanel, "printPanel");
            printPanel.Name = "printPanel";
            // 
            // printButton
            // 
            resources.ApplyResources(printButton, "printButton");
            printButton.Cursor = Cursors.Hand;
            printButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            printButton.Depth = 0;
            printButton.HighEmphasis = true;
            printButton.Icon = null;
            printButton.MouseState = MaterialSkin.MouseState.HOVER;
            printButton.Name = "printButton";
            printButton.NoAccentTextColor = Color.Empty;
            printButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            printButton.UseAccentColor = false;
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // pillListHelpButton
            // 
            resources.ApplyResources(pillListHelpButton, "pillListHelpButton");
            pillListHelpButton.Cursor = Cursors.Hand;
            pillListHelpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            pillListHelpButton.Depth = 0;
            pillListHelpButton.HighEmphasis = true;
            pillListHelpButton.Icon = null;
            pillListHelpButton.MouseState = MaterialSkin.MouseState.HOVER;
            pillListHelpButton.Name = "pillListHelpButton";
            pillListHelpButton.NoAccentTextColor = Color.Empty;
            pillListHelpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            pillListHelpButton.UseAccentColor = false;
            pillListHelpButton.UseVisualStyleBackColor = true;
            pillListHelpButton.Click += pillListHelpButton_Click;
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(printPreviewDialog1, "printPreviewDialog1");
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // myHealthTableLayout
            // 
            resources.ApplyResources(myHealthTableLayout, "myHealthTableLayout");
            myHealthTableLayout.Controls.Add(pillListHelpButton, 1, 0);
            myHealthTableLayout.Controls.Add(pillListPanel, 0, 6);
            myHealthTableLayout.Controls.Add(myHealthLabel, 0, 0);
            myHealthTableLayout.Controls.Add(myProblemsLabel, 0, 1);
            myHealthTableLayout.Controls.Add(myAlergiesLabel, 0, 3);
            myHealthTableLayout.Controls.Add(myAlergiesText, 0, 4);
            myHealthTableLayout.Controls.Add(myPillListLabel, 0, 5);
            myHealthTableLayout.Controls.Add(myProblemsText, 0, 2);
            myHealthTableLayout.Controls.Add(saveMyHealthInformationsButton, 1, 4);
            myHealthTableLayout.Name = "myHealthTableLayout";
            // 
            // pillListPanel
            // 
            resources.ApplyResources(pillListPanel, "pillListPanel");
            myHealthTableLayout.SetColumnSpan(pillListPanel, 2);
            pillListPanel.Name = "pillListPanel";
            // 
            // myHealthLabel
            // 
            resources.ApplyResources(myHealthLabel, "myHealthLabel");
            myHealthLabel.Name = "myHealthLabel";
            // 
            // myProblemsLabel
            // 
            resources.ApplyResources(myProblemsLabel, "myProblemsLabel");
            myHealthTableLayout.SetColumnSpan(myProblemsLabel, 2);
            myProblemsLabel.Name = "myProblemsLabel";
            // 
            // myAlergiesLabel
            // 
            resources.ApplyResources(myAlergiesLabel, "myAlergiesLabel");
            myHealthTableLayout.SetColumnSpan(myAlergiesLabel, 2);
            myAlergiesLabel.Name = "myAlergiesLabel";
            // 
            // myAlergiesText
            // 
            myAlergiesText.BackColor = SystemColors.Control;
            myAlergiesText.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(myAlergiesText, "myAlergiesText");
            myAlergiesText.Name = "myAlergiesText";
            // 
            // myPillListLabel
            // 
            resources.ApplyResources(myPillListLabel, "myPillListLabel");
            myHealthTableLayout.SetColumnSpan(myPillListLabel, 2);
            myPillListLabel.Name = "myPillListLabel";
            // 
            // myProblemsText
            // 
            myProblemsText.BackColor = SystemColors.Control;
            myProblemsText.BorderStyle = BorderStyle.FixedSingle;
            myHealthTableLayout.SetColumnSpan(myProblemsText, 2);
            resources.ApplyResources(myProblemsText, "myProblemsText");
            myProblemsText.Name = "myProblemsText";
            // 
            // saveMyHealthInformationsButton
            // 
            resources.ApplyResources(saveMyHealthInformationsButton, "saveMyHealthInformationsButton");
            saveMyHealthInformationsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveMyHealthInformationsButton.Depth = 0;
            saveMyHealthInformationsButton.HighEmphasis = true;
            saveMyHealthInformationsButton.Icon = null;
            saveMyHealthInformationsButton.MouseState = MaterialSkin.MouseState.HOVER;
            saveMyHealthInformationsButton.Name = "saveMyHealthInformationsButton";
            saveMyHealthInformationsButton.NoAccentTextColor = Color.Empty;
            saveMyHealthInformationsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            saveMyHealthInformationsButton.UseAccentColor = false;
            saveMyHealthInformationsButton.UseVisualStyleBackColor = true;
            saveMyHealthInformationsButton.Click += saveMyHealthInformationsButton_Click;
            // 
            // MyHealthForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(myHealthTableLayout);
            Controls.Add(printPanel);
            Name = "MyHealthForm";
            printPanel.ResumeLayout(false);
            printPanel.PerformLayout();
            myHealthTableLayout.ResumeLayout(false);
            myHealthTableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel printPanel;
        private MaterialSkin.Controls.MaterialButton printButton;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MaterialSkin.Controls.MaterialButton pillListHelpButton;
        private TableLayoutPanel myHealthTableLayout;
        private Panel pillListPanel;
        private Label myHealthLabel;
        private Label myProblemsLabel;
        private Label myAlergiesLabel;
        private TextBox myAlergiesText;
        private Label myPillListLabel;
        private MaterialSkin.Controls.MaterialButton saveMyHealthInformationsButton;
        private TextBox myProblemsText;
    }
}