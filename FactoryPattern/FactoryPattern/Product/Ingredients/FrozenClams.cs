using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Product.Ingredients.Abstractions;
namespace FactoryPattern.Product.Ingredients
{
    internal class FrozenClams : IClam
    {
        string IClam.ToString()
        {

            return "Frozen Clams from Chesapeake Bay";
        }
    }
}
