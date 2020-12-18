namespace CoffeeMachine.States
{
    internal class Selection : State
    {
        public Selection(Machine aMAchine) : base(aMAchine) { }
        public override void select() { }
        public override void insert() 
        {
            Machine.Current = new Payment(Machine);
        }
    }
}