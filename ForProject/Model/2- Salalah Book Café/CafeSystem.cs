using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForProject.Model._2__Salalah_Book_Café
{
    public class CafeSystem
    {
        public CafeSystem()
        {
            Menu = new List<MenuItem>();
            Books = new List<Book>();
            Customers = new List<Customers>();
        }

        public List<MenuItem> Menu { get; set; }
        public List<Book> Books { get; set; }
        public List<Customers> Customers { get; set; }

        public void AddMenuItem(MenuItem item)
        {
            Menu.Add(item);
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void AddCustomer(Customers customer)
        {
            Customers.Add(customer);
        }
        public void ShowAllMenu()
        {
            Console.WriteLine("\n---- Menu Items ----");
            foreach (var item in Menu)
                Console.WriteLine(item.PrinInfo());
        }
        public void ShowAllBooks()
        {
            Console.WriteLine("\n---- Books ----");
            foreach (var book in Books)
                Console.WriteLine(book.PrintInfo());
        }
        public void ShowAllCustomers()
        {
            Console.WriteLine("\n---- Customers ----");
            foreach (var customer in Customers)
                Console.WriteLine(customer.PrintInfo());
        }
    }
}
