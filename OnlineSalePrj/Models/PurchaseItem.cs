using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace OnlineSalePrj.Models
{
    public class PurchaseItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }       
        
        //public DateTime SaleDate { get; set; }
        public DateTime SystemDate { get; set; }
        public PurchaseItem()
        {
            this.SystemDate = DateTime.Now;
        }
    }
}
