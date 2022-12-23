
using Car.DTO;
using Car.Entity;
using Car.Migrations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Car.Services
{
    public interface IEmployeeService
    {
        List<EmployeeDTO> GetAll();
        void Add(Employee employee);
        EmployeeDTO GetDetail(long Id);
        void Update(int Id, Employee employee);
        //get model
        //truyen employee
        void Delete(int Id);
        bool EmployeeExists(int Id);
    }
}
