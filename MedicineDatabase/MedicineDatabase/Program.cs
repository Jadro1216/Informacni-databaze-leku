using MedicineDatabase.MedicineManager.Controllers;
using MedicineDatabase.MedicineManager.Views;
using System.Globalization;

namespace MedicineDatabase
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("cs-CS");
            ApplicationConfiguration.Initialize();
            MedicineManagerController controller = new MedicineManagerController();

            Application.Run(new MedicineManagerForm(controller));
        }
    }
}