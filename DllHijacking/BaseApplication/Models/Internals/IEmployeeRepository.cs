using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApplication.Models.Internals
{
    public interface IEmployeeRepository
    {
        public Employee GetEmployee(string name);
        public bool RemoveEmployee(string name);
        public ICollection<Employee> GetAllEmployees();
    }
}
