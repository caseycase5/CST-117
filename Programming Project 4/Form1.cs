using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int[,] gameBoard = new int[3, 3];
            Random rand = new Random();
            bool winner = false;
            int winnerValue = 2;
            String winningTeam = null;
            int numOfWinners = 0;
			Label[] labels = { box1, box2, box3, box4, box5, box6, box7, box8, box9 };
			int labelIndex = 0;
			int xCount = 0;
			int oCount = 0;

            // Adding to array
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
					// Ensuring that only a MAX of 5 of a single letter are on the board
					if (xCount < 5 && oCount < 5)
					{
						gameBoard[i, x] = rand.Next(2);
						if (gameBoard[i,x] == 0)
                        {
							oCount++;
                        }
						else if(gameBoard[i, x] == 1)

						{
							xCount++;
						}
					}
					else if (xCount == 5)
					{
						gameBoard[i, x] = 0;
					}
					else if(oCount == 5)
                    {
						gameBoard[i, x] = 1;
                    }
                }
            }
		
			// Changing boxes in form to match their value
			for(int i = 0; i < 3; i++)
            {
				for (int x = 0; x < 3; x++)
				{
						if (gameBoard[i, x] == 0)
						{
							labels[labelIndex].Text = "O";
							labelIndex++;
						}
						else
                        {
							labels[labelIndex].Text = "X";
							labelIndex++;
					}	
				}
			}


			// Horizontal winners
			if ((gameBoard[0, 0] == gameBoard[0, 1]) && (gameBoard[0, 0] == gameBoard[0, 2]))
			{
				winner = true;
				winnerValue = gameBoard[0, 0];
				numOfWinners++;
			}
			if ((gameBoard[1, 0] == gameBoard[1, 1]) && (gameBoard[1, 0] == gameBoard[1, 2]))
			{
				winner = true;
				winnerValue = gameBoard[1, 0];
				numOfWinners++;
			}
			if ((gameBoard[2, 0] == gameBoard[2, 1]) && (gameBoard[2, 0] == gameBoard[2, 2]))
			{
				winner = true;
				winnerValue = gameBoard[2, 0];
				numOfWinners++;
			}

			// Vertical Winners
			if ((gameBoard[0, 0] == gameBoard[1, 0]) && (gameBoard[0, 0] == gameBoard[2, 0]))
			{
				winner = true;
				winnerValue = gameBoard[0, 0];
				numOfWinners++;
			}
			if ((gameBoard[0, 1] == gameBoard[1, 1]) && (gameBoard[0, 1] == gameBoard[2, 1]))
			{
				winner = true;
				winnerValue = gameBoard[0, 1];
				numOfWinners++;
			}
			if ((gameBoard[0, 2] == gameBoard[1, 2]) && (gameBoard[0, 2] == gameBoard[2, 2]))
			{
				winner = true;
				winnerValue = gameBoard[0, 2];
				numOfWinners++;
			}

			// Diagonal Winners
			if ((gameBoard[0, 0] == gameBoard[1, 1]) && (gameBoard[0, 0] == gameBoard[2, 2]))
			{
				winner = true;
				winnerValue = gameBoard[0, 0];
				numOfWinners++;
			}
			if ((gameBoard[0, 2] == gameBoard[1, 1]) && (gameBoard[0, 2] == gameBoard[2, 0]))
			{
				winner = true;
				winnerValue = gameBoard[0, 2];
				numOfWinners++;
			}

			// Determining which side won
			if (numOfWinners == 0)
			{
				winnerLabel.Text = ("The game is a tie.");
			}

			else if (winnerValue == 0)
			{
				winningTeam = "O";
			}
			else if (winnerValue == 1)
			{
				winningTeam = "X";
			}

			// Printing the winner
			if (winner)
			{
				winnerLabel.Text = "The winner is " + winningTeam;
			}
		}

        private void stepButton_Click(object sender, EventArgs e)
        {

        }
    }
}
