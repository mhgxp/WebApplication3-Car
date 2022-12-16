using Car.Entity;
using System;

namespace Car.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public DateTime EmployeeBirthday { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeePhoneNumber { get; set; }
    }
}