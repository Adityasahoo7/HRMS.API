using HRMS.DAL.Models.Documents_Asset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    public class EmployeeAsset : BaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int AssetId { get; set; }
        public string AssetCode { get; set; } = string.Empty;
        public DateTime IssuedDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public string Status { get; set; } = string.Empty;
        // "Issued", "Returned", "Lost", "Damaged"
        public string Condition { get; set; } = string.Empty;
        // "Good", "Damaged", "Lost"
        public string Remarks { get; set; } = string.Empty;
        public int? IssuedBy { get; set; }

        // Navigation
        public Employee Employee { get; set; }
        public Asset Asset { get; set; }
    }
}
