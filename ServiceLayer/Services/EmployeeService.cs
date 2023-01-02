using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Employee[] GetEmployeesByFiltered(DateTime firstDate, DateTime secondDate)
        {
            Employee[] employees = GetEmployees();
            Employee[] employees1=new Employee[employees.Length];
            int count = 0;
            foreach (Employee employee in employees)
            {
                if (employee.Birthday > firstDate && employee.Birthday < secondDate && employee.Salary > 2000)
                {
                    employees1[count] = employee;
                    count++;
                }
            }
            return employees1;
        }


        private Employee[] GetEmployees()
        {
            Employee emp1 = new Employee()
            {
                Name = "Chinara",
                Surname = "Ibadova",
                Birthday = new DateTime(2000, 09, 08),
                Salary = 1500
            };
            Employee emp2 = new Employee()
            {
                Name = "Afet",
                Surname = "Beydullayeva",
                Birthday = new DateTime(1966, 02, 20),
                Salary = 2500
            };
            Employee emp3 = new Employee()
            {
                Name = "Nermin",
                Surname = "Ibadova",
                Birthday = new DateTime(1999, 08, 04),
                Salary = 2100
            };
            Employee emp4 = new Employee()
            {
                Name = "Gullu",
                Surname = "Ibrahimova",
                Birthday = new DateTime(1992, 07, 29),
                Salary = 1800
            };
            Employee emp5 = new Employee()
            {
                Name = "Gulshen",
                Surname = "Ibrahimova",
                Birthday = new DateTime(1993, 07, 09),
                Salary = 1650
            };
            return new Employee[] { emp1, emp2, emp3, emp4, emp5 };
        }
    }
}
