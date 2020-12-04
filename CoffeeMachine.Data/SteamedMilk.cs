namespace CoffeeMachine.Data
{
    internal class SteamedMilk : Condiment
    {
        public SteamedMilk(ICoffee aCoffee) : base(aCoffee) { }
        public override string Description => Coffee.Description + ", Steamed Milk";
        public override double Cost => Coffee.Cost + 0.10;
    }
}
