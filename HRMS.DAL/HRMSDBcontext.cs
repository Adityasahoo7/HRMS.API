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

        public DbSet<ModelName> tablename { get;set }

    }
}
