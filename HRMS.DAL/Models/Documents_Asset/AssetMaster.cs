using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    public class AssetMaster
    {
        public int AssetTypeId { get; set; }

        public string AssetName { get; set; } = string.Empty;
    }
}
