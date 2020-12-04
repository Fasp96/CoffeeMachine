namespace CoffeeMachine.Data
{
    class GreenTea : ITea
    {
        public string Description { get; } = "Green Tea";
        public double Price => 1.00;
    }
}
