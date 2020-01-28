using Bangazon.Models;
using Bangazon.Data;
using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models.ProductViewModels
{
  public class ProductDetailViewModel
  {
    public Product Product { get; set; }

        [Display(Name = "Left in Stock")]
        public int Inventory { get; set; }
    }
}