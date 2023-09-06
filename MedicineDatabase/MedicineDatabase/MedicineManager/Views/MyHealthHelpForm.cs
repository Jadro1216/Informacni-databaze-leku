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

namespace MedicineDatabase.MedicineManager.Views
{
    public partial class MyHealthHelpForm : MaterialForm
    {
        public MyHealthHelpForm()
        {
            InitializeComponent();
            pillListHelpTextbox.Text = Language.MyHealthHelpText;       //Const.MyHealthHelpText;
        }
    }
}
