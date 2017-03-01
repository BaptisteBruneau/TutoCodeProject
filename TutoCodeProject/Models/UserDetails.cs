using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TutoCodeProject.Models
{
    public class UserDetails
    {
        [StringLength(7, MinimumLength=2, ErrorMessage="Le login doit avoir entre 2 et 7 carractères")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}