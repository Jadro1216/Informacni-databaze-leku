using SautinSoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader.Services
{
    internal class ConverterService : IConverterService
    {
        
        public ConverterService() 
        { 
            
        }

        public void ConvertPdfToDocx(string[] files, string destinationFolder)
        {
            try
            {

                int numThreads = 8;
                int filesPerThread = files.Length / numThreads;

                List<Task> tasks = new List<Task>();
                List<Thread> threads = new List<Thread>();

                for (int i = 0; i < numThreads; i++)
                {
                    int startIndex = i * filesPerThread;
                    int endIndex = (i == numThreads - 1) ? files.Length : (startIndex + filesPerThread);

                    var t = new Thread(() =>
                    {
                        PdfFocus pdfFocus = new PdfFocus();

                        for (int j = startIndex; j < endIndex; j++)
                        {
                            string file = files[j];
                            string fileName = Path.GetFileName(file);
                            if (Path.GetExtension(file).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                            {
                                pdfFocus.OpenPdf(file);
                                if (pdfFocus.PageCount > 0)
                                {
                                    string newFileName = fileName.Split('.')[0] + ".docx";
                                    string newDestinationFilePath = Path.Combine(destinationFolder, newFileName);

                                    pdfFocus.WordOptions.Format = PdfFocus.CWordOptions.eWordDocument.Docx;
                                    pdfFocus.ToWord(newDestinationFilePath);
                                }
                            }
                            else
                            {
                                string destinationFilePath = Path.Combine(destinationFolder, fileName);
                                File.Copy(file, destinationFilePath, true);
                            }
                        }
                    });
                    t.Start();
                    threads.Add(t);
                }
                foreach (var thread in threads)
                {
                    thread.Join();
                }
                Console.WriteLine("Done!");
                //Task.WaitAll(tasks.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Converting files to DOCX failed: {ex.Message}");
                throw ex;
            }
        }
    }
}
