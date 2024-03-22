using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NU_Society_Link.Models
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private bool isadmin;    

        public User(int id, string username, string password,bool isadmin)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.isadmin = isadmin;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public bool isAdmin { get => isadmin; set => isadmin = value; }

    }
}
