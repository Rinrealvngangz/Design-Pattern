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
       internal IFlyBehavior _flyBehavior;
       internal IQuackBehavior _quackBehavior;

        public Duck()
        {

        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public abstract void Display(); 
       
        public void PerformFly()
        {
            _flyBehavior.fly();

        }

        public void PerformQuack()
        {
            _quackBehavior.quack();
        }

        public void Swim()
        {
            WriteLine("All ducks float , even decoys!");
        }


    }
}
