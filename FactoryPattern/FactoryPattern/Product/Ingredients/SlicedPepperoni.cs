using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Product.Ingredients.Abstractions;
namespace FactoryPattern.Product.Ingredients
{
    internal class SlicedPepperoni : IPepperoni
    {    
       string IPepperoni.ToString()
        {
           return "Sliced Pepperoni";
        }
       
    }
}
