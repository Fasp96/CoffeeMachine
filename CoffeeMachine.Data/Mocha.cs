namespace CoffeeMachine.Data
{
    internal class Mocha : Condiment
    {
        public Mocha(ICoffee aCoffee) : base(aCoffee) { }
        public override string Description => Coffee.Description + ", Mocha";
        public override double Cost => Coffee.Cost + 0.20;
    }
}