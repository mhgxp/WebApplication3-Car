﻿using Car.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Timers;

namespace CarApi.Models
{
    [Table("CarItem")]
    public class CarItem : BaseEntity
    {
       
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Secret { get; set; }
        public int CarId { get; set; }
        public CarInfo CarInfo { get; set; }
    }
}
