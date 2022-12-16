using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car.DTO
{
    public class BillDTO
    {
        public int Id { get; set; }
        public string Price { get; set; }
        public DateTime BuyDate { get; set; }
    }
}
