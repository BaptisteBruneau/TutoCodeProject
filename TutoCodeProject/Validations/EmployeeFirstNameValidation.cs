using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TutoCodeProject.Validations
{
    public class EmployeeFirstNameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Ce champ est obligatoire");
            else
            {
                if(value.Equals("Baptiste"))
                    return new ValidationResult("Tu ne peux pas porter le nom de Dieu");
            }
            return ValidationResult.Success;
        }
    }
}