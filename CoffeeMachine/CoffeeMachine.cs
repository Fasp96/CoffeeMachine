using System;
using CoffeeMachine.Data;

namespace CoffeeMachine
{
    class CoffeeMachine
    {
        static void Main(string[] args)
        {
            //Using CreateExpresso and AddMocha
            CoffeFactory factory = CoffeFactory.Instance;
            ICoffee coffee = factory.CreateEspresso();
            Console.WriteLine(coffee.Description + "\n  Price: " + coffee.Cost + " euros\n");


            coffee = factory.AddMocha(coffee);
            Console.WriteLine(coffee.Description + "\n  Price: " + coffee.Cost + " euros\n");

            // Using CreateDecaf and AddSteamedMilk
            ICoffee coffee1 = factory.CreateDecaf();
            Console.WriteLine(coffee1.Description + "\n  Price: " + coffee1.Cost + " euros\n");

            coffee1 = factory.AddSteamedMilk(coffee1);
            Console.WriteLine(coffee1.Description + "\n  Price: " + coffee1.Cost + " euros\n");

            // Using Createcoffee and AddCondiment
            ICoffee coffee2 = factory.CreateCoffee("House Blend");
            Console.WriteLine(coffee2.Description + "\n  Price: " + coffee2.Cost + " euros\n");

            coffee2 = factory.AddCondiment(coffee2, "Whip");
            Console.WriteLine(coffee2.Description + "\n  Price: " + coffee2.Cost + " euros\n");

            // Using CreateGreenTea
            ICoffee tea = factory.CreateGreenTea();
            Console.WriteLine(tea.Description + "\n  Price: " + tea.Cost + " euros\n");

            // Using CreateCoffee to create Tea
            ICoffee tea1 = factory.CreateGreenTea();
            Console.WriteLine(tea1.Description + "\n  Price: " + tea1.Cost + " euros\n");
        }
    }
}
