using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWebApplication
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Employee()
        {

        }
        public void UpdateEmployee(Employee employee)
        {
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            Address = employee.Address;
            Age = employee.Age;
            Salary = employee.Salary;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}