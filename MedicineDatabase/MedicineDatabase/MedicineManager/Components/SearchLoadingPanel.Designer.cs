namespace MedicineDatabase.MedicineManager.Components
{
    partial class SearchLoadingPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchLoadingPanel));
            progressBar1 = new ProgressBar();
            searchLoadingText = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            resources.ApplyResources(progressBar1, "progressBar1");
            progressBar1.Name = "progressBar1";
            progressBar1.Style = ProgressBarStyle.Marquee;
            // 
            // searchLoadingText
            // 
            resources.ApplyResources(searchLoadingText, "searchLoadingText");
            searchLoadingText.Name = "searchLoadingText";
            // 
            // SearchLoadingPanel
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(searchLoadingText);
            Controls.Add(progressBar1);
            Name = "SearchLoadingPanel";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Label searchLoadingText;
    }
}
