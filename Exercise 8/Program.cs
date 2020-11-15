using System;

namespace Exercise_8
{
    class Program
    {
		public static void Main()
		{
			int fatCalories;
			int carbCalories;

			fatCalories = FatCalories(14);
			carbCalories = CarbCalories(22);
			Console.WriteLine("The number of calories from fat are " + fatCalories);
			Console.WriteLine("The number of calories from carbs are " + carbCalories);

		}

		public static int FatCalories(int fatGrams)
		{
			return (fatGrams * 9);
		}

		public static int CarbCalories(int carbGrams)
		{
			return (carbGrams * 4);
		}
	}
}
