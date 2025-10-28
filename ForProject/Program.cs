using ForProject.Model._2__Salalah_Book_Café;
using ForProject.Model._3__Dhofar_Car_Rental;
using ForProject.Model._4__Salalah_Sports_League;
using ForProject.Model.Salalah_Delivery_Express;

namespace ForProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--||-------||--------(( Project 1 ))--------||-------||--\n");
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

            Console.WriteLine("\n--||-------||--------(( Project 3 ))--------||-------||--\n");
            RentalSystem System = new RentalSystem();

            System.AddCar(new Car { Id = 1, Make = "Toyota", Model = "Corolla", Price = 15 });
            System.AddCar(new Car { Id = 2, Make = "GMC", Model = "Sierra", Price = 20 });
            System.AddCar(new Car { Id = 3, Make = "Honda", Model = "Accord", Price = 25 });

            System.AddCustomer(new Customerr { Id = 1, Name = "Hussam", PhoneNumber = "94383382" });
            System.AddCustomer(new Customerr { Id = 2, Name = "Salim", PhoneNumber = "93456789" });
            Console.WriteLine("-------First test--------");
            System.ShowAvailableCars();
            Console.WriteLine("----");
            System.RentCar(1, 3, 15);
            System.ShowAvailableCars();
            System.ShowAllRentals();
            Console.WriteLine("---------Second test---------");
            System.ShowAvailableCars();
            System.RentCar(2, 2, 5);
            System.ShowAvailableCars();
            System.ShowAllRentals();
            System.ReturnCar(2);
            System.ShowAvailableCars();
            Console.WriteLine("--------Result-------");
            System.CalculateTotalRevenue();

            Console.WriteLine("\n--||-------||--------(( Project 4 ))--------||-------||--\n");

            League league = new League();

            Team teamA = new Team("Salalah Goats", "Hussam");
            teamA.AddPlayer(new Player("Ahmed", "Forward", 9));
            teamA.AddPlayer(new Player("Salim", "Midfielder", 8));

            Team teamB = new Team("Salalah Hawks", "Fahad");
            teamB.AddPlayer(new Player("Khaled", "Forward", 10));
            teamB.AddPlayer(new Player("Fayadh", "Goalkeeper", 1));

            league.AddTeam(teamA);
            league.AddTeam(teamB);

            Match match1 = new Match(teamA, teamB);
            match1.SetResult(2, 1);
            league.RecordMatch(match1);

            league.ShowAllMatches();
            league.ShowStandings();
        }
    }
}
