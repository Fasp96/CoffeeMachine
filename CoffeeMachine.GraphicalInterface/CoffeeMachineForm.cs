using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeMachine.Data;

namespace CoffeeMachine.GraphicalInterface
{
    public partial class CoffeeMachineForm : System.Windows.Forms.Form
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

            var ratioCoffe = CoffeeBox.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            coffee = factory.CreateCoffee(ratioCoffe.Name);

            if (SteamedMilkCheckBox.Checked) coffee = factory.AddCondiment(coffee, SteamedMilkCheckBox.Name);
            if (MochaCheckBox.Checked) coffee = factory.AddCondiment(coffee, MochaCheckBox.Name);
            if (SoyCheckBox.Checked) coffee = factory.AddCondiment(coffee, SoyCheckBox.Name);
            if (WhipCheckBox.Checked) coffee = factory.AddCondiment(coffee, WhipCheckBox.Name);

            string createdCoffeeMessage = "Coffee Created: " + coffee.Description +
                "\nCost: " + Math.Round(coffee.Cost, 2) + " euros";

            DialogResult createCoffeButtonResult = MessageBox.Show(createdCoffeeMessage, "Coffee Ordered", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
