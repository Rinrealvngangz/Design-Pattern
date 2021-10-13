using FactoryPattern.AbtractFactories;
using FactoryPattern.AbtractFactories.Abtractions;
using FactoryPattern.FactoryMethods.Abstractions;
using FactoryPattern.Product.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.FactoryMethods
{
    internal class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory) { Name = "New York Style Cheese Pizza" };
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory) { Name = "New York Style Veggie Pizza" };
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory) { Name = "New York Style Clam Pizza" };
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory) { Name = "New York Style Pepperoni Pizza" };
                    break;
            }

            return pizza;
        }
    }
}
