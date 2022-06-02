using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class formTictactoe : Form
    {
        private SoundPlayer soundPlayer;
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
            button.BackColor = System.Drawing.Color.LightGreen;
            Check();
            timerAi.Start();
        }

        private void playAI(object sender, EventArgs e)
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
                    timerAi.Stop();
                }
            }
        }

        private void resetGame(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {

                if (x is Button && x.Tag == "play")
                {
                    ((Button)x).Enabled = true;
                    ((Button)x).Text = "";
                    ((Button)x).BackColor = default(Color);
                }

            }
        }

        private void Check()
        {
            if (
            Btn1.Text == "X" && Btn2.Text == "X" && Btn3.Text == "X" ||//Horizontal
            Btn4.Text == "X" && Btn5.Text == "X" && Btn6.Text == "X" ||
            Btn7.Text == "X" && Btn8.Text == "X" && Btn9.Text == "X" ||
            Btn1.Text == "X" && Btn4.Text == "X" && Btn7.Text == "X" ||//Vertical)
            Btn2.Text == "X" && Btn5.Text == "X" && Btn8.Text == "X" ||
            Btn3.Text == "X" && Btn6.Text == "X" && Btn9.Text == "X" ||
            Btn1.Text == "X" && Btn5.Text == "X" && Btn9.Text == "X" ||//Diagonal
            Btn3.Text == "X" && Btn5.Text == "X" && Btn7.Text == "X")
            {
                soundPlayer = new SoundPlayer("youwin.wav");
                MessageBox.Show("Player Wins");
                playerWins++;
                WON();
                lblScore1.Text = "Player Wins- " + playerWins;
                soundPlayer.PlaySync();
            }
            else if (
            Btn1.Text == "O" && Btn2.Text == "O" && Btn3.Text == "O" ||//Horizontal
            Btn4.Text == "O" && Btn5.Text == "O" && Btn6.Text == "O" ||
            Btn7.Text == "O" && Btn8.Text == "O" && Btn9.Text == "O" ||
            Btn1.Text == "O" && Btn4.Text == "O" && Btn7.Text == "O" ||//Vertical
            Btn2.Text == "O" && Btn5.Text == "O" && Btn8.Text == "O" ||
            Btn3.Text == "O" && Btn6.Text == "O" && Btn9.Text == "O" ||
            Btn1.Text == "O" && Btn5.Text == "O" && Btn9.Text == "O" || //Diagonal
            Btn3.Text == "O" && Btn5.Text == "O" && Btn7.Text == "O")
            {
                soundPlayer = new SoundPlayer("youlose.wav");
                MessageBox.Show("Computer Wins");
                computerWins++;
                WON();
                lblScore2.Text = "Computer Wins- " + computerWins;
                soundPlayer.Play();
            }
            counter = counter + 1;
            if (counter == 9)
            {
                MessageBox.Show("Draw");
                counter = 0;
            }
        }

        private void WON()
        {
            foreach (Control x in this.Controls)
            {

                if (x is Button && x.Tag == "play")
                {
                    ((Button)x).Enabled = false;
                    ((Button)x).BackColor = default(Color);

                }

            }
        }
    }
}
