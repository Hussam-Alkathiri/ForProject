using System;
using System.Collections.Generic;

namespace ForProject.Model.Salalah_Delivery_Express
{
    public class DeliverySystem
    {
        public List<Driver> Drivers { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Delivery> Deliveries { get; set; }

        public DeliverySystem()
        {
            Drivers = new List<Driver>();
            Customers = new List<Customer>();
            Deliveries = new List<Delivery>();
        }

        // ✅ إضافة طلب جديد
        public void AddDelivery(Customer customer, Driver driver, Status status)
        {
            // إضافة السائق إذا غير موجود
            if (!Drivers.Contains(driver))
                Drivers.Add(driver);

            // إضافة العميل إذا غير موجود
            if (!Customers.Contains(customer))
                Customers.Add(customer);

            // إنشاء التوصيلة الجديدة
            Delivery delivery = new Delivery(customer, driver, status);
            Deliveries.Add(delivery);
            driver.AddDelivery(delivery);
        }

        // ✅ عرض جميع المعلومات
        public void ShowAllDeliveries()
        {
            Console.WriteLine("\n---- Drivers ----");
            foreach (Driver driver in Drivers)
            {
                Console.WriteLine(driver.PrintInfo());
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("\n---- Customers ----");
            foreach (Customer customer in Customers)
            {
                Console.WriteLine(customer.PrintInfo());
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("\n---- Deliveries ----");
            foreach (Delivery d in Deliveries)
            {
                Console.WriteLine($"Customer: {d.Customer.Name}, Driver: {d.Driver.DriverName}, Status: {d.Status}");
            }

            Console.WriteLine("\n------- End -------");
        }
    }
}
