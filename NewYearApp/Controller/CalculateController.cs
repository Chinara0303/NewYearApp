using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearApp.Controller
{
    public class CalculateController
    {
        private readonly CalculateService _service;
        public CalculateController() => _service = new CalculateService();
        
        public void Calculation()
        {
            Console.WriteLine("Enter a first number");
   Number1: string num1Str = Console.ReadLine();
            int num1;
            bool IsParseNum1=int.TryParse(num1Str, out num1);
            if (!IsParseNum1)
            {
                Console.WriteLine("Enter a valid number");
                goto Number1;
            }
            Console.WriteLine("Enter a operation");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter a second number");
   Number2: string num2Str = Console.ReadLine();
            int num2;
            bool IsParseNum2 = int.TryParse(num2Str, out num2);
            if (!IsParseNum2)
            {
                Console.WriteLine("Enter a valid number");
                goto Number2;
            }
            if (num2 == 0 && operation == "/")
            {
                Console.WriteLine("It cannot be divided by zero");
            }
            var result = _service.Calculation(num1, num2, operation);
            Console.WriteLine(result);
        }
    }
}
