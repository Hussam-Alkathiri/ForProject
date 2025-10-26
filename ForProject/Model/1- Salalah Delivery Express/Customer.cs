using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForProject.Model.Salalah_Delivery_Express
{
    public class Customer
    {
        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; set; }
        public string Address { get; set; }


        public string PrintInfo()
        {
            return $"Name: {this.Name}\n" +
                $"Address: {this.Address}";
        }
    }

}
