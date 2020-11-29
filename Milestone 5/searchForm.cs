using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_4
{
    public partial class SearchForm : Form
    {
        Inventory inventory = new Inventory();

        public SearchForm(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }

        private void idSearchButton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idTextBox.Text);
            inventory.searchByID(id);
        }

        private void nameSearchButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;
            inventory.searchByName(name);
        }
    }
}
