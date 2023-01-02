using DomainLayer.Models;

namespace ServiceLayer.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetEmployeesByFiltered(DateTime firstDate, DateTime secondDate);
    }
}
