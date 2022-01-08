namespace DecoratorPattern
{
    public class Soy  : CondimentDecorator
    {
    private Beverage _beverage;

    public Soy(Beverage beverage)
    {
        _beverage = beverage;
    }
    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Soy";
    }

    public override double cost()
    {
        return _beverage.cost() + .25;
    } 
    }
    
        
    
}