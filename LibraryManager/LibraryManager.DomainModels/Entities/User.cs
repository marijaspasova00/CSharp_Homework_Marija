using LibraryManager.DomainModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.DomainModels.Entities
{
    public class User : BaseEntity
    {
        public User(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
