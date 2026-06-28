using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL.Models
{
    public class EmployeeEducation
    {
        public int EducationId { get; set; }

        public int EmployeeId { get; set; }

        public string Qualification { get; set; } = string.Empty;

        public string CollegeName { get; set; } = string.Empty;

        public string University { get; set; } = string.Empty;

        public int PassingYear { get; set; }

        public string Grade { get; set; } = string.Empty;

        public bool IsPursuing { get; set; }
    }
}
