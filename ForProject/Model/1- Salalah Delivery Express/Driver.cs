using System;
using System.Collections.Generic;

namespace ForProject.Model.Salalah_Delivery_Express
{
    public class Driver
    {
        public string DriverName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Delivery> Deliveries { get; set; }

        public Driver(string name, string phoneNumber)
        {
            DriverName = name;
            PhoneNumber = phoneNumber;
            Deliveries = new List<Delivery>();
        }

        public void AddDelivery(Delivery delivery)
        {
            Deliveries.Add(delivery);
        }

        public void CheckDeliveredDrivers()
        {
            Console.WriteLine($"Delivered orders by: {DriverName}");
            foreach (Delivery delivery in Deliveries)
            {
                if (delivery.Status == Status.Delivered)
                    Console.WriteLine($"→ {delivery.Customer.Name}");
            }
        }

        public string PrintInfo()
        {
            return $"Name: {DriverName}\nPhone Number: {PhoneNumber}";
        }
    }
}
