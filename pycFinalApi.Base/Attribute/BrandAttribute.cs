using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pycFinalApi.Base.Attribute
{
    public class BrandAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                if (value is null)
                    return new ValidationResult("Invalid Brand Name");


                return ValidationResult.Success;
            }
            catch (Exception)
            {
                return new ValidationResult("Invalid Brand field.");
            }
        }
    }
}
