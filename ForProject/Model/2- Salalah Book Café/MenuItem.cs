using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForProject.Model._2__Salalah_Book_Café
{
    public class MenuItem
    {
        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public string PrinInfo()
        {
            return $"Drik: {Name}, Price: {Price} OMR";
        }
    }
}
