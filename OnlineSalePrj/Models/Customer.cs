using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSalePrj.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string LoginUser { get; set; }
        [Required]
        public double PhoneNo { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public string Address { get; set; }
        public ICollection<Order> Orders { get; set; }
        
    }
}
