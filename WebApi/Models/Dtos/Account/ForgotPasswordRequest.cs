﻿using System.ComponentModel.DataAnnotations;

namespace Models.Dtos.Account
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
