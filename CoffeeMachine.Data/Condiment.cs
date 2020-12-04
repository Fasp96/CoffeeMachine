namespace CoffeeMachine.Data
{
    public abstract class Condiment : ICoffee
    {
        protected Condiment(ICoffee aCoffee)
        {
            Coffee = aCoffee;
        }
        protected ICoffee Coffee { get; }
        public abstract string Description { get; }
        public abstract double Cost { get; }
    }
}
