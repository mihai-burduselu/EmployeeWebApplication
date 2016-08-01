using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.SignalR;

namespace EmployeeWebApplication
{
    public class EmployeeController : ApiController
    {
        private IEmployeeRepository EmployeeRepository = new EmployeeRepository();
        [HttpGet]
        public List<Employee> Get()
        {
            return EmployeeRepository.GetAll();
        }
        [HttpGet]
        public Employee GetByFirstName(string firstname)
        {
            return EmployeeRepository.GetByFirstName(firstname);
        }
        [HttpPost]
        public void CreateEmployee(Employee employee)
        {
            EmployeeRepository.Add(employee);
            var hub = GlobalHost.ConnectionManager.GetHubContext<EmployeesHub>();
            hub.Clients.All.employeeAdded(employee);
        }
        [HttpPost]
        public void Update(Employee employee)
        {
            EmployeeRepository.Update(employee);
        }
        [HttpDelete]
        public void Delete(Employee employee)
        {
            EmployeeRepository.Delete(employee);
        }

        

    }
}