using System;

namespace StrategyPattern
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running strategy pattern!");
            var mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();
            mallard.Display();
            Console.WriteLine();

            var model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
            
        }
    }
}
