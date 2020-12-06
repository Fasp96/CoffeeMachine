
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
            this.GreenTeaRationButton = new System.Windows.Forms.RadioButton();
            this.CoffeMachineName = new System.Windows.Forms.TextBox();
            this.CreateCoffeeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CondimentsBox.SuspendLayout();
            this.CoffeeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SteamedMilkCheckBox
            // 
            this.SteamedMilkCheckBox.AutoSize = true;
            this.SteamedMilkCheckBox.Location = new System.Drawing.Point(6, 34);
            this.SteamedMilkCheckBox.Name = "Steamed Milk";
            this.SteamedMilkCheckBox.Size = new System.Drawing.Size(98, 19);
            this.SteamedMilkCheckBox.TabIndex = 0;
            this.SteamedMilkCheckBox.Text = "Steamed Milk";
            this.SteamedMilkCheckBox.UseVisualStyleBackColor = true;
            // 
            // MochaCheckBox
            // 
            this.MochaCheckBox.AutoSize = true;
            this.MochaCheckBox.Location = new System.Drawing.Point(6, 59);
            this.MochaCheckBox.Name = "Mocha";
            this.MochaCheckBox.Size = new System.Drawing.Size(63, 19);
            this.MochaCheckBox.TabIndex = 1;
            this.MochaCheckBox.Text = "Mocha";
            this.MochaCheckBox.UseVisualStyleBackColor = true;
            // 
            // SoyCheckBox
            // 
            this.SoyCheckBox.AutoSize = true;
            this.SoyCheckBox.Location = new System.Drawing.Point(6, 84);
            this.SoyCheckBox.Name = "Soy";
            this.SoyCheckBox.Size = new System.Drawing.Size(45, 19);
            this.SoyCheckBox.TabIndex = 2;
            this.SoyCheckBox.Text = "Soy";
            this.SoyCheckBox.UseVisualStyleBackColor = true;
            // 
            // WhipCheckBox
            // 
            this.WhipCheckBox.AutoSize = true;
            this.WhipCheckBox.Location = new System.Drawing.Point(6, 109);
            this.WhipCheckBox.Name = "Whip";
            this.WhipCheckBox.Size = new System.Drawing.Size(54, 19);
            this.WhipCheckBox.TabIndex = 3;
            this.WhipCheckBox.Text = "Whip";
            this.WhipCheckBox.UseVisualStyleBackColor = true;
            // 
            // CondimentsBox
            // 
            this.CondimentsBox.Controls.Add(this.SteamedMilkCheckBox);
            this.CondimentsBox.Controls.Add(this.WhipCheckBox);
            this.CondimentsBox.Controls.Add(this.SoyCheckBox);
            this.CondimentsBox.Controls.Add(this.MochaCheckBox);
            this.CondimentsBox.Location = new System.Drawing.Point(348, 77);
            this.CondimentsBox.Name = "CondimentsBox";
            this.CondimentsBox.Size = new System.Drawing.Size(111, 140);
            this.CondimentsBox.TabIndex = 4;
            this.CondimentsBox.TabStop = false;
            this.CondimentsBox.Text = "Condiments";
            // 
            // HouseBlendRatioButton
            // 
            this.HouseBlendRatioButton.AutoSize = true;
            this.HouseBlendRatioButton.Location = new System.Drawing.Point(6, 34);
            this.HouseBlendRatioButton.Name = "House Blend";
            this.HouseBlendRatioButton.Size = new System.Drawing.Size(92, 19);
            this.HouseBlendRatioButton.TabIndex = 5;
            this.HouseBlendRatioButton.TabStop = true;
            this.HouseBlendRatioButton.Text = "House Blend";
            this.HouseBlendRatioButton.UseVisualStyleBackColor = true;
            // 
            // DarkRoastRatioButton
            // 
            this.DarkRoastRatioButton.AutoSize = true;
            this.DarkRoastRatioButton.Location = new System.Drawing.Point(6, 59);
            this.DarkRoastRatioButton.Name = "Dark Roast";
            this.DarkRoastRatioButton.Size = new System.Drawing.Size(81, 19);
            this.DarkRoastRatioButton.TabIndex = 6;
            this.DarkRoastRatioButton.TabStop = true;
            this.DarkRoastRatioButton.Text = "Dark Roast";
            this.DarkRoastRatioButton.UseVisualStyleBackColor = true;
            // 
            // DecafRatioButton
            // 
            this.DecafRatioButton.AutoSize = true;
            this.DecafRatioButton.Location = new System.Drawing.Point(6, 84);
            this.DecafRatioButton.Name = "Decaf";
            this.DecafRatioButton.Size = new System.Drawing.Size(55, 19);
            this.DecafRatioButton.TabIndex = 7;
            this.DecafRatioButton.TabStop = true;
            this.DecafRatioButton.Text = "Decaf";
            this.DecafRatioButton.UseVisualStyleBackColor = true;
            // 
            // EspressoRationButton
            // 
            this.EspressoRationButton.AutoSize = true;
            this.EspressoRationButton.Location = new System.Drawing.Point(6, 108);
            this.EspressoRationButton.Name = "Espresso";
            this.EspressoRationButton.Size = new System.Drawing.Size(70, 19);
            this.EspressoRationButton.TabIndex = 8;
            this.EspressoRationButton.TabStop = true;
            this.EspressoRationButton.Text = "Espresso";
            this.EspressoRationButton.UseVisualStyleBackColor = true;
            // 
            // GreenTeaRationButton
            // 
            this.GreenTeaRationButton.AutoSize = true;
            this.GreenTeaRationButton.Location = new System.Drawing.Point(6, 133);
            this.GreenTeaRationButton.Name = "Green Tea";
            this.GreenTeaRationButton.Size = new System.Drawing.Size(76, 19);
            this.GreenTeaRationButton.TabIndex = 9;
            this.GreenTeaRationButton.TabStop = true;
            this.GreenTeaRationButton.Text = "Green Tea";
            this.GreenTeaRationButton.UseVisualStyleBackColor = true;
            // 
            // CoffeeBox
            // 
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
            this.CreateCoffeeButton.Location = new System.Drawing.Point(245, 286);
            this.CreateCoffeeButton.Name = "CreateCoffeeButton";
            this.CreateCoffeeButton.Size = new System.Drawing.Size(101, 24);
            this.CreateCoffeeButton.TabIndex = 12;
            this.CreateCoffeeButton.Text = "Create Coffee";
            this.CreateCoffeeButton.UseVisualStyleBackColor = true;
            this.CreateCoffeeButton.Click += new System.EventHandler(this.CreateCoffeeButton_Click);
            this.CreateCoffeeButton.Enabled = false;
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
    }
}

