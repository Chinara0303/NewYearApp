using DomainLayer.Models;


namespace ServiceLayer.Services.Interfaces
{
    public interface IStudentService
    {
        int GetStudentCount();
        int GetStudentAvgAge();
        Student[] GetStudentsEmailByFiltered(string letter);
        Student[] GetStudentsAddressByFiltered(string address);
        Student[] SearchWithNameandSurname(string name,string surname);
        Student[] SearchWithStr(string str);
        int GetSameNameStudents(string name);
    }
}
