using System;
namespace BooksApi.Models
{
    public class Book
    {

        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string? description { get; set; }


    }

    public class PostBookRequestModel
    {
        public string name { get; set; }
        public string author { get; set; }
        public string description { get; set; }
    }

    public class UpdateBookRequestModel
    {
        public string? name { get; set; }
        public string? author { get; set; }
        public string? description { get; set; }
    }
}

