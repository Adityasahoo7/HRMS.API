using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    public class EmployeeContactInfo : BaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string MobileNo { get; set; } = string.Empty;
        public string AlternateMobileNo { get; set; } = string.Empty;
        public string LandlineNo { get; set; } = string.Empty;

        // Current address — full fields
        public string CurrentAddress { get; set; } = string.Empty;
        public string CurrentCity { get; set; } = string.Empty;
        public string CurrentState { get; set; } = string.Empty;
        public string CurrentCountry { get; set; } = string.Empty;
        public string CurrentPincode { get; set; } = string.Empty;

        // Permanent address — full fields matching current
        public string PermanentAddress { get; set; } = string.Empty;
        public string PermanentCity { get; set; } = string.Empty;
        public string PermanentState { get; set; } = string.Empty;
        public string PermanentCountry { get; set; } = string.Empty;
        public string PermanentPincode { get; set; } = string.Empty;

        // Emergency contact
        public string EmergencyContactName { get; set; } = string.Empty;
        public string EmergencyContactRelation { get; set; } = string.Empty;
        public string EmergencyContactMobile { get; set; } = string.Empty;

        // Navigation
        public Employee Employee { get; set; }
    }
}
