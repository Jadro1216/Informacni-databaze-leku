using MaterialSkin.Controls;
using MedicineDatabase.Languages;
using MedicineDatabase.MedicineInformation.Components;
using MedicineDatabase.MedicineInformation.Controllers;
using MedicineDatabase.MedicineInformation.Models;
using MedicineDatabase.Properties;
using MedicineDatabase.MedicineManager.Components;

namespace MedicineDatabase.MedicineInformation.Views
{
    public partial class PillsDetailForm : MaterialForm
    {
        private MedicineModel pill;
        public MedicineController _medicineController;
        public PillsDetailForm()
        {
            InitializeComponent();
        }

        public void ShowDetails_Handler(object sender, EventArgs e)
        {
            var item = (PillsListItem)sender;
            ShowDetails(item);
            FillSimmilarList(item.Pill.Simmiar);
            this.Dock = DockStyle.Top;
            _medicineController.OpenFormInMainForm(this);
        }
        public void ShowSimmilarDetails_Handler(object sender, EventArgs e)
        {
            var item = (PillsListItem)sender;
            Console.WriteLine(item.Pill.ATC_Name);
            ShowDetails(item);
            FillSimmilarList(item.Pill.Simmiar);
        }

        internal void ShowDetails(PillsListItem item)
        {
            this.pill = item.Pill;
            pillNameLabel.Text = item.Pill.Name;
            pillPowerText.Text = item.Pill.MedicalPower ?? "";
            pillSupplementText.Text = item.Pill.Supplement ?? "";
            pillFormText.Text = item.Pill.Form ?? "";
            pillPackingText.Text = item.Pill.Packing ?? "";
            pillWayOfUseText.Text = item.Pill.WayOfUse ?? "";
            pillCoverText.Text = item.Pill.Cover ?? "";
            pillDispensingText.Text = item.Pill.Dispensing ?? "";
            pillMedicalSubstancesText.Text = item.Pill.MedicalSubstances ?? "";
            pillSuklText.Text = item.Pill.SUKLCode ?? "";
            pillATCCodeText.Text = item.Pill.ATC ?? "";
            pillAtcNameText.Text = item.Pill.ATC_Name ?? "";
            pillRegistrationNumberText.Text = item.Pill.RegistrationNumber ?? "";
            pillRegistrationHolderText.Text = item.Pill.RegistrationHolder ?? "";
            pillRegistrationHolderCountryText.Text = item.Pill.HolderCountry ?? "";
            if (item.Pill.UnlimitedRegistration != null && item.Pill.UnlimitedRegistration.Equals("X"))
            {
                pillUnlimitedRegistrationText.Image = Resources.yes;
            }
            else
            {
                pillUnlimitedRegistrationText.Image = Resources.no;
            }

            string exp = "";
            if (item.Pill.Expiration != null && item.Pill.Expoiration_Type != null)
            {
                exp = item.Pill.Expiration + " " + item.Pill.Expoiration_Type;
            }
            pillExpirationText.Text = exp;
            pillDetailTooltip.SetToolTip(pillExpirationText, Language.PillDetailExpirationTooltipText);

            indicationsText.Text = item.Pill.Indications != null ? item.Pill.Indications.Replace("\n", "\r\n") : "";
            contraindicationsText.Text = item.Pill.Contraindications != null ? item.Pill.Contraindications.Replace("\n", "\r\n") : "";
            sideeffectsText.Text = item.Pill.SideEffects != null ? item.Pill.SideEffects.Replace("\n", "\r\n") : "";
            applicabilityText.Text = item.Pill.Applicability != null ? item.Pill.Applicability.Replace("\n", "\r\n") : "";
            warningsText.Text = item.Pill.Warnings != null ? item.Pill.Warnings.Replace("\n", "\r\n") : "";
            interactionsText.Text = item.Pill.Interactions != null ? item.Pill.Interactions.Replace("\n", "\r\n") : "";
            dosageText.Text = item.Pill.Dosage != null ? item.Pill.Dosage.Replace("\n", "\r\n") : "";
            compositionText.Text = item.Pill.Compositions != null ? item.Pill.Compositions.Replace("\n", "\r\n") : "";
            overodeText.Text = item.Pill.Overdose != null ? item.Pill.Overdose.Replace("\n", "\r\n") : "";
            substancesText.Text = item.Pill.Substances != null ? item.Pill.Substances.Replace("\n", "\r\n") : "";
            if (item.Pill.DocumentFile.FileName != null)
            {
                openPillDocumentButton.Text = item.Pill.DocumentFile.FileName;
                openPillDocumentButton.Visible = true;
            }
            else
            {
                openPillDocumentButton.Visible = false;
            }
        }

