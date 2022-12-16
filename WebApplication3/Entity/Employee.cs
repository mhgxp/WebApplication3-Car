using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car.Entity
{
    [Table("Employee")]
    public class Employee : BaseEntity
    {
        
        public string EmployeeName { get; set; }
        public DateTime EmployeeBirthday { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string Secret { get; set; }
        public virtual ICollection<Bill> Bills
        {
            get;
            set;
        }
    }
}
