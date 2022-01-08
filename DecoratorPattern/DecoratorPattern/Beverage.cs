namespace DecoratorPattern
{
    public abstract class Beverage
    {
       public string description ="Unknown Beverage";

        public virtual  string GetDescription()
        {
            return description;
        }

        public abstract double cost();

    }
}