namespace MedicineDatabase.MedicineManager.Components
{
    partial class LoadingPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingPanel));
            loadingBar = new ProgressBar();
            loadingLabel = new Label();
            SuspendLayout();
            // 
            // loadingBar
            // 
            resources.ApplyResources(loadingBar, "loadingBar");
            loadingBar.Name = "loadingBar";
            loadingBar.Style = ProgressBarStyle.Marquee;
            // 
            // loadingLabel
            // 
            resources.ApplyResources(loadingLabel, "loadingLabel");
            loadingLabel.Name = "loadingLabel";
            // 
            // LoadingPanel
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(loadingLabel);
            Controls.Add(loadingBar);
            Name = "LoadingPanel";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar loadingBar;
        private Label loadingLabel;
    }
}
