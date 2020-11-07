using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise6
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dice dice1 = new Dice(Convert.ToInt32(userInputTextBox.Text));
            Dice dice2 = new Dice(Convert.ToInt32(userInputTextBox.Text));
            int iterations = 0;
            Boolean snakeEyes = false;
            Random r = new Random();

            while(snakeEyes == false)
            {
                dice1.rollDie(r);
                dice2.rollDie(r);
                listBox1.Items.Add("The two dice are rolled: " + dice1.getRoll() + " || " + dice2.getRoll());

                if((dice1.getRoll() == dice2.getRoll()) && (dice1.getRoll() == 1))
                {
                    snakeEyes = true;
                }

                iterations++;

            }

            MessageBox.Show("Snake eyes were rolled after " + iterations + " rolls.");

    }
    }

    public class Dice
    {
        public int numOfSides;
        private int roll;
        
        
        public Dice()
        {

        }

        public Dice(int x)
        {
            numOfSides = x;
        }

        public int rollDie(Random r)
        {
            roll = r.Next(1, numOfSides);
            return roll;
        }

        public int getRoll()
        {
            return roll;
        }
    }
}
