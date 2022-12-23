using AutoMapper;
using Car.Controllers;
using Car.DTO;
using Car.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IRepository<Employee> repoEmployee;
        private IMapper mapper;
        
        public EmployeeService(IRepository<Employee> employee, IMapper mapper) 
        {
            this.repoEmployee = employee;
            this.mapper = mapper;
        }
        public List<EmployeeDTO> GetAll()
        {
            var employees = repoEmployee.GetAll().Select(d => new EmployeeDTO()
            {
            Id = d.Id,
            EmployeeName = d.EmployeeName,
            EmployeeBirthday = d.EmployeeBirthday,
            EmployeeAddress = d.EmployeeAddress,
            EmployeePhoneNumber = d.EmployeePhoneNumber,
            }).ToList();
            return employees; 
        }
        public void Add(Employee employee)
        {
            repoEmployee.Add(employee);
        }
        public EmployeeDTO GetDetail(long id)
        {
           var employee = repoEmployee.GetDetail(id);
            EmployeeDTO response = mapper.Map<EmployeeDTO>(employee);
            return response;
           
        }
        public void Update(int id, Employee employee)
        {
            // get ra 1 employee
            var oldEmployee = repoEmployee.GetDetail(id);
            if (oldEmployee != null)
            {
                oldEmployee.EmployeeName = employee.EmployeeName;
                oldEmployee.EmployeeBirthday = employee.EmployeeBirthday;
                oldEmployee.EmployeeAddress = employee.EmployeeAddress;
                oldEmployee.EmployeePhoneNumber = employee.EmployeePhoneNumber;
                oldEmployee.Secret = employee.Secret;
            }
            //update employee từ input (Employee employee), ko có output (output là void)
            repoEmployee.Update(employee);
        }
        public void Delete(int id)
        {
            //get employee
            //truyen employee vo repo.delete
            var employee = repoEmployee.GetDetail(id);
            if (employee != null)
            {
                repoEmployee.Delete(employee);
            }         
        }
        public bool EmployeeExists(int id)
        {
            return repoEmployee.Exists(id);
        }
    }
}
