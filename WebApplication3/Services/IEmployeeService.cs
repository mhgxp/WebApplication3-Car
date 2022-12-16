
using Car.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Car.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        void Add(Employee employee);
        Employee GetDetail(long Id);
        void Update(int Id, Employee employee);
        void Delete(int Id);
        bool EmployeeExists(int Id);
    }
}
