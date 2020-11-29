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
    public partial class InventoryForm : Form
    {
		Inventory inventory = new Inventory();

		public InventoryForm()
        {
            InitializeComponent();
			inventory.addItem(1, "Cookies", 2.51, 25);
			inventory.addItem(2, "Crackers", 3.11, 30);
			inventory.addItem(3, "Soda", 2.99, 45);
			inventory.displayInventory(itemList);
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			int id = Int32.Parse(idTextBox.Text);
			String name = nameTextBox.Text;
			Double price = Double.Parse(priceTextBox.Text);
			int quantity = Int32.Parse(quantityTextBox.Text);

			inventory.addItem(id, name, price, quantity);

			inventory.displayInventory(itemList);

			idTextBox.Clear();
			nameTextBox.Clear();
			priceTextBox.Clear();
			quantityTextBox.Clear();
		}

        private void restockButton_Click(object sender, EventArgs e)
        {
			RestockForm restockForm = new RestockForm(inventory, itemList);
			restockForm.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
			SearchForm searchForm = new SearchForm(inventory);
			searchForm.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
			RemovalForm removalForm = new RemovalForm(inventory, itemList);
			removalForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
			const string sPath = "SaveFile.txt";

			using (System.IO.StreamWriter file = new System.IO.StreamWriter(sPath))
			{
				foreach (ListViewItem item in itemList.Items)
				{
					file.WriteLine(item.ToString());
				}
			}
			MessageBox.Show("File Saved!");
		}
    }

    public class Inventory
	{

		public List<InventoryItem> inventory = new List<InventoryItem>();
		private int numOfItems = 0;

		// Default Constructor
		public Inventory()
		{
		}

		// Adding an item
		public void addItem(int id, String name, double price, int quantity)
		{
			inventory.Add(new InventoryItem(id, name, price, quantity));
			numOfItems++;
		}

		// Removing an item
		public void removeItem(int id)
		{
			inventory.Remove(new InventoryItem(id, "", 0, 0));
		}

		public void removeItemAtIndex(int index)
		{
			inventory.RemoveAt(index);
		}

		// Restocking
		public void restock(int id, int newQuantity)
		{
			InventoryItem tempItem = (inventory.Find(x => x.getID() == id));
			tempItem.setQuantity(newQuantity);
			
		}

		// Displaying all items from an inventory
		public void displayInventory(ListView itemList)
		{
			itemList.Clear();
			foreach(InventoryItem item in inventory)
			{
				itemList.Items.Add(item.ToString());
			}
		}

		// Searching for an item
		public void searchByID(int id)
		{
			if(inventory.Find(x => x.getID() == id) != null)
            {
				MessageBox.Show(inventory.Find(x => x.getID() == id).ToString());
			}
			
			else if (inventory.Find(x => x.getID() == id) == null)
			{
				MessageBox.Show("No matches were found.");
			}
		}

		public void searchByName(String name)
		{
			if (inventory.Find(x => x.getName().Equals(name)) != null)
			{
				MessageBox.Show(inventory.Find(x => (x.getName()).Contains(name)).ToString());
			}

			else if (inventory.Find(x => x.getName().Equals(name)) == null)
			{
				MessageBox.Show("No matches were found.");
			}
		}

		// Getters and Setters
		public int getNumOfItems()
		{
			return numOfItems;
		}

		public void setNumOfItems(int x)
		{
			numOfItems = x;
		}
	}

	public class InventoryItem
	{
		private int id;
		private String name;
		private double price;
		private int quantity;

		public InventoryItem(int id, String name, double price, int quantity)
		{
			this.id = id;
			this.name = name;
			this.price = price;
			this.quantity = quantity;
		}

		public InventoryItem()
		{

		}

		public override string ToString()
		{
			return "ID: " + id + " |  Name: " + name + " |  Price: " + price + " |  Quantity: " + quantity;
		}

		// Equals overrides to allow for removal of items in the list
		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			InventoryItem objAsInv = obj as InventoryItem;
			if (objAsInv == null) return false;
			else return Equals(objAsInv);
		}

		public override int GetHashCode()
		{
			return id;
		}

		public bool Equals(InventoryItem other)
		{
			if (other == null) return false;
			return (this.id.Equals(other.id));
		}

		public int getID()
		{
			return id;
		}

		public void setID(int x)
		{
			id = x;
		}

		public String getName()
		{
			return name;
		}

		public void setName(String x)
		{
			name = x;
		}

		public double getPrice()
		{
			return price;
		}

		public void setPrice(double x)
		{
			price = x;
		}

		public int getQuantity()
		{
			return quantity;
		}

		public void setQuantity(int x)
		{
			quantity = x;
		}
	}
}
