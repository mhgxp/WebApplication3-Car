using System;

namespace Car.DTO
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime CustomerBirthday { get; set; }
        public string CustomerAddress { get; set; }
        public long CustomerPhoneNumber { get; set; }
    }
}
