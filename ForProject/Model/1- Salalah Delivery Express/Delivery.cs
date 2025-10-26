using System;

namespace ForProject.Model.Salalah_Delivery_Express
{
    public class Delivery
    {
        public Customer Customer { get; set; }
        public Driver Driver { get; set; }
        public Status Status { get; set; }

        public Delivery(Customer customer, Driver driver, Status status)
        {
            Customer = customer;
            Driver = driver;
            Status = status;
        }

        public override string ToString()
        {
            return $"Customer: {Customer.Name}, Driver: {Driver.DriverName}, Status: {Status}";
        }
    }
}
