using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pycFinalApi.Dto
{
    public class OfferDto
    {

        [Required]
        [Display(Name = "ProductId")]
        public int ProductId { get; set; }


        [Required]
        [Display(Name = "UserId")]
        public int UserId { get; set; }


        [Required]
        [Display(Name = "OfferAmount")]
        public int OfferAmount { get; set; }
    }
}
