using System.Collections.Generic;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        // Henter alle medarbejdere
        List<Employee> GetAll();

        // Tilføjer en ny medarbejder
        void Add(Employee employee);

        // Fjerner en medarbejder baseret på id
        void RemoveById(int id);

        // Henter en bestemt medarbejder 
        Employee GetById(int id);

        // Gemmer hele listen 
        void SaveAll(List<Employee> employees);
    }
}
