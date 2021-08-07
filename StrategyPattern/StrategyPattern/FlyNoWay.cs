using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace StrategyPattern
{
    internal class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            WriteLine("I can't fly");
        }
    }
}
