using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FactoryPattern.Product.Ingredients.Abstractions;
namespace FactoryPattern.Product.Ingredients
{
    internal class Eggplant : IVeggies
    { 
        string IVeggies.ToString()
        {
            return "Eggplant";
        }
    }
}
