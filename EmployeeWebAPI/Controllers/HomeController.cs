using EmployeeWebAPI.Models;
using EmployeeWebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeWebAPI.Repositories;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Configuration;

namespace EmployeeWebAPI.Controllers
{
    public class HomeController : Controller
    {

        string Baseurl = ConfigurationManager.AppSettings["APIBaseURL"].ToString();

        public async Task<List<Employee>> GetEmployeesFromAPIAsync()
        {
            //using API

            var employees = new List<Employee>();

            using (var client = new HttpClient())
            {
                //Passing service base url
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                HttpResponseMessage Res = await client.GetAsync("api/employees");
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api
                    var employeesapi = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list

                    //EmpInfo = JsonConvert.DeserializeObject<Bodies>(EmpResponse);
                    employees = JsonConvert.DeserializeObject<IEnumerable<Employee>>(employeesapi).ToList();
                }

            }

            return employees;
        }
        public async Task<ActionResult> Index()
        {

            //using List
            //var employees = new List<Employee>
            //{
            //    new Employee { Name = "Ruel Ebba", Age = 12, Id = 1, NickName = "Ruel"},
            //    new Employee { Name = "Rahul Katta", Age = 30, Id = 2, NickName = "Rah"},
            //    new Employee { Name = "Rachel Rodriquez", Age = 22, Id = 3, NickName = "Raqz"},
            //    new Employee { Name = "Michael James", Age = 35, Id = 4, NickName = "MJ"}

            //};


            // Get Employee From Repo

            //var emprepo = new EmployeeRepository(new EmployeeDB());
            //var employees = emprepo.GetAll();


            var employees = await GetEmployeesFromAPIAsync();

            var EmployeeVM = new EmployeeViewModel
            {
                Employees = (IEnumerable<Employee>)employees
            };
           


            return View(EmployeeVM);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}