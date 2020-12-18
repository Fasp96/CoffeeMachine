using System;

namespace CoffeeMachine.States
{
    public abstract class State
    {
        public virtual void select() { }
        public virtual void insert() { }
        public virtual void eject() { }
        public virtual void prepare() { }
        public virtual void dispense() { }
        protected Machine Machine { get; }
        public State (Machine aMachine)
        {
            Machine = aMachine;
        }

    }
}
