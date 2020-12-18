namespace CoffeeMachine.States
{
    internal class Payment : State
    {
        public Payment(Machine aMAchine) : base(aMAchine) { }
        public override void insert() { }
        public override void prepare() 
        {
            Machine.Current = new Preparation(Machine);
        }
        public override void eject() 
        {
            Machine.Current = new Selection(Machine);        
        }
    }
}
