using TemplateMethod.Abtracts;

namespace TemplateMethod;

public class Tea: CafeinBerage
{
    protected override void Brew()
    {
         Console.WriteLine("Do tea..."); 
    }

    protected override void AddCondiment()
    {
        Console.WriteLine("Add sugar");
    }
}