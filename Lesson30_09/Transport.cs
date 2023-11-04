using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30_09
{
    public abstract class Transport
    {
        public Transport(string model)
        {
            Model = model;
            Console.WriteLine("Construct Transport...");
        }
        public string? Model { get; set; }
        public abstract void Move();
    }
}
