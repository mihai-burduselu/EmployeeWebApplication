using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebApplication
{
        public class EmployeeRepository : IEmployeeRepository
        {
            public EmployeeContext EmployeeContext { get; set; }
            public EmployeeRepository()
            {
                EmployeeContext = new EmployeeContext();
            }
            public void Add(Employee newEmployee)
            {
                EmployeeContext.Employees.Add(newEmployee);
                EmployeeContext.SaveChanges();
            }

            public Employee GetById(int id)
            {
                return EmployeeContext.Employees.FirstOrDefault(e => e.EmployeeID == id);
            }
            public Employee GetByFirstName(string firstname)
            {
                return EmployeeContext.Employees.FirstOrDefault(e => e.FirstName == firstname);
            }
            public List<Employee> GetAll()
            {
                return EmployeeContext.Employees.ToList();
            }
           public void Update(Employee newEmployee)
           {
                Employee employeeToUpdate = EmployeeContext.Employees.FirstOrDefault(e => e.FirstName == newEmployee.FirstName);
                if (employeeToUpdate != null)
                    employeeToUpdate.UpdateEmployee(newEmployee);
                EmployeeContext.SaveChanges();
           }
            public void Delete(Employee employee)
            {
                Employee employeeToDelete = EmployeeContext.Employees.FirstOrDefault(e => e.FirstName == employee.FirstName);
                if (employeeToDelete != null)
                    EmployeeContext.Employees.Remove(employeeToDelete);
                EmployeeContext.SaveChanges();            
            }
    }
}