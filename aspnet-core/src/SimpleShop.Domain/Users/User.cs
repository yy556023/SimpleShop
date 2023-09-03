using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleShop.Domain.Commoms;

namespace SimpleShop.Domain.Users
{
    public class User : Entity
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Birth { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsDefault { get; set; } = true;
        public bool IsDelete { get; set; } = false;
    }
}