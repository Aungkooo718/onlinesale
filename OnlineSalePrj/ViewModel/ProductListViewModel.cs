using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSalePrj.ViewModel
{
    public class ProductListViewModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public double TotalPricePerItem { get; set; }
    }
}
