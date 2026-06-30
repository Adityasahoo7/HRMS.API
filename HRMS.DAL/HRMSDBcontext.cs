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

        public DbSet<Employee> Employee { get; set; }
        public DbSet<BaseEntity> BaseEntity { get; set; }
        //Auth Module
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

    }
}
