using System;

namespace StrategyPattern
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();
        }
    }
}
