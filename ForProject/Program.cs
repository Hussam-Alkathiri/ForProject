using ForProject.Model._2__Salalah_Book_Café;
using ForProject.Model.Salalah_Delivery_Express;

namespace ForProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            DeliverySystem system = new DeliverySystem();

            Customer c1= new Customer("Hussam Al-Kathiri","Salalah");
            Customer c2 = new Customer("Fahad", "Salalah");

            Driver d1 = new Driver("Omar", "94355582");
            Driver d2 = new Driver("Ahmed", "97797066");

            system.AddDelivery(c1, d1, Status.Pending);
            system.AddDelivery(c2, d2, Status.OnTheWay);

            

            Console.WriteLine("\n---- All Delivers ----");
            system.ShowAllDeliveries();


            Console.WriteLine("\n--||-------||--------(( Project 2 ))--------||-------||--\n");

            CafeSystem cafe = new CafeSystem();

            
            cafe.AddMenuItem(new MenuItem("Espresso", 1.5));
            cafe.AddMenuItem(new MenuItem("Latte", 2.0));

            
            cafe.AddBook(new Book("The Alchemist", "Paulo Coelho", BookStatus.Available));
            cafe.AddBook(new Book("Atomic Habits", "James Clear", BookStatus.Borrowed));

            
            Customers C1 = new Customers("Hussam");
            cafe.AddCustomer(C1);


            C1.OrderDrink(cafe.Menu[0]);
            C1.OrderDrink(cafe.Menu[1]);


            C1.BorrowBook(cafe.Books[0]);
            C1.BorrowBook(cafe.Books[1]);

            
            cafe.ShowAllMenu();
            cafe.ShowAllBooks();
            cafe.ShowAllCustomers();


            C1.ReturnBooks();
            Console.WriteLine("\nAfter returning books:");
            cafe.ShowAllBooks();
        }
    }
    
}
