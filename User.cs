using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProApp
{
    public class User
    {
        public Hashtable books = new Hashtable();
        public string Username { get; set; }
        public string Password { get; set; }
        public int Membership { get; set; }
        public User(string username, string password, int membership) {
            this.Username = username;
            this.Password = password;
            this.Membership = membership;
        }
    }
}
