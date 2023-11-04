using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30_09
{
    internal interface IDrivable
    {
        void Drive();
    }
    internal interface IFlyable:IDrivable
    {
        void Fly();
    }
}
