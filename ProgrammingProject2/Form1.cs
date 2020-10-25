using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject2
{
	public partial class Form1 : Form
	{
		private String toppingList;
		private String sauceType;
		private String meatType;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			toppingList = toppingListBox.SelectedItem.ToString();

			if (redSauceButton.Checked)
			{
				sauceType = "Red";
			}
			else if (whiteSauceButton.Checked)
			{
				sauceType = "White";
			}

			if (beefCheckBox.Checked && chickenCheckBox.Checked)
			{
				meatType = "Chicken and Beef";
			}

			else if (chickenCheckBox.Checked) {
				meatType = "Chicken";
			}

			else if (beefCheckBox.Checked)
			{
				meatType = "Beef";
			}

			pizzaTextBox.Text = "Your pizza will have " + meatType + " with " + sauceType + " sauce and " + toppingList + " as your topping.";
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
