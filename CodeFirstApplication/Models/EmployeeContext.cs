using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace CodeFirstApplication.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("SqlCon")
        {

        }

        public DbSet<EmployeeModel> EmployeeModeles { get; set; }
    }
}