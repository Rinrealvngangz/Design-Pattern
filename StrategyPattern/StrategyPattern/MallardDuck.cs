using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace StrategyPattern
{
   internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new MuteQuack();
        }
        public override void Display()
        {
            WriteLine("I'm real Mallard duck");
        }

    }
}
