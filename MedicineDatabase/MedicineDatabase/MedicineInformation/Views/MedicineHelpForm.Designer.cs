namespace MedicineDatabase.MedicineInformation.Views
{
    partial class MedicineHelpForm
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
            medicineHelpTextbox = new RichTextBox();
            SuspendLayout();
            // 
            // medicineHelpTextbox
            // 
            medicineHelpTextbox.BackColor = Color.White;
            medicineHelpTextbox.BorderStyle = BorderStyle.None;
            medicineHelpTextbox.Dock = DockStyle.Fill;
            medicineHelpTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            medicineHelpTextbox.Location = new Point(0, 64);
            medicineHelpTextbox.Name = "medicineHelpTextbox";
            medicineHelpTextbox.Size = new Size(1113, 768);
            medicineHelpTextbox.TabIndex = 0;
            medicineHelpTextbox.Text = "";
            // 
            // MedicineHelpForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1118, 836);
            Controls.Add(medicineHelpTextbox);
            Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            MinimumSize = new Size(1118, 836);
            Name = "MedicineHelpForm";
            Padding = new Padding(0, 64, 5, 4);
            Text = "MedicineHelpForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox medicineHelpTextbox;
    }
}