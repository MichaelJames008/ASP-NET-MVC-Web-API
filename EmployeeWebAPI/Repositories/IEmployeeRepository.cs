using EmployeeWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebAPI.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
    }
}


