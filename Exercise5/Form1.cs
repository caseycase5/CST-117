using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double divisor = 1;
            int terms = Int32.Parse(userEntry.Text);
            double value = 4;

            for(int x = 0; x <= terms; x += 2)
            {
                value = value - (4 / (divisor + 2));
                value = value + (4 / (divisor + 4));
                divisor = (divisor + 4);
            }

            label2.Text = ("Approximate value of PI after " + userEntry.Text + " terms is: ");
            PIValueLabel.Text = value.ToString("F12");
        }
    }
}
