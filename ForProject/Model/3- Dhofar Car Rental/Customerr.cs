using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForProject.Model._3__Dhofar_Car_Rental
{
    public class Customerr
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public void ShowDetail()
        {
            Console.WriteLine($"ID:{Id}\nName:{Name}\nPhone Number:{PhoneNumber}");
        }
    }
}
