namespace MedicineDatabase.MedicineManager.Views
{
    partial class MyHealthHelpForm
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
            pillListHelpTextbox = new RichTextBox();
            SuspendLayout();
            // 
            // pillListHelpTextbox
            // 
            pillListHelpTextbox.BackColor = Color.White;
            pillListHelpTextbox.BorderStyle = BorderStyle.None;
            pillListHelpTextbox.Dock = DockStyle.Fill;
            pillListHelpTextbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pillListHelpTextbox.Location = new Point(0, 64);
            pillListHelpTextbox.Name = "pillListHelpTextbox";
            pillListHelpTextbox.Size = new Size(1113, 768);
            pillListHelpTextbox.TabIndex = 0;
            pillListHelpTextbox.Text = "";
            // 
            // MyHealthHelpForm
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1118, 836);
            Controls.Add(pillListHelpTextbox);
            Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "MyHealthHelpForm";
            Padding = new Padding(0, 64, 5, 4);
            Text = "MyHealthHelpForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox pillListHelpTextbox;
    }
}