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

        }
    }
}
