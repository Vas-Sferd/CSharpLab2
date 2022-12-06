using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLaba2.DataModel
{
    public class User
    {
        public User() { }
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        [Key]
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
