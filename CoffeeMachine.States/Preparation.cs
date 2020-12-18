namespace CoffeeMachine.States
{
    internal class Preparation : State
    {
        public Preparation(Machine aMAchine) : base(aMAchine) { }
        public override void dispense() 
        {
            Machine.Current = new Selection(Machine);
        }
    }
}
