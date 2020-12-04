namespace CoffeeMachine.Data
{
    internal class Soy : Condiment
    {
        public Soy(ICoffee aCoffee) : base(aCoffee) { }
        public override string Description => Coffee.Description + ", Soy";
        public override double Cost => Coffee.Cost + 0.15;
    }
}
