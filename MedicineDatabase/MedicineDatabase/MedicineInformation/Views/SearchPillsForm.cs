using MaterialSkin;
using MaterialSkin.Controls;
using MedicineDatabase.Languages;
using MedicineDatabase.MedicineInformation.Controllers;
using MedicineDatabase.MedicineInformation.Domain;
using MedicineDatabase.MedicineManager.Components;
using System.ComponentModel;
using MedicineDatabase.MedicineManager.Views;

namespace MedicineDatabase.MedicineInformation.Views
{
    public partial class SearchPillsForm : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        public MedicineController _medicineController;

        public LoadingPanel LoadingPanel { get; private set; }
        public SearchLoadingPanel SearchLoadingPanel { get; private set; }

        public SearchPillsForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red400, Primary.Blue500, //#EF5350, #2196F3
                Primary.Yellow500, Accent.Yellow700, //#FFEB3B, #81D4FA 
                TextShade.WHITE
            );
        }

        private void searchLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 668, (float)label.Height / 61);

            float newFontSize = 18 * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize, FontStyle.Regular, GraphicsUnit.Point);

            label.Font = newFont;
        }

        private void searchTextLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 418, (float)label.Height / 45);

            float newFontSize = 12 * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize, FontStyle.Regular, GraphicsUnit.Point);

            label.Font = newFont;
        }

        private void filterLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 352, (float)label.Height / 45);

            float newFontSize = 12 * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize, FontStyle.Regular, GraphicsUnit.Point);

            label.Font = newFont;
        }

        private void searchPillsHelpButton_Click(object sender, EventArgs e)
        {
            var form = _medicineController.GetFormInstance<MedicineHelpForm>();
            _medicineController.OpenFormInMainForm(form);
        }

        private void searchPillsButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length == 0)
            {
                badSearchPanel.Visible = true;
                badSearchLabel.Visible = true;
                badSearchButtonPanel.Visible = true;
                closeButton.Visible = true;
            }
            else
            {
                noSearchResultsLabel.Visible = false;
                string phrase = searchTextBox.Text;
                string filter = filterComboBox.Text;
                Thread backgroundThread = new Thread(
                    new ThreadStart(() =>
                    {
                        StartLoadingAnimation();
                        _medicineController.SearchingPills = true;
                        _medicineController.GetMedicinePills(phrase, filter);
                        _medicineController.FillMedicineList();

                        this.Enabled = true;
                        _medicineController.SetMainFormEnabled(true);

                        if (_medicineController.Pills.Count == 0)
                        {
                            noSearchResultsLabel.Invoke(new Action(() => noSearchResultsLabel.Text = Language.noSearchPillsResultText));
                            noSearchResultsLabel.Invoke(new Action(() => noSearchResultsLabel.Visible = true));
                        }


                        _medicineController.SearchingPills = false;
                        StopLoadingAnimation();
                    }
                ));
                backgroundThread.Start();
            }
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            badSearchPanel.Visible = false;
            badSearchLabel.Visible = false;
            badSearchButtonPanel.Visible = false;
            closeButton.Visible = false;
        }

        private void SearchPillsForm_Resize(object sender, EventArgs e)
        {
            int panelWidth = badSearchPanel.Width;
            int panelHeight = badSearchPanel.Height;

            badSearchPanel.Left = (this.ClientSize.Width - panelWidth) / 2;
            badSearchPanel.Top = (this.ClientSize.Height - panelHeight) / 2;
        }

        private void badSearchLabel_SizeChanged(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            float scaleFactor = Math.Min((float)label.Width / 314, (float)label.Height / 194);

            float newFontSize = 18 * scaleFactor;

            var newFont = new Font(label.Font.FontFamily.Name, newFontSize, FontStyle.Regular, GraphicsUnit.Point);

            label.Font = newFont;
        }

        private void loadMedicineWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("Load medicine pills worker started. ");
            PillsWorkerContext context = e.Argument as PillsWorkerContext;
            _medicineController.GetMedicinePills(context.Text, context.Filter);
            _medicineController.FillMedicineList();

        }

        private void loadMedicineWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void loadMedicineWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Load medicine pills worker finished. ");
            _medicineController.SearchingPills = false;
        }

        public void StartLoadingAnimation()
        {
            SearchLoadingPanel = new SearchLoadingPanel();
            SearchLoadingPanel.Location = new Point(10, 10);
            SearchLoadingPanel.Show();
            pillsLayoutPanel.Invoke(new Action(() => pillsLayoutPanel.Visible = false));
            SearchLoadingPanel.BringToFront();
            medicineListPanel.Invoke(new Action(() => medicineListPanel.Controls.Add(SearchLoadingPanel)));
        }

        public void StopLoadingAnimation()
        {
            SearchLoadingPanel.Invoke(new Action(() => SearchLoadingPanel.Hide()));
            medicineListPanel.Invoke(new Action(() => medicineListPanel.Controls.Remove(SearchLoadingPanel)));
            pillsLayoutPanel.Invoke(new Action(() => pillsLayoutPanel.Visible = true));
        }

        private void healthInfoButton_Click(object sender, EventArgs e)
        {
            var form = _medicineController.GetFormInstance<MyHealthForm>();
            _medicineController.OpenFormInMainForm(form);
        }
    }
}
