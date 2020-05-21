using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BookInventory
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Id { get; private set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
