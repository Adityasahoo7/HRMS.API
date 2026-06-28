using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    public class EmployeeContactInfo
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public string MobileNo { get; set; } = string.Empty;

        public string AlternateMobileNo { get; set; } = string.Empty;

        public string LandlineNo { get; set; } = string.Empty;

        public string CurrentAddress { get; set; } = string.Empty;

        public string CurrentState { get; set; } = string.Empty;

        public string CurrentCity { get; set; } = string.Empty;

        public string CurrentCountry { get; set; } = string.Empty;

        public string CurrentPincode { get; set; } = string.Empty;

        public string PermanentAddress { get; set; } = string.Empty;

        public string EmergencyContactName { get; set; } = string.Empty;

        public string EmergencyContactRelation { get; set; } = string.Empty;

        public string EmergencyContactMobile { get; set; } = string.Empty;
    }
}
