using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FW.Web.UI.Models
{
    public class FirstNameValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Please enter firstname");
            }
            else
            {
                if(value.ToString().Contains("@"))
                {
                    return new ValidationResult("Firstname should not contain @ symbol");
                }

                if (value.ToString().Length > 50)
                {
                    return new ValidationResult("Firstname should not exceed 50 characters");
                }
            }
            
            return base.IsValid(value, validationContext);
        }         
    }
}