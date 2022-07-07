using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeWebAPI.Models
{
    public class EmployeeDB : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDB()
            :base("name=SQLConnection")
        {

        }

    }
}