using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    public class EmployeeAsset
    {
        public int AssetId { get; set; }

        public int EmployeeId { get; set; }

        public int AssetTypeId { get; set; }

        public string AssetCode { get; set; } = string.Empty;

        public DateTime IssuedDate { get; set; }

        public DateTime? ReturnedDate { get; set; }

        public string Status { get; set; } = string.Empty;
    }
}
