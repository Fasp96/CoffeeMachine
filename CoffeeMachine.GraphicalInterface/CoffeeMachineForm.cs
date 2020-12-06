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
                .FirstOrDefault(r => r.Checked).Name; //Gets the coffee checked

            coffee = factory.CreateCoffee(ratioCoffeName); //Creates the coffee

            //Checks if any of the condiments were selected
            if (SteamedMilkCheckBox.Checked) coffee = factory.AddCondiment(coffee, SteamedMilkCheckBox.Name); 
            if (MochaCheckBox.Checked) coffee = factory.AddCondiment(coffee, MochaCheckBox.Name);
            if (SoyCheckBox.Checked) coffee = factory.AddCondiment(coffee, SoyCheckBox.Name);
            if (WhipCheckBox.Checked) coffee = factory.AddCondiment(coffee, WhipCheckBox.Name);


            //Show a Message Box with the created coffee
            string createdCoffeeMessage = "Coffee Created: " + coffee.Description +
                "\nCost: " + Math.Round(coffee.Cost, 2) + " euros";
            DialogResult createCoffeButtonResult = MessageBox.Show(createdCoffeeMessage, "Coffee Ordered", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (createCoffeButtonResult == DialogResult.OK) //Resets the CoffeMachine
            {
                CoffeeMachineForm coffeeMachineForm = new CoffeeMachineForm();
                coffeeMachineForm.Show();
                Dispose(false);
            }
        }
    }
}
