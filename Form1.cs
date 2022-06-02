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
            if (Btn1.Text == Btn2.Text && Btn2.Text == Btn3.Text ||
                Btn4.Text == Btn5.Text && Btn5.Text == Btn6.Text ||
                Btn7.Text == Btn8.Text && Btn8.Text == Btn9.Text ||
                Btn1.Text == Btn4.Text && Btn4.Text == Btn7.Text ||
                Btn2.Text == Btn5.Text && Btn5.Text == Btn8.Text ||
                Btn3.Text == Btn6.Text && Btn6.Text == Btn9.Text ||
                Btn1.Text == Btn5.Text && Btn5.Text == Btn9.Text ||
                Btn3.Text == Btn5.Text && Btn5.Text == Btn7.Text) ;
        }
    }
}
