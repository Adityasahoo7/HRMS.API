using HRMS.DAL.Models;
using HRMS.DAL.Models.AUTH_MODULE;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DAL
{
    public class HRMSDBcontext:DbContext
    {
        public HRMSDBcontext(DbContextOptions<HRMSDBcontext> option):base(option)
        {
                
        }

     
        public DbSet<BaseEntity> BaseEntity { get; set; }
        //Auth Module
        public DbSet<RefreshToken> RefreshTokenDS { get; set; }
        public DbSet<Role> RoleDS { get; set; }
        public DbSet<User> UserDS { get; set; }
        public DbSet<UserRole> UserRoleDS { get; set; }


        //EMPLOYEE CORE

        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeBankDetails> EmployeeBankDetailsDS { get; set; }
        public DbSet<EmployeeContactInfo> EmployeeContactInfoDS { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducationsDS { get; set; }

        public DbSet<EmployeeEmployment> EmployeeEmploymentDS { get; set; }
        public DbSet<EmployeePersonalInfo> EmployeePersonalInfoDS { get; set; }





    }
}
