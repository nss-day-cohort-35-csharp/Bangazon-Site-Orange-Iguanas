using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon.Models.ProductTypeViewModel
{
    public class ProductTypeWithProductCountViewModel
    {
        
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int ProductCount { get; set; }
        public  ICollection<Product> Products { get; set; }
    }
}
