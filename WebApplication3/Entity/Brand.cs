using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car.Entity
{
    [Table("Brand")]
    public class Brand : BaseEntity
    {
    
        public string BrandName { get; set; }
        public string BrandAddress { get; set; }
        public char BrandAbout { get; set; }
        public string Secret { get; set; }
        [ForeignKey(nameof(Car))]
        public int CarId { get; set; }
        public int? Car { get; set; }
        public virtual ICollection<CarInfo> CarInfos
        {
            get;
            set;
        }
    }
}
