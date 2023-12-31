﻿using System.ComponentModel.DataAnnotations;

namespace Tpback1.Models.Dtos
{
    public class AuthenticationRequestBody
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
