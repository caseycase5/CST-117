using System;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
			int matches = 0;
			// Insert code for reading from text file via String reader

			string[] words = System.IO.File.ReadAllLines("words.txt");

			for (int i = 0; i < words.Length; i++)
			{
				String word = words[i];
				word = word.ToLower();
				char[] arr = word.ToCharArray();
				int lastIndex = word.Length - 1;
				Console.WriteLine(word);

				if (arr[lastIndex].Equals('t') || arr[lastIndex].Equals('e'))
				{
					matches++;
				}
			}

			Console.WriteLine("There are " + matches + " words that end in 't' or 'e'");
		}
    }
}