        internal void FillSimmilarList(List<MedicineModel> pills)
        {
            simmilarListLayoutPanel.Controls.Clear();

            foreach (var item in pills)
            {
                PillsListItem pillItem = new PillsListItem();
                pillItem.Name = item.Name;
                pillItem.SUKLCode = Language.PillListItem_SUKLCode + item.SUKLCode;
                pillItem.ATC = "ATC: " + item.ATC;
                pillItem.Pill = item;
                pillItem.Icon = Resources.Pill_Item;
                pillItem.pillNameLabel.Text = item.Name + "\n" + item.Supplement;
                pillItem.PillListItemClick += new EventHandler(ShowSimmilarDetails_Handler);
                simmilarListLayoutPanel.Controls.Add(pillItem);
            }
        }


        private void goBackToSearchButton_Click(object sender, EventArgs e)
        {
            var form = _medicineController.GetFormInstance<SearchPillsForm>();
            _medicineController.OpenFormInMainForm(form);
        }

        private void pillDetailsHelpButton_Click(object sender, EventArgs e)
        {
            var form = _medicineController.GetFormInstance<MedicineHelpForm>();
            _medicineController.OpenFormInMainForm(form);
        }

        private void openPillDocumentButton_Click(object sender, EventArgs e)
        {
            Form Background = new Form();
            FileModalBox modal = new FileModalBox(pill.DocumentFile);
            using (modal)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.7d;
                var mainForm = _medicineController.GetMainForm();
                Background.Size = mainForm.Size;
                Background.BackColor = Color.Black;
                Background.Location = mainForm.Location;
                Background.ShowInTaskbar = false;
                Background.Show(mainForm);
                string tmpFilePath = Path.GetTempFileName();
                if (pill.DocumentFile.FileContent != null)
                {

                    string txt = "";
                    using (MemoryStream stream = new MemoryStream(pill.DocumentFile.FileContent))
                    {
                        using (StreamReader streamReader = new StreamReader(stream))
                        {
                            txt = streamReader.ReadToEnd();
                        }
                    }
                    File.WriteAllBytes(tmpFilePath, pill.DocumentFile.FileContent);
                    modal.fileContentText.Text = File.ReadAllText(tmpFilePath);
                    File.Delete(tmpFilePath);
                }

                modal.Owner = Background;
                modal.ShowDialog(Background);
                Background.Dispose();
            }
        }

        private void pillNameLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 701, (float)label.Height / 58);

            float newFontSize = 13 * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize, FontStyle.Regular, GraphicsUnit.Point);

            label.Font = newFont;
        }

        private void simmilarLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 309, (float)label.Height / 46);

            float newFontSize = 12 * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize, FontStyle.Regular, GraphicsUnit.Point);

            label.Font = newFont;
        }

        private void pillDetailsLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 135, (float)label.Height / 26);

            float newFontSize = 9 * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize, FontStyle.Regular, GraphicsUnit.Point);

            label.Font = newFont;
        }

        private void additionalDetailLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 1100, (float)label.Height / 41);

            float newFontSize = 13 * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize, FontStyle.Regular, GraphicsUnit.Point);

            label.Font = newFont;
        }

        private void pillDocumentDetailLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 547, (float)label.Height / 25);

            float newFontSize = 10 * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize, FontStyle.Regular, GraphicsUnit.Point);

            label.Font = newFont;
        }

        private void pillAddToListButton_Click(object sender, EventArgs e)
        {
            SmallPillListItem newItm = new SmallPillListItem(_medicineController._medicineManagerController);
            newItm.Name = this.pill.Name + " " + this.pill.Supplement;
            newItm.nameLabel.Text = this.pill.Name + " " + this.pill.Supplement;
            newItm.SUKL = this.pill.SUKLCode;
            newItm.Id = this.pill.Id;
            newItm.Count = 1;
            newItm.countLabel.Text = newItm.Count.ToString();

            _medicineController.AddPillToList(newItm);
        }
    }
}
