using FunWithValidation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunWithValidation.Models
{
    public class Foo
    {
        [Required]
        [Remote("IsUniqueUsername", "Validation", ErrorMessage = "This username is already in use.")]
        public string Username { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Needs to be between 4 and 10 characters.")]
        public string Password { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Needs to be equal to Password.")]
        public string PasswordConfirmation { get; set; }

        [Required]
        [MustContain("@foouniversity.edu", ErrorMessage = "Only \"@foouniversity.edu\" email addresses are allowed.")]
        public string EmailAddress { get; set; }
        
        [MustBeTrue(ErrorMessage = "The terms need to be accepted.")]
        public bool AcceptTerms { get; set; }
    }
}