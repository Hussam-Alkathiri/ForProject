using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForProject.Model._4__Salalah_Sports_League
{
    public class Player
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Number { get; set; }

        public Player(string name, string position, int number)
        {
            Name = name;
            Position = position;
            Number = number;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"#{Number} {Name} - {Position}");
        }
    }
}
