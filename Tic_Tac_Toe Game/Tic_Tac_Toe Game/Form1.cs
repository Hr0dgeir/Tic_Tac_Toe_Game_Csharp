using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool player1 = true;
        bool player2 = false;
        int score1 = 0;
        int score2 = 0;
        bool btn_1 = true;
        bool btn_2 = true;
        bool btn_3 = true;
        bool btn_4 = true;
        bool btn_5 = true;
        bool btn_6 = true;
        bool btn_7 = true;
        bool btn_8 = true;
        bool btn_9 = true;

        private void button2_Click(object sender, EventArgs e)
        {
            if (btn_2 == true)
            {
                if (player1 == true)
                {
                    button2.Text = "X";
                    player1 = false;
                    player2 = true;
                    btn_2 = false;
                    button2.BackColor = Color.Blue;
                    player_turn();
                }
                else
                {
                    button2.Text = "Y";
                    player2 = false;
                    player1 = true;
                    btn_2 = false;
                    button2.BackColor = Color.Red;
                    player_turn();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btn_3 == true)
            {
                if (player1 == true)
                {
                    button3.Text = "X";
                    player1 = false;
                    player2 = true;
                    btn_3 = false;
                    button3.BackColor = Color.Blue;
                    player_turn();
                }
                else
                {
                    button3.Text = "Y";
                    player2 = false;
                    player1 = true;
                    btn_3 = false;
                    button3.BackColor = Color.Red;
                    player_turn();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (btn_4 == true)
            {
                if (player1 == true)
                {
                    button4.Text = "X";
                    player1 = false;
                    player2 = true;
                    btn_4 = false;
                    button4.BackColor = Color.Blue;
                    player_turn();
                }
                else
                {
                    button4.Text = "Y";
                    player2 = false;
                    player1 = true;
                    btn_4 = false;
                    button4.BackColor = Color.Red;
                    player_turn();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (btn_5 == true)
            {
                if (player1 == true)
                {
                    button5.Text = "X";
                    player1 = false;
                    player2 = true;
                    btn_5 = false;
                    button5.BackColor = Color.Blue;
                    player_turn();
                }
                else
                {
                    button5.Text = "Y";
                    player2 = false;
                    player1 = true;
                    btn_5 = false;
                    button5.BackColor = Color.Red;
                    player_turn();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (btn_6 == true)
            {
                if (player1 == true)
                {
                    button6.Text = "X";
                    player1 = false;
                    player2 = true;
                    btn_6 = false;
                    button6.BackColor = Color.Blue;
                    player_turn();
                }
                else
                {
                    button6.Text = "Y";
                    player2 = false;
                    player1 = true;
                    btn_6 = false;
                    button6.BackColor = Color.Red;
                    player_turn();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (btn_7 == true)
            {
                if (player1 == true)
                {
                    button7.Text = "X";
                    player1 = false;
                    player2 = true;
                    btn_7 = false;
                    button7.BackColor = Color.Blue;
                    player_turn();
                }
                else
                {
                    button7.Text = "Y";
                    player2 = false;
                    player1 = true;
                    btn_7 = false;
                    button7.BackColor = Color.Red;
                    player_turn();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (btn_8 == true)
            {
                if (player1 == true)
                {
                    button8.Text = "X";
                    player1 = false;
                    player2 = true;
                    btn_8 = false;
                    button8.BackColor = Color.Blue;
                    player_turn();
                }
                else
                {
                    button8.Text = "Y";
                    player2 = false;
                    player1 = true;
                    btn_8 = false;
                    button8.BackColor = Color.Red;
                    player_turn();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (btn_9 == true)
            {
                if (player1 == true)
                {
                    button9.Text = "X";
                    player1 = false;
                    player2 = true;
                    btn_9 = false;
                    button9.BackColor = Color.Blue;
                    player_turn();
                }
                else
                {
                    button9.Text = "Y";
                    player2 = false;
                    player1 = true;
                    btn_9 = false;
                    button9.BackColor = Color.Red;
                    player_turn();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_1 == true)
            {
                if (player1 == true)
                {
                    button1.Text = "X";
                    player1 = false;
                    player2 = true;
                    btn_1 = false;
                    button1.BackColor = Color.Blue;
                    player_turn();
                }
                else
                {
                    button1.Text = "Y";
                    player2 = false;
                    player1 = true;
                    btn_1 = false;
                    button1.BackColor = Color.Red;
                    player_turn();
                }
            }
        }
        public void player_turn()
        {
            if (player1 == true)
            {
                Player_turn_label.Text = "Player 1 Turn";
            }
            else
            {
                Player_turn_label.Text = "Player 2 Turn";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            player_turn();
        }

        public void player1_win()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X"||
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Winner is Player 1";
                score1 += 1;
                score1_label.Text = "Player 1 Score = " + score1.ToString();
                Player_turn_label.Text = "Player 1 Turn";
                btn_disable();
                timer1.Stop();
            }
        }
        public void player2_win()
        {
            if (button1.Text == "Y" && button2.Text == "Y" && button3.Text == "Y" ||
                button1.Text == "Y" && button4.Text == "Y" && button7.Text == "Y" ||
                button1.Text == "Y" && button5.Text == "Y" && button9.Text == "Y" ||
                button3.Text == "Y" && button6.Text == "Y" && button9.Text == "Y" ||
                button7.Text == "Y" && button8.Text == "Y" && button9.Text == "Y" ||
                button2.Text == "Y" && button5.Text == "Y" && button8.Text == "Y" ||
                button4.Text == "Y" && button5.Text == "Y" && button6.Text == "Y"||
                button3.Text == "Y" && button5.Text == "Y" && button7.Text == "Y")
            {
                label3.Text = "Winner is Player 2";
                score2 += 1;
                score2_label.Text = "Player 2 Score = " + score2.ToString();
                Player_turn_label.Text = "Player 1 Turn";
                btn_disable();
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player1_win();
            player2_win();
        }

        private void Restart_Button_Click(object sender, EventArgs e)
        {
            button1.Text = ""; button2.Text = ""; button3.Text = ""; button4.Text = ""; button5.Text = ""; button6.Text = "";
            button7.Text = ""; button8.Text = ""; button9.Text = "";

            btn_1 = true; btn_2 = true; btn_3 = true; btn_4 = true; btn_5 = true; btn_6 = true; btn_7 = true; btn_8 = true;
            btn_9 = true;

            button1.BackColor = Color.White; button2.BackColor = Color.White; button3.BackColor = Color.White;
            button4.BackColor = Color.White; button5.BackColor = Color.White; button6.BackColor = Color.White;
            button7.BackColor = Color.White; button8.BackColor = Color.White; button9.BackColor = Color.White;

            player1 = true;
            player2 = false;
            btn_enable();
            timer1.Start();
        }

        public void btn_disable()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        public void btn_enable()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

    }
}
