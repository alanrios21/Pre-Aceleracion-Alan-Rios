using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge_Backend_API.Entities
{
    public class User 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte [] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}
