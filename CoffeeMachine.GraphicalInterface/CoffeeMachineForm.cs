using System;
using System.Linq;
using System.Windows.Forms;
using CoffeeMachine.Data;

namespace CoffeeMachine.GraphicalInterface
{
    public partial class CoffeeMachineForm : Form
    {
        public CoffeeMachineForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult exitButtonResult = MessageBox.Show("Are you sure to exit the Coffe Machine?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitButtonResult == DialogResult.Yes) Close();
        }

        private void CoffeeBox_Enter(object sender, EventArgs e)
        {
            CreateCoffeeButton.Enabled = true;      
        }

        private void CreateCoffeeButton_Click(object sender, EventArgs e)
        {
            CoffeFactory factory = CoffeFactory.Instance;
            ICoffee coffee;

            string ratioCoffeName = CoffeeBox.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked).Text; //Gets the coffee checked

            coffee = factory.CreateCoffee(ratioCoffeName); //Creates the coffee

            var checkedCondiments = CondimentsBox.Controls.OfType<CheckBox>().Where(c => c.Checked).ToArray();//Checks if any of the condiments were selected

            //Add the checked Condiments to the coffee
            foreach (var condiments in checkedCondiments)
            {
                coffee = factory.AddCondiment(coffee, condiments.Text);
            }

            ShowMessageBoxCreateCoffee(coffee); //Show a Message Box with the created coffee

            ResetCoffeeMachine(); //Resets the Coffee Machine
        }

        private void ShowMessageBoxCreateCoffee(ICoffee coffee)
        {
            string createdCoffeeMessage = "Coffee Created: " + coffee.Description +
                "\nCost: " + Math.Round(coffee.Cost, 2) + " euros";
            
            MessageBox.Show(createdCoffeeMessage, "Coffee Ordered", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void ResetCoffeeMachine()
        {
            CoffeeBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Checked = false;
            
            var checkedCondiments = CondimentsBox.Controls.OfType<CheckBox>().Where(c => c.Checked).ToArray();
            
            foreach (var condiments in checkedCondiments)
            {
                condiments.Checked = false;
            }

            CreateCoffeeButton.Enabled = false;
        }
    }
}
