using MedicineDatabase.MedicineManager.Controllers;

namespace MedicineDatabase.MedicineManager.Components
{
    public partial class SmallPillListItem : UserControl
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string sukl;

        public string SUKL
        {
            get { return sukl; }
            set { sukl = value; }
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private MedicineManagerController medicineManagerController;
        public SmallPillListItem(MedicineManagerController controller)
        {
            InitializeComponent();
            medicineManagerController = controller;
        }

        private void increaseCountButton_Click(object sender, EventArgs e)
        {
            //Shared.PillList.FirstOrDefault(itm => itm.SUKL.Equals(this.SUKL)).Count++;
            //this.countLabel.Text = Shared.PillList.FirstOrDefault(itm => itm.SUKL.Equals(this.SUKL)).Count.ToString();
            medicineManagerController.MedicineModel.PillList.FirstOrDefault(itm => itm.SUKL.Equals(this.SUKL)).Count++;
            this.countLabel.Text = medicineManagerController.MedicineModel.PillList.FirstOrDefault(itm => itm.SUKL.Equals(this.SUKL)).Count.ToString();
        }

        private void decreaseCountButton_Click(object sender, EventArgs e)
        {
            //Shared.PillList.FirstOrDefault(itm => itm.SUKL.Equals(this.SUKL)).Count--;
            //if (Shared.PillList.FirstOrDefault(itm => itm.SUKL.Equals(this.SUKL)).Count <= 0)
            //{
            //    //Shared.MyHealthForm.Controls.Remove(this);
            //    Shared.PillList.Remove(this);
            //    Shared.MyHealthForm.CreateDynamicTableLayout();
            //}
            //else
            //{
            //    this.countLabel.Text = Shared.PillList.FirstOrDefault(itm => itm.SUKL.Equals(this.SUKL)).Count.ToString();
            //}
            medicineManagerController.MedicineModel.PillList.FirstOrDefault(itm => itm.SUKL.Equals(this.SUKL)).Count--;
            if (medicineManagerController.MedicineModel.PillList.FirstOrDefault(itm => itm.SUKL.Equals(this.SUKL)).Count <= 0)
            {
                //Shared.MyHealthForm.Controls.Remove(this);
                medicineManagerController.MedicineModel.PillList.Remove(this);
                medicineManagerController.MyHealthForm.CreateDynamicTableLayout();
            }
            else
            {
                this.countLabel.Text = medicineManagerController.MedicineModel.PillList.FirstOrDefault(itm => itm.SUKL.Equals(this.SUKL)).Count.ToString();
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            //Shared.PillList.Remove(this);
            //Shared.MyHealthForm.CreateDynamicTableLayout();
            medicineManagerController.MedicineModel.PillList.Remove(this);
            medicineManagerController.MyHealthForm.CreateDynamicTableLayout();
        }
    }
}
