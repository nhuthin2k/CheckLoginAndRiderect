using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CheckLoginAndRiderect.Models
{
    public class AccoutModel
    {
        [Required(ErrorMessage = "username is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "password is required.")]
        [DataType(DataType.Password)] 

        public string password { get; set; }

    }
}