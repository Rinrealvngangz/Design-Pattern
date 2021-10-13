﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryPattern.Product.Ingredients.Abstractions;
using FactoryPattern.Product.Ingredients;
using FactoryPattern.AbtractFactories.Abtractions;
namespace FactoryPattern.AbtractFactories
{
    internal class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClam CreateClam()
        {
            return new FreshClams();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}
