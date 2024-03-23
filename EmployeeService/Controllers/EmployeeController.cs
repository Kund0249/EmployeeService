using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeService.Models;

namespace EmployeeService.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly EmployeeRepository repository;

        public EmployeeController()
        {
            repository = new EmployeeRepository();
        }
        //public IEnumerable<EmployeeDTO> Get()
        //{
        //    return repository.GetEmployees;
        //}

        public HttpResponseMessage Get()
        {
            var data = repository.GetEmployees;
            return Request.CreateResponse(HttpStatusCode.OK, new { Data = data });
            //return repository.GetEmployees;
        }
    }
}
