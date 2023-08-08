using System;
namespace BooksApi.Models
{
    public class User
    {

        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public bool loggedIn { get; set; }

        public User()
        {
        }
    }
}

