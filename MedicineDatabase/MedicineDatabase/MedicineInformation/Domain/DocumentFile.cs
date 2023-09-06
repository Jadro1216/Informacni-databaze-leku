using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineDatabase.MedicineInformation.Domain
{
    /// <summary>
    /// This class represents DocumentFile object with appropriate properties
    /// </summary>
    public class DocumentFile
    {
        public string? FileName { get; set; }
        public string? FileType { get; set; }
        public string? Size { get; set; }
        public byte[]? FileContent { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
