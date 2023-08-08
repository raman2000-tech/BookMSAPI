using System;
using BooksApi.Models;

namespace BooksApi.Data
{
    public class BooksData
    {
        public static List<Book> booksData = new List<Book>(){
            new Book(){
                id = 0,
                name = "The Alchemist",
                author = "Paulo Coelho",
                description = "This is a book about following your dreams"
            },
            new Book(){
                id = 1,
                name = "The Alchemist",
                author = "Paulo Coelho",
                description = "This is a book about following your dreams"
            },
            new Book(){
                id = 2,
                name = "The Alchemist",
                author = "Paulo Coelho",
                description = "This is a book about following your dreams"
            },
            new Book(){
                id = 3,
                name = "The Alchemist",
                author = "Paulo Coelho",
                description = "This is a book about following your dreams"
            },
        };
    }
}


