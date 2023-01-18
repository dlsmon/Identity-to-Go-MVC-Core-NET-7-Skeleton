using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth1.Models
{
    public class Client : IdentityUser
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public string? Adresse { get; set; }
        public string? Diseases { get; set; }
        public string? Hobbies { get; set; }


    }
}
