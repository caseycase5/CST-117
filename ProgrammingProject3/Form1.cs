using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject3
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] lines;
            String[] linesCopy = null;
            String userFile;
            int arraySize;
            int longestWord = 0;
            int longestIndex = 0;
            int wordLength;
            int noVowelsLength;
            int mostVowels = 0;
            int mostVowelsIndex = 0;

            // Reading the file
            lines = System.IO.File.ReadAllLines(userInput.Text);
            finalText.Items.Add("Initial list of words read from file: ");
            finalText.Items.Add("");
            finalText.Items.AddRange(lines);
            finalText.Items.Add("");
            arraySize = lines.Length - 1;

            // Converting to Lowercase
            for (int x = 0; x < lines.Length; x++)
            {
                lines[x] = lines[x].ToLower();
            }

            finalText.Items.Add("Converting all to lowercase: ");
            finalText.Items.Add("");
            finalText.Items.AddRange(lines);
            finalText.Items.Add("");

            // Sorting the list alphabetically and printing first/last words
            Array.Sort(lines);
            finalText.Items.Add("The first word alphabetically is: ");
            finalText.Items.Add(lines[0]);
            finalText.Items.Add("");
            finalText.Items.Add("The last word alphabetically is: ");
            finalText.Items.Add(lines[arraySize]);
            finalText.Items.Add("");

            // Finding the longest word
            for(int x = 0; x < lines.Length; x++)
            {
                if(lines[x].Length > longestWord)
                {
                    longestWord = lines[x].Length;
                    longestIndex = x;
                }
            }

            finalText.Items.Add("The longest word is: ");
            finalText.Items.Add(lines[longestIndex]);
            finalText.Items.Add("");

            // Finding the word with the most vowels
            linesCopy = (String[])lines.Clone();
            for (int x = 0; x < lines.Length; x++)
            {
                wordLength = lines[x].Length;

                if(linesCopy[x].Contains("a"))
                {
                    linesCopy[x] = linesCopy[x].Replace("a", "");
                }
                if (linesCopy[x].Contains("e"))
                {
                    linesCopy[x] = linesCopy[x].Replace("e", "");
                }
                if (linesCopy[x].Contains("i"))
                {
                    linesCopy[x] = linesCopy[x].Replace("i", "");
                }
                if (linesCopy[x].Contains("o"))
                {
                    linesCopy[x] = linesCopy[x].Replace("o", "");
                }
                if (linesCopy[x].Contains("u"))
                {
                    linesCopy[x] = linesCopy[x].Replace("u", "");
                }
                noVowelsLength = linesCopy[x].Length;

                if(noVowelsLength > mostVowels)
                {
                    mostVowels = wordLength - noVowelsLength;
                    mostVowelsIndex = x;
                }
            }

            finalText.Items.Add("The first word with the most vowels is: ");
            finalText.Items.Add("");
            finalText.Items.Add(lines[mostVowelsIndex] + " with " + mostVowels + " vowels.");

            // Saving to a file
            const string sPath = "SaveFile.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in finalText.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            MessageBox.Show("Program is Saved!");
        }
    }
}
