using MaterialSkin.Controls;
using MedicineDatabase.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineDatabase.Pharmacies.Views
{
    public partial class PharmaciesHelpForm : MaterialForm
    {
        public PharmaciesHelpForm()
        {
            InitializeComponent();
            pharmaciesHelpTextbox.Text = Language.PharmaciesHelpText;
        }
    }
}
