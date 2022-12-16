using Car.Controllers;
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
        public EmployeeService(IRepository<Employee> employee) 
        {
            this.repoEmployee = employee;
        }
        public List<Employee> GetAll()
        {
            return repoEmployee.GetAll().ToList();
        }
        public void Add(Employee employee)
        {
            repoEmployee.Add(employee);
        }
        public Employee GetDetail(long id)
        {
            return repoEmployee.GetDetail(id);
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
