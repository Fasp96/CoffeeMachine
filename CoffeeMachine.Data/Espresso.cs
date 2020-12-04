namespace CoffeeMachine.Data
{
    internal class Espresso : ICoffee
    {
        public string Description { get; } = "Espresso";
        public double Cost => 1.99;
    }
}