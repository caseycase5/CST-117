using System;

namespace Milestone3
{
    class Program
    {
        static void Main(string[] args)
        {
			Inventory inventory1 = new Inventory(0);

			// Number of items in starting inventory 
			Console.WriteLine("Starting number of items in inventory 1: " + inventory1.getNumOfItems());

			// Adding new items and printing to console
			inventory1.addItem(1, "Item 1", 4.51, 3);
			inventory1.addItem(2, "Item 2", 13.11, 3);
			inventory1.addItem(3, "Item 3", 2.22, 8);
			Console.WriteLine("Number of items in inventory 1 after adding new items: " + inventory1.getNumOfItems());

			// Printing quantity of item 1
			Console.WriteLine("Original Quantity of Item 1: " + inventory1.inventoryItems[0].getQuantity());

			// Restocking item 1 and printing new quantity
			inventory1.restockItem(0, 10);
			Console.WriteLine("Restocked Quantity of Item 1: " + inventory1.inventoryItems[0].getQuantity());

			// Displaying all
			inventory1.displayItems();

			// Removing the first item
			inventory1.removeItem(1);
			Console.WriteLine("After removal of the first item:");
			inventory1.displayItems();

			// Searching for an item
			inventory1.searchForItem(2);
			inventory1.searchForItem("Item 2");

			// Searching for an item that does not exist
			inventory1.searchForItem(14);
		}
    }

	public class Inventory
	{
		public InventoryItem[] inventoryItems;
		public InventoryItem[] inventoryItems2;
		private int numOfItems = 0;

		// Constructor
		public Inventory(int x)
		{
			inventoryItems = new InventoryItem[x];
			numOfItems = x;
		}

		// Add
		public void addItem(int id, String name, double price, int quantity)
		{
			numOfItems = numOfItems + 1;
			inventoryItems2 = new InventoryItem[numOfItems];
			for (int i = 0; i < inventoryItems.Length; i++)
			{
				inventoryItems2[i] = inventoryItems[i];
			}

			inventoryItems2[numOfItems - 1] = new InventoryItem(id, name, price, quantity);
			inventoryItems = inventoryItems2;
		}

		// Remove
		public void removeItem(int itemToRemove)
		{
			numOfItems = numOfItems - 1;
			int x = 0;
			inventoryItems2 = new InventoryItem[numOfItems];
			// Removing the index specified
			for (int i = 0; i < inventoryItems.Length; i++)
			{
				if (i != (itemToRemove - 1))
				{
					inventoryItems2[x] = inventoryItems[i];
					x++;
				}
			}
			inventoryItems = inventoryItems2;
		}

		// Restock 
		public void restockItem(int itemIndex, int newQuantity)
		{
			inventoryItems[itemIndex].setQuantity(newQuantity);
		}

		// Display
		public void displayItems()
		{
			for (int i = 0; i < inventoryItems.Length; i++)
			{
				Console.WriteLine("Item ID: " + inventoryItems[i].getID() + " || Item Name: " + inventoryItems[i].getName() +
					" || Item Price: " + inventoryItems[i].getPrice() + " || Item Quantity: " + inventoryItems[i].getQuantity());
			}
		}

		public void displayItem(int index)
		{
			Console.WriteLine("Item ID: " + inventoryItems[index].getID() + " || Item Name: " + inventoryItems[index].getName() +
					" || Item Price: " + inventoryItems[index].getPrice() + " || Item Quantity: " + inventoryItems[index].getQuantity());
		}

		// Search
		public void searchForItem(int ID)
		{
			bool resultFound = false;
			for (int i = 0; i < inventoryItems.Length; i++)
			{
				if (ID == inventoryItems[i].getID())
				{
					Console.WriteLine("Search Results: ");
					displayItem(i);
					resultFound = true;
				}
			}
			if (!resultFound)
			{
				Console.WriteLine("No matching result was found.");
			}
		}

		public void searchForItem(String name)
		{
			bool resultFound = false;
			for (int i = 0; i < inventoryItems.Length; i++)
			{
				if (name.Equals(inventoryItems[i].getName()))
				{
					Console.WriteLine("Search Results: ");
					displayItem(i);
					resultFound = true;
				}
			}
			if (!resultFound)
			{
				Console.WriteLine("No matching result was found.");
			}
		}

		// Getters & Setters
		public InventoryItem[] getInventoryItems()
		{
			return inventoryItems;
		}

		public void setInventoryItems(InventoryItem[] x)
		{
			inventoryItems = x;
		}

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
