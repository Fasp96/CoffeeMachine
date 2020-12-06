using CoffeeMachine.Data;

namespace CoffeeMachine.GraphicalInterface
{
    partial class CoffeeMachineForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SteamedMilkCheckBox = new System.Windows.Forms.CheckBox();
            this.MochaCheckBox = new System.Windows.Forms.CheckBox();
            this.SoyCheckBox = new System.Windows.Forms.CheckBox();
            this.WhipCheckBox = new System.Windows.Forms.CheckBox();
            this.CondimentsBox = new System.Windows.Forms.GroupBox();
            this.HouseBlendRatioButton = new System.Windows.Forms.RadioButton();
            this.DarkRoastRatioButton = new System.Windows.Forms.RadioButton();
            this.DecafRatioButton = new System.Windows.Forms.RadioButton();
            this.EspressoRationButton = new System.Windows.Forms.RadioButton();
            this.CoffeeBox = new System.Windows.Forms.GroupBox();
            this.GreenTeaPrice = new System.Windows.Forms.TextBox();
            this.EspressoPrice = new System.Windows.Forms.TextBox();
            this.DecafPrice = new System.Windows.Forms.TextBox();
            this.DarkRoastPrice = new System.Windows.Forms.TextBox();
            this.HouseBlendPrice = new System.Windows.Forms.TextBox();
            this.GreenTeaRationButton = new System.Windows.Forms.RadioButton();
            this.CoffeMachineName = new System.Windows.Forms.TextBox();
            this.CreateCoffeeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SteamedMilkPrice = new System.Windows.Forms.TextBox();
            this.MochaPrice = new System.Windows.Forms.TextBox();
            this.SoyPrice = new System.Windows.Forms.TextBox();
            this.WhipPrice = new System.Windows.Forms.TextBox();
            this.CondimentsBox.SuspendLayout();
            this.CoffeeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HouseBlendRatioButton
            // 
            this.HouseBlendRatioButton.AutoSize = true;
            this.HouseBlendRatioButton.Location = new System.Drawing.Point(6, 34);
            this.HouseBlendRatioButton.Name = "HouseBlendRatioButton";
            this.HouseBlendRatioButton.Size = new System.Drawing.Size(92, 19);
            this.HouseBlendRatioButton.TabIndex = 5;
            this.HouseBlendRatioButton.TabStop = true;
            this.HouseBlendRatioButton.Text = "House Blend";
            this.HouseBlendRatioButton.UseVisualStyleBackColor = true;
            // 
            // HouseBlendPrice
            // 
            this.HouseBlendPrice.BackColor = System.Drawing.SystemColors.Control;
            this.HouseBlendPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HouseBlendPrice.Location = new System.Drawing.Point(156, 36);
            this.HouseBlendPrice.Name = "HouseBlendPrice";
            this.HouseBlendPrice.Size = new System.Drawing.Size(38, 16);
            this.HouseBlendPrice.TabIndex = 10;
            this.HouseBlendPrice.Text = "0.89€";
            // 
            // DarkRoastRatioButton
            // 
            this.DarkRoastRatioButton.AutoSize = true;
            this.DarkRoastRatioButton.Location = new System.Drawing.Point(6, 59);
            this.DarkRoastRatioButton.Name = "DarkRoastRatioButton";
            this.DarkRoastRatioButton.Size = new System.Drawing.Size(81, 19);
            this.DarkRoastRatioButton.TabIndex = 6;
            this.DarkRoastRatioButton.TabStop = true;
            this.DarkRoastRatioButton.Text = "Dark Roast";
            this.DarkRoastRatioButton.UseVisualStyleBackColor = true;
            // 
            // DarkRoastPrice
            // 
            this.DarkRoastPrice.BackColor = System.Drawing.SystemColors.Control;
            this.DarkRoastPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DarkRoastPrice.Location = new System.Drawing.Point(156, 61);
            this.DarkRoastPrice.Name = "DarkRoastPrice";
            this.DarkRoastPrice.Size = new System.Drawing.Size(38, 16);
            this.DarkRoastPrice.TabIndex = 11;
            this.DarkRoastPrice.Text = "0.99€";
            // 
            // DecafRatioButton
            // 
            this.DecafRatioButton.AutoSize = true;
            this.DecafRatioButton.Location = new System.Drawing.Point(6, 84);
            this.DecafRatioButton.Name = "DecafRatioButton";
            this.DecafRatioButton.Size = new System.Drawing.Size(55, 19);
            this.DecafRatioButton.TabIndex = 7;
            this.DecafRatioButton.TabStop = true;
            this.DecafRatioButton.Text = "Decaf";
            this.DecafRatioButton.UseVisualStyleBackColor = true;
            // 
            // DecafPrice
            // 
            this.DecafPrice.BackColor = System.Drawing.SystemColors.Control;
            this.DecafPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DecafPrice.Location = new System.Drawing.Point(156, 86);
            this.DecafPrice.Name = "DecafPrice";
            this.DecafPrice.Size = new System.Drawing.Size(38, 16);
            this.DecafPrice.TabIndex = 12;
            this.DecafPrice.Text = "1.05€";
            // 
            // EspressoRationButton
            // 
            this.EspressoRationButton.AutoSize = true;
            this.EspressoRationButton.Location = new System.Drawing.Point(6, 109);
            this.EspressoRationButton.Name = "EspressoRationButton";
            this.EspressoRationButton.Size = new System.Drawing.Size(70, 19);
            this.EspressoRationButton.TabIndex = 8;
            this.EspressoRationButton.TabStop = true;
            this.EspressoRationButton.Text = "Espresso";
            this.EspressoRationButton.UseVisualStyleBackColor = true;
            // 
            // EspressoPrice
            // 
            this.EspressoPrice.BackColor = System.Drawing.SystemColors.Control;
            this.EspressoPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EspressoPrice.Location = new System.Drawing.Point(156, 111);
            this.EspressoPrice.Name = "EspressoPrice";
            this.EspressoPrice.Size = new System.Drawing.Size(38, 16);
            this.EspressoPrice.TabIndex = 13;
            this.EspressoPrice.Text = "1.99€";
            // 
            // GreenTeaPrice
            // 
            this.GreenTeaPrice.BackColor = System.Drawing.SystemColors.Control;
            this.GreenTeaPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GreenTeaPrice.Location = new System.Drawing.Point(156, 136);
            this.GreenTeaPrice.Name = "GreenTeaPrice";
            this.GreenTeaPrice.Size = new System.Drawing.Size(38, 16);
            this.GreenTeaPrice.TabIndex = 14;
            this.GreenTeaPrice.Text = "1.00€";
            // 
            // GreenTeaRationButton
            // 
            this.GreenTeaRationButton.AutoSize = true;
            this.GreenTeaRationButton.Location = new System.Drawing.Point(6, 134);
            this.GreenTeaRationButton.Name = "GreenTeaRationButton";
            this.GreenTeaRationButton.Size = new System.Drawing.Size(76, 19);
            this.GreenTeaRationButton.TabIndex = 9;
            this.GreenTeaRationButton.TabStop = true;
            this.GreenTeaRationButton.Text = "Green Tea";
            this.GreenTeaRationButton.UseVisualStyleBackColor = true;
            // 
            // CoffeeBox
            // 
            this.CoffeeBox.Controls.Add(this.GreenTeaPrice);
            this.CoffeeBox.Controls.Add(this.EspressoPrice);
            this.CoffeeBox.Controls.Add(this.DecafPrice);
            this.CoffeeBox.Controls.Add(this.DarkRoastPrice);
            this.CoffeeBox.Controls.Add(this.HouseBlendPrice);
            this.CoffeeBox.Controls.Add(this.HouseBlendRatioButton);
            this.CoffeeBox.Controls.Add(this.DarkRoastRatioButton);
            this.CoffeeBox.Controls.Add(this.DecafRatioButton);
            this.CoffeeBox.Controls.Add(this.GreenTeaRationButton);
            this.CoffeeBox.Controls.Add(this.EspressoRationButton);
            this.CoffeeBox.Location = new System.Drawing.Point(28, 77);
            this.CoffeeBox.Name = "CoffeeBox";
            this.CoffeeBox.Size = new System.Drawing.Size(200, 166);
            this.CoffeeBox.TabIndex = 9;
            this.CoffeeBox.TabStop = false;
            this.CoffeeBox.Text = "Coffee";
            this.CoffeeBox.Enter += new System.EventHandler(this.CoffeeBox_Enter);
            // 
            // SteamedMilkCheckBox
            // 
            this.SteamedMilkCheckBox.AutoSize = true;
            this.SteamedMilkCheckBox.Location = new System.Drawing.Point(6, 34);
            this.SteamedMilkCheckBox.Name = "SteamedMilkCheckBox";
            this.SteamedMilkCheckBox.Size = new System.Drawing.Size(98, 19);
            this.SteamedMilkCheckBox.TabIndex = 0;
            this.SteamedMilkCheckBox.Text = "Steamed Milk";
            this.SteamedMilkCheckBox.UseVisualStyleBackColor = true;
            // 
            // SteamedMilkPrice
            // 
            this.SteamedMilkPrice.BackColor = System.Drawing.SystemColors.Control;
            this.SteamedMilkPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SteamedMilkPrice.Location = new System.Drawing.Point(115, 35);
            this.SteamedMilkPrice.Name = "SteamedMilkPrice";
            this.SteamedMilkPrice.Size = new System.Drawing.Size(38, 16);
            this.SteamedMilkPrice.TabIndex = 15;
            this.SteamedMilkPrice.Text = "0.10€";
            // 
            // MochaCheckBox
            // 
            this.MochaCheckBox.AutoSize = true;
            this.MochaCheckBox.Location = new System.Drawing.Point(6, 59);
            this.MochaCheckBox.Name = "MochaCheckBox";
            this.MochaCheckBox.Size = new System.Drawing.Size(63, 19);
            this.MochaCheckBox.TabIndex = 1;
            this.MochaCheckBox.Text = "Mocha";
            this.MochaCheckBox.UseVisualStyleBackColor = true;
            // 
            // MochaPrice
            // 
            this.MochaPrice.BackColor = System.Drawing.SystemColors.Control;
            this.MochaPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MochaPrice.Location = new System.Drawing.Point(115, 61);
            this.MochaPrice.Name = "MochaPrice";
            this.MochaPrice.Size = new System.Drawing.Size(38, 16);
            this.MochaPrice.TabIndex = 16;
            this.MochaPrice.Text = "0.20€";
            // 
            // SoyCheckBox
            // 
            this.SoyCheckBox.AutoSize = true;
            this.SoyCheckBox.Location = new System.Drawing.Point(6, 84);
            this.SoyCheckBox.Name = "SoyCheckBox";
            this.SoyCheckBox.Size = new System.Drawing.Size(45, 19);
            this.SoyCheckBox.TabIndex = 2;
            this.SoyCheckBox.Text = "Soy";
            this.SoyCheckBox.UseVisualStyleBackColor = true;
            // 
            // SoyPrice
            // 
            this.SoyPrice.BackColor = System.Drawing.SystemColors.Control;
            this.SoyPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SoyPrice.Location = new System.Drawing.Point(115, 85);
            this.SoyPrice.Name = "SoyPrice";
            this.SoyPrice.Size = new System.Drawing.Size(38, 16);
            this.SoyPrice.TabIndex = 17;
            this.SoyPrice.Text = "0.15€";
            // 
            // WhipCheckBox
            // 
            this.WhipCheckBox.AutoSize = true;
            this.WhipCheckBox.Location = new System.Drawing.Point(6, 109);
            this.WhipCheckBox.Name = "WhipCheckBox";
            this.WhipCheckBox.Size = new System.Drawing.Size(54, 19);
            this.WhipCheckBox.TabIndex = 3;
            this.WhipCheckBox.Text = "Whip";
            this.WhipCheckBox.UseVisualStyleBackColor = true;
            // 
            // WhipPrice
            // 
            this.WhipPrice.BackColor = System.Drawing.SystemColors.Control;
            this.WhipPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WhipPrice.Location = new System.Drawing.Point(115, 111);
            this.WhipPrice.Name = "WhipPrice";
            this.WhipPrice.Size = new System.Drawing.Size(38, 16);
            this.WhipPrice.TabIndex = 18;
            this.WhipPrice.Text = "0.10€";
            // 
            // CondimentsBox
            // 
            this.CondimentsBox.Controls.Add(this.WhipPrice);
            this.CondimentsBox.Controls.Add(this.SoyPrice);
            this.CondimentsBox.Controls.Add(this.MochaPrice);
            this.CondimentsBox.Controls.Add(this.SteamedMilkPrice);
            this.CondimentsBox.Controls.Add(this.SteamedMilkCheckBox);
            this.CondimentsBox.Controls.Add(this.WhipCheckBox);
            this.CondimentsBox.Controls.Add(this.SoyCheckBox);
            this.CondimentsBox.Controls.Add(this.MochaCheckBox);
            this.CondimentsBox.Location = new System.Drawing.Point(330, 77);
            this.CondimentsBox.Name = "CondimentsBox";
            this.CondimentsBox.Size = new System.Drawing.Size(159, 140);
            this.CondimentsBox.TabIndex = 4;
            this.CondimentsBox.TabStop = false;
            this.CondimentsBox.Text = "Condiments";
            // 
            // CoffeMachineName
            // 
            this.CoffeMachineName.BackColor = System.Drawing.SystemColors.Control;
            this.CoffeMachineName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CoffeMachineName.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CoffeMachineName.Location = new System.Drawing.Point(180, 12);
            this.CoffeMachineName.Name = "CoffeMachineName";
            this.CoffeMachineName.Size = new System.Drawing.Size(201, 40);
            this.CoffeMachineName.TabIndex = 11;
            this.CoffeMachineName.Text = "Cofffe Machine";
            // 
            // CreateCoffeeButton
            // 
            this.CreateCoffeeButton.Enabled = false;
            this.CreateCoffeeButton.Location = new System.Drawing.Point(245, 286);
            this.CreateCoffeeButton.Name = "CreateCoffeeButton";
            this.CreateCoffeeButton.Size = new System.Drawing.Size(101, 24);
            this.CreateCoffeeButton.TabIndex = 12;
            this.CreateCoffeeButton.Text = "Create Coffee";
            this.CreateCoffeeButton.UseVisualStyleBackColor = true;
            this.CreateCoffeeButton.Click += new System.EventHandler(this.CreateCoffeeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(367, 286);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(92, 24);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);          
            // 
            // CoffeeMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 385);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CreateCoffeeButton);
            this.Controls.Add(this.CoffeMachineName);
            this.Controls.Add(this.CoffeeBox);
            this.Controls.Add(this.CondimentsBox);
            this.Name = "CoffeeMachineForm";
            this.Text = "CoffeMachine";
            this.CondimentsBox.ResumeLayout(false);
            this.CondimentsBox.PerformLayout();
            this.CoffeeBox.ResumeLayout(false);
            this.CoffeeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SteamedMilkCheckBox;
        private System.Windows.Forms.CheckBox MochaCheckBox;
        private System.Windows.Forms.CheckBox SoyCheckBox;
        private System.Windows.Forms.CheckBox WhipCheckBox;
        private System.Windows.Forms.GroupBox CondimentsBox;
        private System.Windows.Forms.RadioButton HouseBlendRatioButton;
        private System.Windows.Forms.RadioButton DarkRoastRatioButton;
        private System.Windows.Forms.RadioButton DecafRatioButton;
        private System.Windows.Forms.RadioButton EspressoRationButton;
        private System.Windows.Forms.RadioButton GreenTeaRationButton;
        private System.Windows.Forms.GroupBox CoffeeBox;
        private System.Windows.Forms.TextBox CoffeMachineName;
        private System.Windows.Forms.Button CreateCoffeeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox HouseBlendPrice;
        private System.Windows.Forms.TextBox GreenTeaPrice;
        private System.Windows.Forms.TextBox EspressoPrice;
        private System.Windows.Forms.TextBox DecafPrice;
        private System.Windows.Forms.TextBox DarkRoastPrice;
        private System.Windows.Forms.TextBox WhipPrice;
        private System.Windows.Forms.TextBox SoyPrice;
        private System.Windows.Forms.TextBox MochaPrice;
        private System.Windows.Forms.TextBox SteamedMilkPrice;
    }
}

