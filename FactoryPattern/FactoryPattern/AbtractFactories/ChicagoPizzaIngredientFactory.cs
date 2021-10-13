using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.AbtractFactories.Abtractions;
using FactoryPattern.Product.Ingredients;
using FactoryPattern.Product.Ingredients.Abstractions;

namespace FactoryPattern.AbtractFactories
{
    internal class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IClam CreateClam()
        {
            return new FrozenClams();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new BlackOlives(), new Spinach(), new Eggplant() };
            return veggies;
        }
    }
}
