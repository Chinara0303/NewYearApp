using DomainLayer.Models;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;

namespace NewYearApp.Controller
{
    public class StudentController
    {
        private readonly IStudentService _service;
        public StudentController() => _service = new StudentService();
        public void GetStudentCount() => Console.WriteLine($"Count of students-{_service.GetStudentCount()}");
        public void GetStudentAvgAge() => Console.WriteLine($"Average age of students-{_service.GetStudentAvgAge()}");
        public void GetStudentsEmailByFiltered()
        {
            Console.WriteLine("Enter a letter");
            string letter = Console.ReadLine();
            Student[] result = _service.GetStudentsEmailByFiltered(letter);
            foreach (var item in result)
            {
                if (item!=null)
                {
                    Console.WriteLine($"{item.Id} Fullname: {item.Name} {item.Surname} Email: {item.Email} ");
                }
            }
        }
    }
}
