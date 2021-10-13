using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Product.Ingredients.Abstractions;
namespace FactoryPattern.Product.Ingredients
{
    internal class MarinaraSauce : ISauce
    {
        string ISauce.ToString()
        {
             return "Marinara Sauce";
        }
    }
}
