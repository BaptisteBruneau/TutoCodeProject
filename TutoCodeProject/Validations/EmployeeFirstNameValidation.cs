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
                if(value.ToString().Contains("@"))
                    return new ValidationResult("FirstName ne peut pas comporter d'@");
            }
            return ValidationResult.Success;
        }
    }
}