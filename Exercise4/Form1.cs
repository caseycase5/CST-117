using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
	public partial class Form1 : Form
	{
		private int userEntry;
		private double convertedSeconds;

		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			userEntry = Convert.ToInt32(userEntryBox.Text);

			if (userEntry < 60)
			{
				conversionBox.Text = (Convert.ToString(userEntry) + " seconds");
			}

			else if(userEntry >= 60 && userEntry < 3600) {
				conversionBox.Text = (Convert.ToString(userEntry / 60) + " minutes");
			}

			else if (userEntry >= 3600 && userEntry < 86400)
			{
				conversionBox.Text = (Convert.ToString(userEntry / 3600) + " hours");
			}

			else if (userEntry >= 86400)
			{
				conversionBox.Text = (Convert.ToString(userEntry / 86400) + " days");
			}
		}

		private void userEntryBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
