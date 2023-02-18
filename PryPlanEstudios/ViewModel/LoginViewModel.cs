using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PryPlanEstudios.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Usuario")]
        public string Correo { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}