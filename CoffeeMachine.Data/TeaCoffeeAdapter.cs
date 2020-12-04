namespace CoffeeMachine.Data
{
    public class TeaCoffeeAdapter : ICoffee
    {
        public TeaCoffeeAdapter(ITea aTea)
        {
            Tea = aTea;
        }

        protected ITea Tea { get; set; }

        public string Description => Tea.Description;
        public double Cost => Tea.Price;
    }
}
