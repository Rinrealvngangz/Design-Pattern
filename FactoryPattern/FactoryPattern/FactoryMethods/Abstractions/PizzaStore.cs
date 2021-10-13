using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Product.Pizzas;
namespace FactoryPattern.FactoryMethods.Abstractions
{
   internal abstract class PizzaStore
    {
        public Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);
            Console.WriteLine("--- Making a " + pizza.Name + " ---");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
       protected abstract Pizza createPizza(string type);
    }
}
