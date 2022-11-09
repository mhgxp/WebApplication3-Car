using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car.Entity
{
    [Table("Customer")]
    public class Customer : BaseEntity
    {
        
        public string CustomerName { get; set; }
        public DateTime CustomerBirthday { get; set; }
        public string CustomerAddress { get; set; }
        public long CustomerPhoneNumber { get; set; }
        public string Secret { get; set; }
        [ForeignKey(nameof(Car))]
        public int CarId { get; set; }
        public int? Car { get; set; }
        public virtual ICollection<Bill> Bills
        {
            get;
            set;
        }
    }
}
