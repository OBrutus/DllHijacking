using LegitClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApplication.Models.Internals
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> emplyeeRegistar;
        public EmployeeRepository()
        {
            emplyeeRegistar = new List<Employee>();
            new DataProvider();
            emplyeeRegistar.AddRange(new[] {
                new Employee() { Name = "Ram"},
                new Employee() { Name = "Shyam"},
                new Employee() { Name = "Milind"},
                new Employee() { Name = "Raj"}
            });
        }

        public ICollection<Employee> GetAllEmployees()
        {
            return emplyeeRegistar;
        }

        public Employee GetEmployee(string name)
        {
            name = name.ToLower();
            return emplyeeRegistar.FirstOrDefault<Employee>(emp => emp.Name.ToLower() == name);
        }

        public bool RemoveEmployee(string name)
        {
            return  emplyeeRegistar.RemoveAll(emp => emp.Name == name) > 0;
        }
    }
}
