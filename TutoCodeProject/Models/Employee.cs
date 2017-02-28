using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TutoCodeProject.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [TutoCodeProject.Validations.EmployeeFirstNameValidation]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "La valeur est obligatoire")]
        [StringLength(5, ErrorMessage = "La taille maximal est de 5 caractères")]
        public string Lastname { get; set; }

        [Required]
        [Range(5000, 35000, ErrorMessage="Le salaire doit être compris entre 5000 et 35000")]
        public int? Salary { get; set; }
    }
}