using System;

namespace book_club.Models
{
    
    // 'book' class

    public class Book
    {
        public string title;
        public string author;

        public void DisplayBook()
        {
            Console.WriteLine($"'{title}', by {author}");
        }

    }

}