using DomainLayer.Models;


namespace ServiceLayer.Services.Interfaces
{
    public interface IStudentService
    {
        int GetStudentCount();
        int GetStudentAvgAge();
        Student[] GetStudentsEmailByFiltered(string letter);
    }
}
