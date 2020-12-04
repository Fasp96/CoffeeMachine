using System;
using CoffeeMachine.Data;

namespace CoffeeMachine
{
    public sealed class CoffeFactory
    {
        private CoffeFactory() { }
        public static CoffeFactory Instance { get; } = new CoffeFactory();

        #region Coffe Section

        public ICoffee CreateDarkRoast() => new DarkRoast();
        public ICoffee CreateDecaf() => new Decaf();
        public ICoffee CreateEspresso() => new Espresso();
        public ICoffee CreateHouseBlend() => new HouseBlend();
        public ICoffee CreateGreenTea() => new TeaCoffeeAdapter(new GreenTea());
        public ICoffee CreateCoffee(string aType)
        {
            switch (aType)
            {
                case "Dark Roast" : return CreateDarkRoast();
                case "Decaf" : return CreateDecaf();
                case "Espresso" : return CreateEspresso();
                case "House Blend" : return CreateHouseBlend();
                case "Green Tea" : return CreateGreenTea();
            }
            throw new Exception();
        }
        #endregion

        #region Condiment Section

        public ICoffee AddSteamedMilk(ICoffee aCoffee) => new SteamedMilk(aCoffee);
        public ICoffee AddMocha(ICoffee aCoffee) => new Mocha(aCoffee);
        public ICoffee AddSoy(ICoffee aCoffee) => new Soy(aCoffee);
        public ICoffee AddWhip(ICoffee aCoffee) => new Whip(aCoffee);

        public ICoffee AddCondiment(ICoffee aCoffee, string aType)
        {
            switch (aType)
            {
                case "Steamed Milk" : return AddSteamedMilk(aCoffee);
                case "Mocha" : return AddMocha(aCoffee);
                case "Soy" : return AddSoy(aCoffee);
                case "Whip" : return AddWhip(aCoffee);

            }
            throw new Exception();
        }
        #endregion
    }
}

