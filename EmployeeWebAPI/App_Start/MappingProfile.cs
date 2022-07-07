using AutoMapper;
using EmployeeWebAPI.Dtos;
using EmployeeWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebAPI.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            Mapper.CreateMap<Employee, EmployeeReadDto>();
        }


    }
}