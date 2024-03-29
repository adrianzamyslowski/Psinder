﻿using Psinder.Core.Model;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Psinder.Web.Models.User
{
    public class UserCreateModelView
    {
        [Display(Name = "Nazwa użytkownika")]
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string UserName { get; set; }

        [Display(Name = "Hasło")]
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Powótrzone hasło")]
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Różne hasło")]

        public string ConfirmPassword { get; set; }

        [Display(Name = "Adres e-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
