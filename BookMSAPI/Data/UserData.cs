using System;
using BooksApi.Models;

namespace BooksApi.Data
{
    public class UserData
    {
        List<User> usersData = new List<User>(){
            new User(){
                id = 0,
                name = "Chandan",
                email = "chandangadhavi11@gmail.com",
                loggedIn = false
            },
            new User(){
                id = 0,
                name = "Harsh",
                email = "harshgadhavi11@gmail.com",
                loggedIn = false
            }
        };
    }
}

