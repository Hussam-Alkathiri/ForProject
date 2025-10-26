using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForProject.Model._2__Salalah_Book_Café
{
    public class Book
    {
        public Book(string title, string author, BookStatus status)
        {
            Title = title;
            Author = author;
            Status = status;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }

        public void BorrowBook()
        {
            if (Status == BookStatus.Available)
            {
                Status = BookStatus.Borrowed;
                Console.WriteLine($"{Title} has been borrowed");
            }
            else
            {
                Console.WriteLine($"{Title} is already borrowed");
            }
        }
        public void ReturnBook()
        {
            Status = BookStatus.Available;
            Console.WriteLine($"{Title} has been returned");
        }
        public string PrintInfo()
        {
            return $"Book: {Title}, Author: {Author}, Status: {Status}";
        }
    }
}
