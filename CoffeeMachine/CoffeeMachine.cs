using System;
using System.Collections.Generic;
using CoffeeMachine.Data;

namespace CoffeeMachine
{
    class CoffeeMachine
    {
        static void Main(string[] args)
        {
            string coffeeSelected;
            string[] condimentsSelected = { };
            CoffeFactory factory = CoffeFactory.Instance;
            ICoffee coffee;

            for (; ; )
            {
                ShowCoffeeOpt(); //Show Coffee Options
                coffeeSelected = ReadCoffeeOpt(); //Reads Coffee Option
                if (string.IsNullOrWhiteSpace(coffeeSelected)) break; //Stop program

                ShowCoffeeSelected(coffeeSelected); //Show selected coffe and if wants condiments
                coffee = factory.CreateCoffee(coffeeSelected); //Creates the selected coffe

                if (Console.ReadKey(true).Key == ConsoleKey.Y) //if Y is pressed
                {
                    ShowCondimentOpt(); //Show Condiment Options
                    condimentsSelected = ReadCondimentsOpt(); //Read Coffee Option
                }

                coffee =CreateCoffee(factory, coffee, condimentsSelected); //Creates the coffe with the condiments (if there are any)
                ShowCoffeeCreated(coffee); //Shows the created Coffe


                Console.ReadKey();
                Console.Clear();

            }
            
        }

        static void ShowCoffeeOpt()
        {
            Console.Write(
                "\t** Wellcome to the Coffe Machine **\n" + 
                "\n" +
                "Coffe Options:\n" +
                "\t(1) House Blend\t 0.89 euros\n" +
                "\t(2) Dark Roast\t 0.99 euros\n" +
                "\t(3) Decaf\t 1.05 euros\n" +
                "\t(4) Espresso\t 1.99 euros\n" +
                "\t(5) Green Tea\t 1.00 euros\n" +
                "\n" +
                "Please select your desire coffee or tea (press enter to exit): "
                );
        }

        static void ShowCoffeeSelected(string coffeeSelected)
        {
            Console.Write("\nThe selected coffe was {0}, would you like some condiments in you coffee?(Press Y for condiments)",
                coffeeSelected);
        }

        static string ReadCoffeeOpt()
        {
            string coffeeOpt = Console.ReadLine();

            switch (coffeeOpt)
            {
                case "1": return "House Blend";
                case "2": return "Dark Roast";
                case "3": return "Decaf";
                case "4": return "Espresso";
                case "5": return "Green Tea";
                default: return null;
            }
            throw new Exception();
        }

        static void ShowCondimentOpt()
        {
            Console.Write(
                "\n\nCondiment Options:\n" +
                "\t(1) Steamed Milk 0.10 euros\n" +
                "\t(2) Mocha\t 0.20 euros\n" +
                "\t(3) Soy\t\t 0.15 euros\n" +
                "\t(4) Whip\t 0.10 euros\n" +
                "\n" +
                "Please select your desire coffee or tea: "
                );
        }

        static string[] ReadCondimentsOpt()
        {
            string condimentsOpt;
            string[] condimentsOptArray;

            condimentsOpt = Console.ReadLine().Replace(" ", string.Empty);
            condimentsOptArray = condimentsOpt.Split(',');

            for (int i = 0; i < condimentsOptArray.Length; i++)
            {
                switch (condimentsOptArray[i])
                {
                    case "1": condimentsOptArray[i] = "Steamed Milk";
                        break;
                    case "2": condimentsOptArray[i] = "Mocha";
                        break;
                    case "3": condimentsOptArray[i] = "Soy";
                        break;
                    case "4": condimentsOptArray[i] = "Whip";
                        break;
                    default: throw new Exception();
                }
                
            }
            return condimentsOptArray;
        }

        static ICoffee CreateCoffee(CoffeFactory factory, ICoffee coffee, string[] condimentsSelected)
        {
            foreach (string condiment in condimentsSelected) coffee = factory.AddCondiment(coffee, condiment); //Creates the coffe with the selected condiments
            return coffee;
        }

        static void ShowCoffeeCreated(ICoffee coffee)
        {
            Console.Write(
                "\n"+
                "\nCoffee Created: {0}" +
                "\nCost: {1} euros"
                , coffee.Description, Math.Round(coffee.Cost, 2));
        }
    }
}
