using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
	public partial class Form1 : Form
	{
		public String inchText;
		public double inch;
		public double cm;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			inchText = inchesText.Text;
			inch = Convert.ToDouble(inchText);
			cm = inch * 2.54;
			cmText.Text = Convert.ToString(cm);
		}
	}
}
