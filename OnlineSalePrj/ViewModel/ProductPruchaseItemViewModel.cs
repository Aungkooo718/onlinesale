using OnlineSalePrj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSalePrj.ViewModel
{
    public class ProductPruchaseItemViewModel
    {
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public int OrdertId { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        [Required]
        public int ProductId { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public List<ProductListViewModel> ItemList { get; set; }
    }
}
