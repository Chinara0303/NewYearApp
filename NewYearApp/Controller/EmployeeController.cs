using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearApp.Controller
{
    public class EmployeeController
    {
        private readonly EmployeeService _service;
        public EmployeeController()=>_service=new EmployeeService();

        public void GetEmployeesByFiltered()
        {
            Console.WriteLine("Enter first date (yyyy,mm,dd)");
            FirstDate: string firstDateStr = Console.ReadLine();
            DateTime firstDate;
            bool IsParseFirstDate = DateTime.TryParse(firstDateStr, out firstDate);
            if (!IsParseFirstDate)
            {
                Console.WriteLine("Enter a correct date");
                goto FirstDate;
            }
            Console.WriteLine("Enter second date (yyyy,mm,dd)");
            SeconDate: string secondDateStr = Console.ReadLine();
            DateTime secondDate;
            bool IsParseSecondDate = DateTime.TryParse(secondDateStr, out secondDate);
            if (!IsParseSecondDate)
            {
                Console.WriteLine("Enter a correct date");
                goto SeconDate;
            }
            var result = _service.GetEmployeesByFiltered(firstDate, secondDate);
            foreach (var item in result)
            {
                if (item!=null)
                {
                    Console.WriteLine($"FullName: {item.Name} {item.Surname}, Employee`s birthday: {item.Birthday.ToString("MM.dd.yyyy")}, Employee`s salary: {item.Salary}");
                }
            }
        }
    }
}
