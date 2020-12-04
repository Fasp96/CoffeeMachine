namespace CoffeeMachine.Data
{
    internal class Whip : Condiment
    {
        public Whip(ICoffee aCoffees) : base(aCoffees) { }
        public override string Description => Coffee.Description + ", Whip";
        public override double Cost => Coffee.Cost + 0.10;
    }
}
