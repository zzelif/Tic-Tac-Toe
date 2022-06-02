using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class formTictactoe : Form
    {
        Player currentPlayer;
        int playerWins = 0;
        int computerWins = 0;
        int counter = 0;

        public formTictactoe()
        {
            InitializeComponent();
        }
        public enum Player
        {
            X,
            O
        }

        private void buttonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.LightGreen;
            Check();
            tmrAI.Start();
        }

        private void playAi(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Text == "" && x.Enabled)
                {
                    x.Enabled = false;
                    currentPlayer = Player.O;
                    x.Text = currentPlayer.ToString();
                    x.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                    Check();
                    break;
                }
                else
                {
                    tmrAI.Stop();
                }
            }
        }

        private void resetGame(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && x.Tag == "play")
                {
                    ((Button)x).Enabled = false;
                    ((Button)x).Text = "";
                    ((Button)x).BackColor = default(Color);
                }
            }
        }
        private void Check()
        {
            if (
        (Btn1.Text == "X" && Btn2.Text == "X" && Btn3.Text == "X") ||//Horizontal
        (Btn4.Text == "X" && Btn5.Text == "X" && Btn6.Text == "X") ||
        (Btn7.Text == "X" && Btn8.Text == "X" && Btn9.Text == "X") ||
        (Btn1.Text == "X" && Btn4.Text == "X" && Btn7.Text == "X") ||//Vertical)
        (Btn2.Text == "X" && Btn5.Text == "X" && Btn8.Text == "X") ||
        (Btn3.Text == "X" && Btn6.Text == "X" && Btn9.Text == "X") ||
        (Btn1.Text == "X" && Btn5.Text == "X" && Btn9.Text == "X") ||//Diagonal
        (Btn3.Text == "X" && Btn5.Text == "X" && Btn7.Text == "X"))
            {
                MessageBox.Show("Player wins");
                playerWins++;
                WON();
                lblScore1.Text = "Player wins-" + playerWins;

            }
            else if (
        (Btn1.Text == "O" && Btn2.Text == "O" && Btn3.Text == "O") ||//Horizontal
        (Btn4.Text == "O" && Btn5.Text == "O" && Btn6.Text == "O") ||
        (Btn7.Text == "O" && Btn8.Text == "O" && Btn9.Text == "O") ||
        (Btn1.Text == "O" && Btn4.Text == "O" && Btn7.Text == "O") ||//Vertical
        (Btn2.Text == "O" && Btn5.Text == "O" && Btn8.Text == "O") ||
        (Btn3.Text == "O" && Btn6.Text == "O" && Btn9.Text == "O") ||
        (Btn1.Text == "O" && Btn5.Text == "O" && Btn9.Text == "O") || //Diagonal
        (Btn3.Text == "O" && Btn5.Text == "O" && Btn7.Text == "O"))
            {
                MessageBox.Show("Computer wins");
                computerWins++;
                WON();
                lblScore2.Text = "Computer wins-" + computerWins;

            }
        }

    }
}
