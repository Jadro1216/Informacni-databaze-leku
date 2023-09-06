using MaterialSkin.Controls;
using MedicineDatabase.MedicineManager.Components;
using MedicineDatabase.MedicineManager.Controllers;
using System.Text;

namespace MedicineDatabase.MedicineManager.Views
{
    public partial class MyHealthForm : MaterialForm
    {
        public List<SmallPillListItem> list;
        public MedicineManagerController _medicineManagerController;
        public MyHealthForm()
        {
            InitializeComponent();
            //list = _medicineManagerController.PillList;
        }

        public void CreateDynamicTableLayout()
        {
            pillListPanel.SuspendLayout();
            pillListPanel.Controls.Clear();
            pillListPanel.AutoScroll = true;
            foreach (var item in list)
            {
                item.Dock = DockStyle.Top;
                item.nameLabel.Text = item.Name;
                item.countLabel.Text = item.Count.ToString();
                pillListPanel.Controls.Add(item);
            }
            pillListPanel.ResumeLayout();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.Append(item.Name + "      -->      " + item.Count.ToString() + "x\n");
            }
            e.Graphics.DrawString(sb.ToString(), new Font("Time New Romans", 14), Brushes.Black, new PointF(100, 100));
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void pillListHelpButton_Click(object sender, EventArgs e)
        {
            //Shared.OpenChildForm(Shared.MyHealthHelpForm);
            //Shared.MainForm.containerPanel.Controls.Add(Shared.MyHealthHelpForm);
            //Shared.MainForm.containerPanel.Tag = Shared.MyHealthHelpForm;
            _medicineManagerController.OpenChildForm(_medicineManagerController.MyHealthHelpForm);
            _medicineManagerController.SetPostOpenChildProperties(_medicineManagerController.MyHealthHelpForm);
        }

        private void saveMyHealthInformationsButton_Click(object sender, EventArgs e)
        {
            _medicineManagerController.MedicineModel.Allergies = myAlergiesText.Text.Split(",");
            _medicineManagerController.MedicineModel.HealthProblems = myProblemsText.Text.Split(",");
        }
    }
}
