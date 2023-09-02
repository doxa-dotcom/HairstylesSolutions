using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace HairstyleSolutions.Models
{
    public class User : IdentityUser

    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string nom { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string prenom { get; set; }
        // public string description { get; set; }
        //public string picture { get; set; }
        
        public bool isAdmin { get; set; }
    }
}
