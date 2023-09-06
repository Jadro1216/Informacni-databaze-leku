namespace MedicineDatabase.Pharmacies.Components
{
    partial class ListItem
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            distanceLabel = new Label();
            addressLabel = new Label();
            nameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(19, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 164);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.MinimumSize = new Size(195, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 164);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(distanceLabel);
            panel3.Controls.Add(addressLabel);
            panel3.Controls.Add(nameLabel);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(195, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 162);
            panel3.TabIndex = 6;
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Dock = DockStyle.Top;
            distanceLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            distanceLabel.Location = new Point(0, 108);
            distanceLabel.MinimumSize = new Size(237, 54);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new Size(237, 54);
            distanceLabel.TabIndex = 2;
            distanceLabel.Text = "Vzdialenosť";
            distanceLabel.SizeChanged += label_SizeChanged;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Dock = DockStyle.Top;
            addressLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addressLabel.Location = new Point(0, 54);
            addressLabel.MinimumSize = new Size(237, 54);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(237, 54);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Adresa";
            addressLabel.SizeChanged += label_SizeChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Dock = DockStyle.Top;
            nameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(0, 0);
            nameLabel.MinimumSize = new Size(237, 54);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(237, 54);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Názov";
            nameLabel.SizeChanged += nameLabel_SizeChanged;
            // 
            // ListItem
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.LightBlue;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Cursor = Cursors.Hand;
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ListItem";
            Size = new Size(432, 162);
            Load += ListItem_Load;
            SizeChanged += ListItem_SizeChanged;
            Click += ListItem_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label nameLabel;
        private Label distanceLabel;
        private Label addressLabel;
    }
}
