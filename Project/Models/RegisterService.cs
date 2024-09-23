using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class RegisterService
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }


        [Compare("Password", ErrorMessage = "Passwords don't match")]
        public string? ConfirmPassword { get; set; }

        public string? Address { get; set; }
    }
}
