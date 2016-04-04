using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWebApplication
{
    public interface IEmployeeRepository
    {
        void Add(Employee newEmployee);
        Employee GetById(int id);
        List<Employee> GetAll();
        Employee GetByFirstName(string firstname);
        void Update(Employee employee);
        void Delete(Employee employee);
    }
}
