using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using pycFinalApi.Base;

using pycFinalApi.Base.Enum;
using pycFinalApi.Data.Model;

namespace pycFinalApi.Dto
{
    public class ProductDto
    {
        [Required]
        [MaxLength(100)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }


        [Required]
        [MaxLength(500)]
        [Display(Name = "Description")]
        public  string Description { get; set; }


        [Required]
        public  int Price { get; set; }


        [Required]
        public string Color { get; set; }

        [Required]
        public string Brand { get; set; }


        [Required]
        public  bool IsOfferable { get; set; }
        
        [Required]
        public  bool IsSold { get; set; }

        public int CategoryId { get; set; }

        public int UserId { get; set; }

    }
}
