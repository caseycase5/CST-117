using System;

namespace Milestone2
{
    class Program
    {
        static void Main(string[] args)
        {
			// Creating new inventory items
			Inventory inv1 = new Inventory(1, "Inventory 1", 23, "Warehouse 1");
			Inventory inv2 = new Inventory(2, "Inventory 2", 11, "Warehouse 2");
			Inventory inv3 = new Inventory(3, "Inventory 3", 412, "Warehouse 3");

			// Display inventories
			inv1.display();
			inv2.display();
			inv3.display();

			// Adjusting values
			inv1.add(2);
			Console.WriteLine("Inventory 1 now contains " + inv1.getQuantity() + " items.");
			inv2.remove(1);
			Console.WriteLine("Inventory 2 now contains " + inv1.getQuantity() + " items.");
			// Adjusting Inventory 3
			inv3.setLocation("New Warehouse");
			inv3.setName("New Inventory");
			inv3.add(14);
			inv3.display();
		}

		public class Inventory
		{

			private int id;
			private String name;
			private int quantity;
			private String location;

			// Constructors
			public Inventory()
			{

			}

			public Inventory(int a, String b, int c, String d)
			{
				id = a;
				name = b;
				quantity = c;
				location = d;
			}

			// Action Methods
			public void add(int x)
			{
				quantity = quantity + x;
			}

			public void remove(int x)
			{
				quantity = quantity - x;
			}

			public void display()
			{
				Console.WriteLine("The inventory ID is " + id + ". The Inventory name is " + name + ". The inventory contains " +
				quantity + " items. The inventory is located at " + location);
			}

			// Getters and Setters
			public int getId()
			{
				return id;
			}

			public void setId(int x)
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

			public int getQuantity()
			{
				return quantity;
			}

			public void setQuantity(int x)
			{
				quantity = x;
			}

			public String getLocation()
			{
				return location;
			}

			public void setLocation(String x)
			{
				location = x;
			}
		}
	}
}
