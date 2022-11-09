using CarApi.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car.Entity
{
    [Table("Bill")]
    public class Bill : BaseEntity
    {
        
        public string Price { get; set; }
        public DateTime BuyDate { get; set; }
        public string Secret { get; set; }
        [ForeignKey(nameof(Car))]
        public int CarId { get; set; }
        public int? Car { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public int? Customer { get; set; }
        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        public int? Employee { get; set; }
    }
}
