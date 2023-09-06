using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader.Services
{
    internal interface IConverterService
    {
        void ConvertPdfToDocx(string[] files, string destinationFolder);
    }
}
