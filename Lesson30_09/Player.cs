using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30_09
{
    internal class Player
    {
        public required int Id { get; init; }
        public Player(string n)
        {
            Name = n;
        }
        public string? Name { get; set; }

        public void Drive(Transport obj)
        {
            Console.WriteLine($"Start....{Name}:");
            obj?.Move();
        }

        public void Air(IFlyable obj)
        {
            obj.Fly();
        }
       
    }
}
