namespace Design_Patterns.Class
{
    public abstract class Beverage
    {
        public string description = "Unknow beverage";
        public double price = 10;
        public string getDescription()
        {
            return description;
        }
        public abstract double cost();
    }
    public abstract class CondimentDecorator : Beverage
    {
        public abstract string getDescription();
    }

    public class Espersso : Beverage
    {
        public Espersso()
        {
            description = "Espersso ";
        }
        public override double cost()
        {
            return  price += 1.99;
        }
    }
    public class HouseBelend : Beverage
    {
        public HouseBelend()
        {
            description = "HouseBelend ";
        }
        public override double cost()
        {
            return  price += 1.99;
        }
    }
    public class whip : CondimentDecorator
    {
        private Beverage _beverage;
        public whip(Beverage beverage)
        {
            _beverage = beverage;
            description = "whip ";
        }
        public override string getDescription()
        {
            return description;
        }
        public override double cost()
        {
            return 2;
        }
    }
    public class mocha : CondimentDecorator
    {
        private Beverage _beverage;
        public mocha(Beverage beverage)
        {
            _beverage = beverage;
            description = "Mocha ";
        }
        public override string getDescription()
        {
            return description;
        }
        public override double cost()
        {
            return .20 ;
        }
    }
}