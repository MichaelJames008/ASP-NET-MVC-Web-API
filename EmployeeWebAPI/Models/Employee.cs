using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeWebAPI.Models
{
    public class Employee : IEmployee
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }

    }
}