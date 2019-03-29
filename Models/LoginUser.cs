using System;
using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Models{
    public class LoginUser{
        [Required]
        [Display(Name = "Email")]
        public string Email2 {get; set;}
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password2 {get; set;}
    }
}