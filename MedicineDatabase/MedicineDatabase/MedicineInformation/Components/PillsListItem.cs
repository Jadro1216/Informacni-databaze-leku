using MedicineDatabase.MedicineInformation.Domain;
using MedicineDatabase.MedicineInformation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MedicineDatabase.MedicineInformation.Components
{
    public partial class PillsListItem : UserControl
    {
        #region Properties
        private string _Name;
        private string _Sukl;
        private string _Atc;
        private Image _icon;

        public MedicineModel Pill { get; set; }
        public int Id { get; set; }
        [Category("Custom properties")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; /*pillNameLabel.Text = value;*/ }
        }
        [Category("Custom properties")]
        public string SUKLCode
        {
            get { return _Sukl; }
            set { _Sukl = value; pillSuklLabel.Text = value; }
        }
        [Category("Custom properties")]
        public string? ATC
        {
            get { return _Atc; }
            set { _Atc = value; pillATCLabel.Text = value; }
        }

        [Category("Custom properties")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pillPictureBox.Image = value; }
        }
        public string? MedicalPower { get; set; }
        public string? Form { get; set; }
        public string? Packing { get; set; }
        public string? WayOfUse { get; set; }
        public string? Supplement { get; set; }
        public string? Cover { get; set; }
        public string? RegistrationHolder { get; set; }
        public string? HolderCountry { get; set; }
        public string? RegistrationState { get; set; }
        public string? RegistrationValidTo_DDMMYY { get; set; }
        public string? UnlimitedRegistration { get; set; }
        public string? IndicationGroup { get; set; }

        public string? RegistrationNumber { get; set; }
        public string? RegistrationProcedure { get; set; }
        public string? WHO_Index { get; set; }
        public string? MedicalSubstances { get; set; }
        public string? Dispensing { get; set; }
        public string? Doping { get; set; }
        public string? Expiration { get; set; }
        public string? Expoiration_Type { get; set; }
        public string? RegisteredName { get; set; }
        public string? Indications { get; set; }
        public string? Contraindications { get; set; }
        public string? SideEffects { get; set; }
        public string? Applicability { get; set; }
        public string? Warnings { get; set; }
        public string? Interactions { get; set; }
        public string? Dosage { get; set; }
        public string? Compositions { get; set; }
        public string? Substances { get; set; }
        public string? Overdose { get; set; }
        public DocumentFile? DocumentFile { get; set; }
        public List<MedicineModel> Simmiar { get; set; }
        #endregion

        public event EventHandler PillListItemClick;
        public PillsListItem()
        {
            InitializeComponent();
        }

        protected void PillListItem_Click(object sender, EventArgs e)
        {
            if (this.PillListItemClick != null)
            {
                if (sender is not PillsListItem)
                {
                    this.PillListItemClick(this, e);
                }
                else this.PillListItemClick(sender, e);
            }
        }

        private void PillsListItem_Load(object sender, EventArgs e)
        {
            addClikcEvent(this);
        }

        private void addClikcEvent(Control obj)
        {
            foreach (Control c in obj.Controls)
            {
                c.Click += new EventHandler(PillListItem_Click);
                if (c is Panel) addClikcEvent(c);
            }
        }
    }
}
