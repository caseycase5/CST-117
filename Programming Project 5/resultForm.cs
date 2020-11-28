using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_5
{
    public partial class resultForm : Form
    {
        public resultForm(string labelText)
        {
            InitializeComponent();
            luckyNumberLabel.Text = labelText;
        }

        private void resultForm_Load(object sender, EventArgs e)
        {

        }

        private void luckyNumberLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
