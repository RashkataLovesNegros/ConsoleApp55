using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    internal class Company
    {
        
        private List<Employee> employees;

      
        public Company()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        
        public string FindEmployeeBySalary(int salary)
        {
           
            foreach (Employee emp in employees)
            {
                if (emp.Salary == salary)
                {
                    return emp.Name;
                }
            }
            
            return "Не е намерен";
        }

    }
}
