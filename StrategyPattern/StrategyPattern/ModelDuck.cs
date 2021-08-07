using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace StrategyPattern
{
   internal class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Quack();
        }
        public override void Display()
        {
            WriteLine("I'm model duck");
        }
    }
}
