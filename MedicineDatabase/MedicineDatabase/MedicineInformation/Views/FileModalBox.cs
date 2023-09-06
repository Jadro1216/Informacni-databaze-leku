using MaterialSkin.Controls;
using MedicineDatabase.MedicineInformation.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineDatabase.MedicineInformation.Views
{
    public partial class FileModalBox : MaterialForm
    {
        private DocumentFile _file;
        public FileModalBox(DocumentFile file)
        {
            InitializeComponent();
            _file = file;
        }

        private void fileContent_TextChanged(object sender, EventArgs e)
        {

        }

        private async void downloadFileButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        await sw.WriteAsync(Encoding.Default.GetString(_file.FileContent));
                    }
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
