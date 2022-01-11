using TemplateMethod.Abtracts;

namespace TemplateMethod;

public class Coffee : CafeinBerage
{
    protected override void Brew()
    {
        Console.WriteLine("Do Coffee...");
    }

    protected override void AddCondiment()
    {
      Console.WriteLine("Add milk"); 
    }

    protected override bool IsCondiment()
    {
        Console.WriteLine("Add Condiment ? (y/n)");
        var confirm = Console.ReadLine();
        if (confirm.ToLower().StartsWith('y'))
        {
            return true;
        }

        return false;
    }
}