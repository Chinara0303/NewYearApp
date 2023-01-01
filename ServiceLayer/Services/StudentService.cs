
using DomainLayer.Models;
using ServiceLayer.Helpers.Constants;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services
{
    public class StudentService:IStudentService 
    {
        public int GetStudentAvgAge()
        {
            int result = 0;
            foreach (Student student in GetStudents())
                result += student.Age;
            return result/GetStudents().Length;
        }

        public int GetStudentCount()
        {
            int count = 0;
            foreach (Student student in GetStudents())
                count++;
            return count;
        }

        public Student[] GetStudentsEmailByFiltered(string letter)
        {
            Student[] students = GetStudents();
            Student[] res = new Student[students.Length];
            int count = 0;
            bool checkEmailExist = false;
            foreach (Student student in students)
            {
                if (student.Email.ToLower().ToString().StartsWith(letter.ToLower()))
                {
                    res[count]=student;
                    count++;
                    checkEmailExist = true;
                }
            }
            return res;
        }
       
        private Student[] GetStudents()
        {
            Student stu1 = new Student()
            {
                Id=1,
                Name="Chinara",
                Surname="Ibadova",
                Age=22,
                Education="Bachelor",
                Address="Goychay",
                Email="chinaraei@code.edu.az"
            };
            Student stu2 = new Student()
            {
                Id = 2,
                Name = "Konul",
                Surname = "Ibrahimova",
                Age = 26,
                Education = "Bachelor",
                Address = "Sebail",
                Email = "ckonulsi@code.edu.az"
            };
            Student stu3 = new Student()
            {
                Id = 3,
                Name = "Shaiq",
                Surname = "Kazimov",
                Age = 25,
                Education = "Bachelor",
                Address = "7ci MK",
                Email = "shaigak@code.edu.az"
            };
            Student stu4 = new Student()
            {
                Id = 4,
                Name = "Gunel",
                Surname = "Movruzova",
                Age = 23,
                Education = "Bachelor",
                Address = "28 may",
                Email = "gunel@code.edu.az"
            };
            Student stu5 = new Student()
            {
                Id = 5,
                Name = "Farah",
                Surname = "Ibrahimova",
                Age = 26,
                Education = "Bachelor",
                Address = "Genclik",
                Email = "farah@code.edu.az"
            };

            Student[] students = { stu1, stu2, stu3, stu4, stu5 };
            return students;
        }
    }
}
