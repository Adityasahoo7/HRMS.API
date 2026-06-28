    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    public class EmployeeBankDetails : BaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string BankName { get; set; } = string.Empty;
        public string AccountNumber { get; set; } = string.Empty;
        public string IFSC { get; set; } = string.Empty;
        public string PFNumber { get; set; } = string.Empty;
        public string PreviousPFNumber { get; set; } = string.Empty;
        public string UAN { get; set; } = string.Empty;
        public string ESICNumber { get; set; } = string.Empty;

        // Navigation
        public Employee Employee { get; set; }
    }
}
