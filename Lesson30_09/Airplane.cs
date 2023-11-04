using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30_09
{
    internal class Airplane : Transport,IFlyable
    {
        public Airplane(string model) : base(model)
        {
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("Flying...."); ;
        }

        public override void Move()
        {
            Console.WriteLine("I am moving...Airplane");
        }
    }
}
