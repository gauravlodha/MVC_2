using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;

namespace MVC_2.Models
{
    public class EmplyeeContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}