using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    public class EmployeeDocument : BaseEntity
    {
        public int DocumentId { get; set; }
        public int EmployeeId { get; set; }
        public string DocumentType { get; set; } = string.Empty;
        // e.g. "Aadhar", "PAN", "Resume", "OfferLetter", "SkillCertificate"
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public long FileSize { get; set; }           // in bytes
        public bool IsVerified { get; set; } = false;
        public DateTime? ExpiryDate { get; set; }    // for passport/visa
        public DateTime UploadedDate { get; set; } = DateTime.UtcNow;
        public int? UploadedBy { get; set; }

        // Navigation
        public Employee Employee { get; set; }
    }
}
