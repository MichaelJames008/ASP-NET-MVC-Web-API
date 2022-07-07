namespace EmployeeWebAPI.Migrations
{
    using EmployeeWebAPI.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeWebAPI.Models.EmployeeDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeWebAPI.Models.EmployeeDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Employees.AddOrUpdate(e=>e.Name,
                new Employee { Name = "Ruel Ebba", Age = 12,  NickName = "Ruel"},
                new Employee { Name = "Rahul Katta", Age = 30, NickName = "Rah" },
                new Employee { Name = "Rachel Rodriquez", Age = 22, NickName = "Raqz" },
                new Employee { Name = "Michael James", Age = 35, NickName = "MJ" }
              );
             
        }
    }
}
