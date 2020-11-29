﻿using System;
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
    public partial class RemovalForm : Form
    {
        Inventory inventory = new Inventory();
        ListView itemList = new ListView();

        public RemovalForm(Inventory inventory, ListView itemList)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.itemList = itemList;
        }

        private void RemovalForm_Load(object sender, EventArgs e)
        {

        }

        private void removalButton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idTextBox.Text);
            inventory.removeItem(id);
            inventory.displayInventory(itemList);
            Close();
        }
    }
}
