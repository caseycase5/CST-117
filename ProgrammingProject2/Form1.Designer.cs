namespace ProgrammingProject2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.toppingListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.redSauceButton = new System.Windows.Forms.RadioButton();
			this.whiteSauceButton = new System.Windows.Forms.RadioButton();
			this.submitButton = new System.Windows.Forms.Button();
			this.pizzaTextBox = new System.Windows.Forms.TextBox();
			this.chosenPizza = new System.Windows.Forms.Label();
			this.beefCheckBox = new System.Windows.Forms.CheckBox();
			this.chickenCheckBox = new System.Windows.Forms.CheckBox();
			this.meatLabel = new System.Windows.Forms.Label();
			this.sauceLabel = new System.Windows.Forms.Label();
			this.toppingLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// toppingListBox
			// 
			this.toppingListBox.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.toppingListBox.FormattingEnabled = true;
			this.toppingListBox.Items.AddRange(new object[] {
            "Green Peppers",
            "Onions",
            "Olives",
            "Pineapple"});
			this.toppingListBox.Location = new System.Drawing.Point(12, 70);
			this.toppingListBox.Name = "toppingListBox";
			this.toppingListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.toppingListBox.Size = new System.Drawing.Size(120, 95);
			this.toppingListBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label1.Location = new System.Drawing.Point(172, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pizza Order";
			// 
			// redSauceButton
			// 
			this.redSauceButton.AutoSize = true;
			this.redSauceButton.Location = new System.Drawing.Point(12, 200);
			this.redSauceButton.Name = "redSauceButton";
			this.redSauceButton.Size = new System.Drawing.Size(79, 17);
			this.redSauceButton.TabIndex = 2;
			this.redSauceButton.TabStop = true;
			this.redSauceButton.Text = "Red Sauce";
			this.redSauceButton.UseVisualStyleBackColor = true;
			// 
			// whiteSauceButton
			// 
			this.whiteSauceButton.AutoSize = true;
			this.whiteSauceButton.Location = new System.Drawing.Point(12, 223);
			this.whiteSauceButton.Name = "whiteSauceButton";
			this.whiteSauceButton.Size = new System.Drawing.Size(87, 17);
			this.whiteSauceButton.TabIndex = 4;
			this.whiteSauceButton.TabStop = true;
			this.whiteSauceButton.Text = "White Sauce";
			this.whiteSauceButton.UseVisualStyleBackColor = true;
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(12, 360);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(75, 23);
			this.submitButton.TabIndex = 5;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// pizzaTextBox
			// 
			this.pizzaTextBox.Location = new System.Drawing.Point(240, 195);
			this.pizzaTextBox.Multiline = true;
			this.pizzaTextBox.Name = "pizzaTextBox";
			this.pizzaTextBox.Size = new System.Drawing.Size(173, 76);
			this.pizzaTextBox.TabIndex = 6;
			// 
			// chosenPizza
			// 
			this.chosenPizza.AutoSize = true;
			this.chosenPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.chosenPizza.Location = new System.Drawing.Point(237, 175);
			this.chosenPizza.Name = "chosenPizza";
			this.chosenPizza.Size = new System.Drawing.Size(80, 17);
			this.chosenPizza.TabIndex = 7;
			this.chosenPizza.Text = "Your Pizza:";
			// 
			// beefCheckBox
			// 
			this.beefCheckBox.AutoSize = true;
			this.beefCheckBox.Location = new System.Drawing.Point(12, 274);
			this.beefCheckBox.Name = "beefCheckBox";
			this.beefCheckBox.Size = new System.Drawing.Size(48, 17);
			this.beefCheckBox.TabIndex = 8;
			this.beefCheckBox.Text = "Beef";
			this.beefCheckBox.UseVisualStyleBackColor = true;
			// 
			// chickenCheckBox
			// 
			this.chickenCheckBox.AutoSize = true;
			this.chickenCheckBox.Location = new System.Drawing.Point(12, 297);
			this.chickenCheckBox.Name = "chickenCheckBox";
			this.chickenCheckBox.Size = new System.Drawing.Size(65, 17);
			this.chickenCheckBox.TabIndex = 9;
			this.chickenCheckBox.Text = "Chicken";
			this.chickenCheckBox.UseVisualStyleBackColor = true;
			// 
			// meatLabel
			// 
			this.meatLabel.AutoSize = true;
			this.meatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.meatLabel.Location = new System.Drawing.Point(10, 254);
			this.meatLabel.Name = "meatLabel";
			this.meatLabel.Size = new System.Drawing.Size(79, 17);
			this.meatLabel.TabIndex = 10;
			this.meatLabel.Text = "Meat Type:";
			this.meatLabel.Click += new System.EventHandler(this.label3_Click);
			// 
			// sauceLabel
			// 
			this.sauceLabel.AutoSize = true;
			this.sauceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.sauceLabel.Location = new System.Drawing.Point(9, 180);
			this.sauceLabel.Name = "sauceLabel";
			this.sauceLabel.Size = new System.Drawing.Size(88, 17);
			this.sauceLabel.TabIndex = 11;
			this.sauceLabel.Text = "Sauce Type:";
			// 
			// toppingLabel
			// 
			this.toppingLabel.AutoSize = true;
			this.toppingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.toppingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.toppingLabel.Location = new System.Drawing.Point(10, 50);
			this.toppingLabel.Name = "toppingLabel";
			this.toppingLabel.Size = new System.Drawing.Size(71, 17);
			this.toppingLabel.TabIndex = 12;
			this.toppingLabel.Text = "Toppings:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(546, 395);
			this.Controls.Add(this.toppingLabel);
			this.Controls.Add(this.sauceLabel);
			this.Controls.Add(this.meatLabel);
			this.Controls.Add(this.chickenCheckBox);
			this.Controls.Add(this.beefCheckBox);
			this.Controls.Add(this.chosenPizza);
			this.Controls.Add(this.pizzaTextBox);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.whiteSauceButton);
			this.Controls.Add(this.redSauceButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toppingListBox);
			this.Name = "Form1";
			this.Text = "Programming Project 2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox toppingListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton redSauceButton;
		private System.Windows.Forms.RadioButton whiteSauceButton;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.TextBox pizzaTextBox;
		private System.Windows.Forms.Label chosenPizza;
		private System.Windows.Forms.CheckBox beefCheckBox;
		private System.Windows.Forms.CheckBox chickenCheckBox;
		private System.Windows.Forms.Label meatLabel;
		private System.Windows.Forms.Label sauceLabel;
		private System.Windows.Forms.Label toppingLabel;
	}
}

