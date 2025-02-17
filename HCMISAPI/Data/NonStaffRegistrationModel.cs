﻿using HCMISAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace HCMISAPI.Data
{
    public class NonStaffRegistrationModel
    {
        public NonStaff? NewNonStaff { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Re-Password is required")]
        public string? Repassword { get; set; }
        public string? ComfirmationUrl { get; set; }
    }
}
