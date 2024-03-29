namespace DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }

        public override double cost()
        {
            return _beverage.cost() + .10;
        } 
    }
}