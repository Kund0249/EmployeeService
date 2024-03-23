using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeService.Models
{
    public class EmployeeRepository
    {
        public List<EmployeeDTO> GetEmployees
        {
            get
            {
                return new List<EmployeeDTO>()
                {
                    new EmployeeDTO(){EmployeeId=1,EmployeeName="A"},
                    new EmployeeDTO(){EmployeeId=2,EmployeeName="B"},
                    new EmployeeDTO(){EmployeeId=3,EmployeeName="C"},
                    new EmployeeDTO(){EmployeeId=4,EmployeeName="D"},
                };
            }
        }
    }
}