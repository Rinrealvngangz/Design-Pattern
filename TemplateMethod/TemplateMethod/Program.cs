
using TemplateMethod.Abtracts;

namespace TemplateMethod;

class Program 
{
    static void Main(string[] args)
    {
        CafeinBerage coffeeBerage = new Coffee();
        CafeinBerage teaBerage = new Tea();
        
        coffeeBerage.Prepare();
        teaBerage.Prepare();

        Console.ReadLine();

    }
}
