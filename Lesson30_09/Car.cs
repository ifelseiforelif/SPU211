using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30_09
{
    internal class Car:Transport
    {
        public Car(string m):base(m)
        {
            Console.WriteLine("I am construct Car....");
        }
        public override string ToString()
        {
            return $"Model: {Model}";
        }

        public override void Move()
        {
            Console.WriteLine("I am moving...Car");
        }
    }
}
