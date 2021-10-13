using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Product.Ingredients.Abstractions;
namespace FactoryPattern.Product.Ingredients
{
    internal class ReggianoCheese : ICheese
    {
        string ICheese.ToString()
        {
            return "Reggiano Cheese";
        }
    }
}
