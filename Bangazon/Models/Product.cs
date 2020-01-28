using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bangazon.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get;set;}

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated {get;set;}

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(55, ErrorMessage="Please shorten the product title to 55 characters")]
        public string Title { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Range(1, 10001, ErrorMessage = "Price must be 10,000 or less ")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please Select a Product Category")]
        public int Quantity { get; set; }

        [Required]
        public string UserId {get; set;}

        public string City {get; set;}

        public string ImagePath {get; set;}
            
        public bool Active { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Display(Name="Product Category")]
        [Required (ErrorMessage="Please Select a Product Category")]
        public int ProductTypeId { get; set; }

        [Required(ErrorMessage = "Please Select a Product Category")]
        public ProductType ProductType { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public Product ()
        {
            Active = true;
        }

    }
}
