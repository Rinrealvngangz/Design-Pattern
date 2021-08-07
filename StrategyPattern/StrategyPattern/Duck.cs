using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace StrategyPattern
{
   internal abstract class Duck
    {
       internal IFlyBehavior flyBehavior;
       internal IQuackBehavior quackBehavior;

        public Duck()
        {

        }

        public abstract void Display(); 
       
        public void PerformFly()
        {
            flyBehavior.fly();

        }

        public void PerformQuack()
        {
            quackBehavior.quack();
        }

        public void Swim()
        {
            WriteLine("All ducks float , even decoys!");
        }


    }
}
