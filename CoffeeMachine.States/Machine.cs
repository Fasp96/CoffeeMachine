using CoffeeMachine.Data;

namespace CoffeeMachine.States
{
    public class Machine
    {
        public int amount { get; set; }
        public State Current { get; set; }
        public ICoffee Coffee { get; set; }
        public Machine()
        {
            Current = new Selection(this);
        }
        public void DoSelect()
        {
            Current.select();
        }
        public void DoInsert()
        {
            Current.insert();
        }
        public void DoEject()
        {
            Current.eject();
        }
        public void DoPrepare()
        {
            Current.prepare();
        }
        public void DoDispense()
        {
            Current.dispense();
        }
    }
}
