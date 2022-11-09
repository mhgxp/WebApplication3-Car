using CarApi.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car.Entity
{
    [Table("CarInfo")]
    public class CarInfo : BaseEntity
    {
        
        public string CarName { get; set; }
        public string VIN { get; set; }
        public char CarAbout { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public string ImportDate { get; set; }
        public string Secret { get; set; }
        public CarItem CarItem { get; set; }
    }
}
