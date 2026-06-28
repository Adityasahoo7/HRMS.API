using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    public class EmployeeEmployment
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public DateOnly DateOfJoining { get; set; }

        public string EmploymentStatus { get; set; } = string.Empty;

        public int NoticePeriod { get; set; }

        public int DepartmentId { get; set; }

        public int DesignationId { get; set; }

        public int? ManagerId { get; set; }

        public int? ReportingManagerId { get; set; }

        public int? ApprovalManagerId { get; set; }

        public int WorkLocationId { get; set; }

        public decimal Experience { get; set; }

        public decimal PreviousExperience { get; set; }

        public decimal TotalExperience { get; set; }

        public bool Billable { get; set; }

        public string BillableType { get; set; } = string.Empty;
    }
}
