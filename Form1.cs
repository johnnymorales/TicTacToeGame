using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
	public partial class Form1 : Form
	{
		public enum Player
		{
			X, O
		}

		Player currentPlayer;
		Random random = new Random();
		int playerWinCount = 0;
		int CPUWinCount = 0;
		List<Button> buttons;
		private bool playerTurn = true;

		public Form1()
		{
			InitializeComponent();
			RestartGame();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void CPUmove(object sender, EventArgs e)
		{
			if (buttons.Count > 0)
			{
				int index = random.Next(buttons.Count);
				buttons[index].Enabled = false;
				currentPlayer = Player.O;
				buttons[index].Text = currentPlayer.ToString();
				buttons[index].BackColor = Color.IndianRed;
				buttons.RemoveAt(index);
				CheckGame();
				playerTurn = true;
				EnableButtons();
				CPUTimer.Stop();
			}
		}

		private void PlayerClickButton(object sender, EventArgs e)
		{
			if (!playerTurn) return;

			var button = (Button)sender;

			currentPlayer = Player.X;
			button.Text = currentPlayer.ToString();
			button.Enabled = false;
			button.BackColor = Color.RoyalBlue;
			buttons.Remove(button);
			CheckGame();
			playerTurn = false; //disable player's turn
			DisableButtons(); //disable all buttons
			CPUTimer.Start();
		}

		private void RestartGame(object sender, EventArgs e)
		{
			RestartGame();
		}

		private void CheckGame()
		{
			if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
				|| (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
				|| (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
				|| (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
				|| (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
				|| (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
				|| (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
				|| (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")

				)
			{
				CPUTimer.Stop();
				MessageBox.Show("Congratulations", "You won!");
				playerWinCount++;
				label1.Text = "Player Wins: " + playerWinCount;
				RestartGame();


			}
			else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
				|| (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
				|| (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
				|| (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
				|| (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
				|| (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
				|| (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
				|| (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
				)
			{
				CPUTimer.Stop();
				MessageBox.Show("Continue?", "CPU Wins");
				CPUWinCount++;
				label2.Text = "CPU Wins: " + CPUWinCount;
				RestartGame();
			}
		}
		private void RestartGame()
		{
			buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

			foreach (Button x in buttons)
			{
				x.Enabled = true;
				x.Text = "";
				x.BackColor = Color.LightGray;
			}

			playerTurn = true; //Start with players turn
		}

		private void DisableButtons()
		{
			foreach (Button x in buttons)
			{
				x.Enabled = false;
			}
		}

		private void EnableButtons()
		{
			foreach (Button x in buttons)
			{
				x.Enabled = true;
			}
		}
	}
}
