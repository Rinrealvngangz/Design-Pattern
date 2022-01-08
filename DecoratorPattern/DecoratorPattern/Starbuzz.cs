
using System;

namespace DecoratorPattern
{
    class Starbuzz 
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} {beverage.cost()}");

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            beverage2 = new Soy(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} {beverage2.cost()}");

            Console.ReadLine();
        }
    }
}