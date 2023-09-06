namespace MedicineDatabase.Pharmacies.Views
{
    partial class PharmaciesHelpForm
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
            pharmaciesHelpTextbox = new RichTextBox();
            SuspendLayout();
            // 
            // pharmaciesHelpTextbox
            // 
            pharmaciesHelpTextbox.BackColor = Color.White;
            pharmaciesHelpTextbox.BorderStyle = BorderStyle.None;
            pharmaciesHelpTextbox.Dock = DockStyle.Fill;
            pharmaciesHelpTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pharmaciesHelpTextbox.Location = new Point(0, 64);
            pharmaciesHelpTextbox.Name = "pharmaciesHelpTextbox";
            pharmaciesHelpTextbox.Size = new Size(1113, 768);
            pharmaciesHelpTextbox.TabIndex = 1;
            pharmaciesHelpTextbox.Text = "";
            // 
            // PharmaciesHelpForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 836);
            Controls.Add(pharmaciesHelpTextbox);
            Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            MinimumSize = new Size(1118, 836);
            Name = "PharmaciesHelpForm";
            Padding = new Padding(0, 64, 5, 4);
            Text = "PharmaciesHelpForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox pharmaciesHelpTextbox;
    }
}