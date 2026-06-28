using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    public class EmployeePersonalInfo : BaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Gender { get; set; } = string.Empty;
        public DateOnly? DOB { get; set; }
        public string BloodGroup { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string MotherName { get; set; } = string.Empty;
        public string PlaceOfBirth { get; set; } = string.Empty;
        public string MotherTongue { get; set; } = string.Empty;
        public string MaritalStatus { get; set; } = string.Empty;
        public string PassportNumber { get; set; } = string.Empty;
        public string AadharNumber { get; set; } = string.Empty;
        public string PanNumber { get; set; } = string.Empty;
        public string AboutMe { get; set; } = string.Empty;
        public string ReferralType { get; set; } = string.Empty;
        public string ReferralName { get; set; } = string.Empty;

        // Navigation
        public Employee Employee { get; set; }
    }
}
