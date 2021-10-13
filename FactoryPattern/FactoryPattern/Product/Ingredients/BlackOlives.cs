﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryPattern.Product.Ingredients.Abstractions;
namespace FactoryPattern.Product.Ingredients
{
    internal class BlackOlives : IVeggies
    {
        string IVeggies.ToString()
        {
            return "Black Olives";
        }
    }
}
