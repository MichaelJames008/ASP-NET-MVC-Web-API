using AutoMapper;
using EmployeeWebAPI.Dtos;
using EmployeeWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeWebAPI.Controllers.Api
{
    public class EmployeesController : ApiController
    {
        private EmployeeDB _context;

        public EmployeesController()
        {
            _context = new EmployeeDB();
        }


        [HttpGet]
        public IEnumerable<EmployeeReadDto> GetEmployees()
        {
            return _context.Set<Employee>().ToList().Select(Mapper.Map<Employee, EmployeeReadDto>);
        }
    }
}
