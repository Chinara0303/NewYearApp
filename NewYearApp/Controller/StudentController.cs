using DomainLayer.Models;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System.Diagnostics.Metrics;
using System.Net;

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
                    Console.WriteLine($"{item.Id} Fullname: {item.Name} {item.Surname} Email: {item.Email} Address:{item.Address} ");
                }
            }
        }
        public void GetStudentsAddressByFiltered()
        {
            Console.WriteLine("Enter a any address");
            string address = Console.ReadLine();
            Student[] result = _service.GetStudentsAddressByFiltered(address);
            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"Id: {item.Id} Fullname: {item.Name} {item.Surname} Email: {item.Email} Address: {item.Address}");
                }
            }
        }
        public void SearchWithNameandSurname()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter surname");
            string surname= Console.ReadLine();
            Student[] result = _service.SearchWithNameandSurname(name,surname);
            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"Id: {item.Id} Fullname: {item.Name} {item.Surname} Email: {item.Email} Address: {item.Address}");
                }
            }
        }
        public void SearchWithStr()
        {
            Console.WriteLine("Enter str");
            string str = Console.ReadLine();
           
            Student[] result = _service.SearchWithStr(str);
            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"Id: {item.Id} Fullname: {item.Name} {item.Surname}");
                }
            }
        }
        public void GetSameNameStudents()
        {
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();

            Console.WriteLine($"{_service.GetSameNameStudents(name)}");
        }
    }
}
