using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForProject.Model._2__Salalah_Book_Café
{
    public class Customers
    {
        public Customers(string name)
        {
            Name = name;
            OrderedDrinks = new List<MenuItem>();
            BorrowedBooks = new List<Book>();
        }

        public string Name { get; set; }
        public List<MenuItem> OrderedDrinks { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public void OrderDrink(MenuItem item)
        {
            OrderedDrinks.Add(item);
            Console.WriteLine($"{Name} Ordered: {item.Name}");
        }
        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count >=2)
            {
                Console.WriteLine($"{Name} Can Not Borrow More Than 2 Books");
                return;
            }
            if (book.Status == BookStatus.Available)
            {
                book.BorrowBook();
                BorrowedBooks.Add(book);
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available");
            }
        }
        public void ReturnBooks()
        {
            foreach (var book in BorrowedBooks)
            {
                book.ReturnBook();
            }
            BorrowedBooks.Clear();
        }
        public string PrintInfo()
        {
            return $"Customer: {Name}\n" +
                $"Drinks Ordered: {OrderedDrinks.Count}\n" +
                $"Books Borrowed: {BorrowedBooks.Count}";
        }
    }
}
