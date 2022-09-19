using pycFinalApi.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pycFinalApi.Dto
{
   public class CategoryDto
    {
        [Required]
        [MaxLength(125)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
    }
}
