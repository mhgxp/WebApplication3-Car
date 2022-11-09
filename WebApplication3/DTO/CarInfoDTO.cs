using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car.DTO
{
    public class CarInfoDTO
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string VIN { get; set; }
        public char CarAbout { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public string ImportDate { get; set; }
    }
}
