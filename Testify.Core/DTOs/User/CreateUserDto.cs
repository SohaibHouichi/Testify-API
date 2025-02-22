﻿using System.ComponentModel.DataAnnotations;

namespace Testify.Core.DTOs.User
{
    public class CreateUserDto
    {
        [Required]
        public string Username { get; set; } = null!;

        [Required]
        [MinLength(8)]
        public string Password { get; set; } = null!;

        [Required]
        public string FullName { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        public string Role { get; set; } = null!;
    }
}
