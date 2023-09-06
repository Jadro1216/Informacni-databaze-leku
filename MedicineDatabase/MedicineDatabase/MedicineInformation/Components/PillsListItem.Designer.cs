namespace MedicineDatabase.MedicineInformation.Components
{
    partial class PillsListItem
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            pillPictureBox = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            pillNameLabel = new Label();
            pillSuklLabel = new Label();
            pillATCLabel = new Label();
            pillListItemToolTip = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pillPictureBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(129, 85);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(pillPictureBox);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15, 0, 15, 0);
            panel2.Size = new Size(110, 85);
            panel2.TabIndex = 0;
            // 
            // pillPictureBox
            // 
            pillPictureBox.Dock = DockStyle.Fill;
            pillPictureBox.InitialImage = null;
            pillPictureBox.Location = new Point(15, 0);
            pillPictureBox.Name = "pillPictureBox";
            pillPictureBox.Size = new Size(80, 85);
            pillPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pillPictureBox.TabIndex = 0;
            pillPictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightSkyBlue;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Controls.Add(pillNameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(pillSuklLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(pillATCLabel, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(129, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(261, 85);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pillNameLabel
            // 
            pillNameLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(pillNameLabel, 2);
            pillNameLabel.Dock = DockStyle.Fill;
            pillNameLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            pillNameLabel.Location = new Point(3, 0);
            pillNameLabel.MinimumSize = new Size(257, 51);
            pillNameLabel.Name = "pillNameLabel";
            pillNameLabel.Size = new Size(257, 51);
            pillNameLabel.TabIndex = 0;
            pillNameLabel.Text = "Ibalgin grip";
            // 
            // pillSuklLabel
            // 
            pillSuklLabel.AutoSize = true;
            pillSuklLabel.Dock = DockStyle.Fill;
            pillSuklLabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            pillSuklLabel.Location = new Point(3, 54);
            pillSuklLabel.Margin = new Padding(3);
            pillSuklLabel.MinimumSize = new Size(138, 28);
            pillSuklLabel.Name = "pillSuklLabel";
            pillSuklLabel.Size = new Size(138, 28);
            pillSuklLabel.TabIndex = 1;
            pillSuklLabel.Text = "SUKL Kód: 9999999";
            // 
            // pillATCLabel
            // 
            pillATCLabel.AutoSize = true;
            pillATCLabel.Dock = DockStyle.Fill;
            pillATCLabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            pillATCLabel.Location = new Point(146, 54);
            pillATCLabel.Margin = new Padding(3);
            pillATCLabel.Name = "pillATCLabel";
            pillATCLabel.Size = new Size(112, 28);
            pillATCLabel.TabIndex = 2;
            pillATCLabel.Text = "ATC: 9999999";
            // 
            // pillListItemToolTip
            // 
            pillListItemToolTip.ToolTipIcon = ToolTipIcon.Warning;
            // 
            // PillsListItem
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Margin = new Padding(4);
            MinimumSize = new Size(390, 85);
            Name = "PillsListItem";
            Size = new Size(390, 85);
            Load += PillsListItem_Load;
            Click += PillListItem_Click;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pillPictureBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        public PictureBox pillPictureBox;
        public TableLayoutPanel tableLayoutPanel1;
        public Label pillNameLabel;
        public Label pillSuklLabel;
        public Label pillATCLabel;
        public ToolTip pillListItemToolTip;
    }
}
