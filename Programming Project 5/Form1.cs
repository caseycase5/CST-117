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
    public partial class inputForm : Form
    {
        public inputForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int luckyNumber = 0;
            int year;
            int monthNum = 0;
            int day;
            int colorNum = 1;
            String month;
            String color;

            // Determine year
            year = Int32.Parse(comboBoxYear.Text.ToLower());
            luckyNumber = (year / 10) - 22;

            // Determine month
            month = comboBoxMonth.Text.ToLower();
            switch (month)
            {
                case "january":
                    monthNum = 1;
                    break;
                case "february":
                    monthNum = 2;
                    break;
                case "march":
                    monthNum = 3;
                    break;
                case "april":
                    monthNum = 4;
                    break;
                case "may":
                    monthNum = 5;
                    break;
                case "june":
                    monthNum = 6;
                    break;
                case "july":
                    monthNum = 7;
                    break;
                case "august":
                    monthNum = 8;
                    break;
                case "september":
                    monthNum = 9;
                    break;
                case "october":
                    monthNum = 10;
                    break;
                case "november":
                    monthNum = 11;
                    break;
                case "december":
                    monthNum = 12;
                    break;
            }
            luckyNumber = luckyNumber + (monthNum / 2);

            // Determine day
            day = Int32.Parse(comboBoxDay.Text);
            luckyNumber = luckyNumber + (day + 14);

            // Determine color
            color = comboBoxColor.Text.ToLower();
            switch (color)
            {
                case "blue":
                    colorNum = 1;
                    break;
                case "green":
                    colorNum = 2;
                    break;
                case "yellow":
                    colorNum = 3;
                    break;
                case "red":
                    colorNum = 4;
                    break;
                case "purple":
                    colorNum = 5;
                    break;
                case "orange":
                    colorNum = 6;
                    break;
                case "black":
                    colorNum = 7;
                    break;
                case "white":
                    colorNum = 8;
                    break;
            }

            luckyNumber = luckyNumber / colorNum;
            resultForm f2 = new resultForm(luckyNumber.ToString());
            f2.ShowDialog();
            

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            inputForm f1 = new inputForm();
            f1.Show();
            this.Dispose(false);
        }

        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            String month = comboBoxMonth.Text.ToLower();
            if (month.Equals("february"))
            {
                if(comboBoxDay.Items.Count > 29)
                {
                    comboBoxDay.Items.Remove("30");
                    comboBoxDay.Items.Remove("31");

                }
                
            }
            if (month.Equals("april") || month.Equals("june") || month.Equals("september") || month.Equals("november"))
            {
                if (comboBoxDay.Items.Count > 30)
                {
                    comboBoxDay.Items.Remove("31");
                }
                
            }
        }
    }
}
/*

*/