using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models.Documents_Asset
{
    public class Asset : BaseEntity
    {
        public int AssetId { get; set; }
        public string AssetName { get; set; } = string.Empty;
        // e.g. Laptop, Mobile, SIM Card, Office Keys, Pen Drive etc.
        public string AssetCode { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Navigation
        public ICollection<EmployeeAsset> EmployeeAssets { get; set; }
    }
}
