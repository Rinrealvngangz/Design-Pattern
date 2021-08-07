using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace StrategyPattern
{
    internal class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            WriteLine("I'm flying!");
        }
    }
}
