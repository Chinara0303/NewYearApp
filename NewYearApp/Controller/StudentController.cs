using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearApp.Controller
{
    public class StudentController
    {
        private readonly IStudentService _service;
        public StudentController() => _service = new StudentService();
        public void GetStudentCount() => Console.WriteLine($"Student`s count-{_service.GetStudentCount()}");
        public void GetStudentAvgAge() => Console.WriteLine($"Student`s age average-{_service.GetStudentAvgAge()}");
        public void GetStudentsEmailByFiltered()
        {
            Console.WriteLine("Enter a letter");
            string letter = Console.ReadLine();
            var result = _service.GetStudentsEmailByFiltered(letter);
            foreach (var item in result)
            {
                if (item!=null)
                {
                    Console.WriteLine($"{item.Name} {item.Surname} {item.Email}");
                }
            }
        }
    }
}
