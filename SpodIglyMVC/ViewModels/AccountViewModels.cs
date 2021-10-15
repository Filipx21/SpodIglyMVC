using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpodIglyMVC.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Musisz wprowadzić email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Musisz wprowadzic hasło.")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}