using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.AbtractFactories;
using FactoryPattern.AbtractFactories.Abtractions;
using FactoryPattern.FactoryMethods.Abstractions;
using FactoryPattern.Product.Pizzas;

namespace FactoryPattern.FactoryMethods
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory) { Name = "Chicago Style Cheese Pizza" };
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory) { Name = "Chicago Style Veggie Pizza" };
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory) { Name = "Chicago Style Clam Pizza" };
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory) { Name = "Chicago Style Pepperoni Pizza" };
                    break;
            }

            return pizza;
        }
    }
}
