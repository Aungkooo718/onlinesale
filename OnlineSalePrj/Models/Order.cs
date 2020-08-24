using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSalePrj.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime SystemDate { get; set; }
        public double TotalAmount { get; set; }
        public Order()
        {
            this.SystemDate = DateTime.Now;
        }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<PurchaseItem> PurchaseItems { get; set; }
    }
}
