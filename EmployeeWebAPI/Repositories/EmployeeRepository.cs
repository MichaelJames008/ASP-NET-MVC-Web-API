using EmployeeWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeWebAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {

        protected readonly DbContext _context;

        public EmployeeRepository(DbContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _context.Set<Employee>().ToList();
        }
    }
}