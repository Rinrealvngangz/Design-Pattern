namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }
        
        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }

        public override double cost()
        {
            return _beverage.cost() + .20;
        }
    }
}