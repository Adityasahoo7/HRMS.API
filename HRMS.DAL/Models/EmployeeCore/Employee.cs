using HRMS.DAL.Models.AUTH_MODULE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    public class Employee : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int UserId { get; set; }
        public string EmployeeCode { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string OfficialEmail { get; set; } = string.Empty;
        public string? ProfilePhoto { get; set; }
        public string? Domain { get; set; }          // from UI: "Domain"
        public string? Specialization { get; set; }  // from UI: "Specialization"
        public int StatusId { get; set; }

        // Navigation
        public User User { get; set; }
        public EmployeePersonalInfo PersonalInfo { get; set; }
        public EmployeeContactInfo ContactInfo { get; set; }
        public EmployeeEmployment Employment { get; set; }
        public EmployeeBankDetails BankDetails { get; set; }
        public ICollection<EmployeeEducation> Educations { get; set; }
        public ICollection<EmployeeDocument> Documents { get; set; }
        public ICollection<EmployeeAsset> Assets { get; set; }
    }
}
