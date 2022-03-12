using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int playernum = 0;
        int count = 0;
        int player1p  = 0;
        int player2p = 0;
        Player player1 = new Player();
        Player player2 = new Player(); 

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == null)
            {
                MessageBox.Show("place already taken");
            }
            if (playernum == 0)
            {
                button1.Text = "O";
                player1.a1 = 1;
                player1.win();
                if (player1.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player1p++;
                }playernum = 1;
                count++;
                if(count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }else if(playernum == 1)
            {
                button1.Text = "X";
                player2.a1 = 1;
                player2.win();
                if (player2.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player2p++;
                }
                playernum = 0;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == null)
            {
                MessageBox.Show("place already taken");
            }
            if (playernum == 0)
            {
                button2.Text = "O";
                player1.a2 = 1;
                player1.win();
                if (player1.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player1p++;
                }
                playernum = 1;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                    player2p++;
                }
            }
            else if (playernum == 1)
            {
                button2.Text = "X";
                player2.a2 = 1;
                player2.win();
                if (player2.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player1p++;
                }
                playernum = 0;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (button3.Text == null)
            {
                MessageBox.Show("place already taken");
                player2p++;
            }
            if (playernum == 0)
            {
                button3.Text = "O";
                player1.a3 = 1;
                player1.win();
                if (player1.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player1p++;
                }
                playernum = 1;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
            else if (playernum == 1)
            {
                button3.Text = "X";
                player2.a3 = 1;
                player2.win();
                if (player2.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player2p++;
                }
                playernum = 0;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (button4.Text == null)
            {
                MessageBox.Show("place already taken");
            }
            if (playernum == 0)
            {
                button4.Text = "O";
                player1.a4 = 1;
                player1.win();
                if (player1.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player1p++;
                }
                playernum = 1;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
            else if (playernum == 1)
            {
                button4.Text = "X";
                player2.a4 = 1;
                player2.win();
                if (player2.ck == 1)
                {
                    MessageBox.Show("player2 won");
                    player2p++;
                }
                playernum = 0;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (button5.Text == null)
            {
                MessageBox.Show("place already taken");
            }
            if (playernum == 0)
            {
                button5.Text = "O";
                player1.a5 = 1;
                player1.win();
                if (player1.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player1p++;
                }
                playernum = 1;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
            else if (playernum == 1)
            {
                button5.Text = "X";
                player2.a5 = 1;
                player2.win();
                if (player2.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player2p++;
                }
                playernum = 0;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (button6.Text == null)
            {
                MessageBox.Show("place already taken");
            }
            if (playernum == 0)
            {
                button6.Text = "O";
                player1.a6 = 1;
                player1.win();
                if (player1.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player1p++;
                }
                playernum = 1;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
            else if (playernum == 1)
            {
                button6.Text = "X";
                player2.a6 = 1;
                player2.win();
                if (player2.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player2p++;
                }
                playernum = 0;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (button7.Text == null)
            {
                MessageBox.Show("place already taken");
            }
            if (playernum == 0)
            {
                button7.Text = "O";
                player1.a7 = 1;
                player1.win();
                if (player1.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player1p++;
                }
                playernum = 1;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
            else if (playernum == 1)
            {
                button7.Text = "X";
                player2.a7 = 1;
                player2.win();
                if (player2.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player2p++;
                }
                playernum = 0;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (button8.Text == null)
            {
                MessageBox.Show("place already taken");
            }
            if (playernum == 0)
            {
                button8.Text = "O";
                player1.a8 = 1;
                player1.win();
                if (player1.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player1p++;
                }
                playernum = 1;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
            else if (playernum == 1)
            {
                button8.Text = "X";
                player2.a8 = 1;
                player2.win();
                if (player2.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player2p++;
                }
                playernum = 0;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (button9.Text == null)
            {
                MessageBox.Show("place already taken");
            }
            if (playernum == 0)
            {
                button9.Text = "O";
                player1.a9 = 1;
                player1.win();
                if (player1.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player1p++;
                }
                playernum = 1;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
            else if (playernum == 1)
            {
                button9.Text = "X";
                player2.a9 = 1;
                player2.win();
                if (player2.ck == 1)
                {
                    MessageBox.Show("player1 won");
                    player2p++;
                }
                playernum = 0;
                count++;
                if (count == 9)
                {
                    MessageBox.Show("Draw");
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            button1.Text = null;
            button2.Text = null;
            button3.Text = null;
            button4.Text = null;
            button5.Text = null;
            button6.Text = null;
            button7.Text = null;
            button8.Text = null;
            button9.Text = null;
            player1.toZero();
            player2.toZero();
            playernum = 0;
            count = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("player1 score:"+Convert.ToString(player1p)+"player2score:"+Convert.ToString(player2p));
        }
    }
}
