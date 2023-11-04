using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30_09
{
    internal class Bike:Transport
    {
        public Bike(string m) : base(m)
        {
            Console.WriteLine("I am construct Bike....");
        }
        public override string ToString()
        {
            return $"Model: {Model}";
        }

        public override void Move()
        {
            Console.WriteLine("I am moving...Bike");
        }
    }
}
