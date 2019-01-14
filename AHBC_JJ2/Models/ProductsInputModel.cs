using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AHBC_JJ2.Models
{
    public class ProductsInputModel
    {
        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        [DisplayName("Product Name:  ")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Description:  ")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Price (USD):  ")]
        public double Price { get; set; }

    }
}