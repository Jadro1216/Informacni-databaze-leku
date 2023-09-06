using DataLoader.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader.Controllers
{
    internal class ConverterController
    {
        private IConverterService _converterService;
        private string projectPath;
        private string pdfFolder;
        private string docxFolder;

        public ConverterController()
        {
            _converterService = new ConverterService();
            projectPath = Directory.GetCurrentDirectory();
            pdfFolder = Path.Combine(projectPath, "../../../data/Documents");
            docxFolder = Path.Combine(projectPath, "../../../data/DocumentsDocx");
        }

        public void ConvertPdfToDocx()
        {
            string[] files = Directory.GetFiles(pdfFolder);

            try
            {
                _converterService.ConvertPdfToDocx(files, docxFolder);
                Console.WriteLine("Converting finished.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Converting files to DOCX failed: {ex.Message}");
                throw;
            }
        }
    }
}
