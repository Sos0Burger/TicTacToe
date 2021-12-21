using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        
        public TicTacToe()
        {
            InitializeComponent();
        }

        bool isdraw = false;
        int count = 0;

        enum TicTac
        {
            O,
            X
        }
        public void WhoseMove()
        {
            if (count % 2 == 0)
            {
                Whos.Text = "Ходит О";
            }
            else
            {
                Whos.Text = "Ходит X";
            }
        }

        public int TicTacMove()
        {
            if (count % 2 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public void EndGame()
        {
            Draw();
            if (isdraw)
            {
                MessageBox.Show("Победила дружба");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                RestartButton.Enabled = true;
                RestartButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Победили " + (TicTac)TicTacMove());
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                RestartButton.Enabled = true;
                RestartButton.Visible = true;
            }
        }
        public void Draw()
        {
            if (button1.BackColor == Color.Yellow ||
                button2.BackColor == Color.Yellow ||
                button3.BackColor == Color.Yellow ||
                button4.BackColor == Color.Yellow ||
                button5.BackColor == Color.Yellow ||
                button6.BackColor == Color.Yellow ||
                button7.BackColor == Color.Yellow ||
                button8.BackColor == Color.Yellow ||
                button9.BackColor == Color.Yellow)
            {
                isdraw = false;
            }
            else
            {
                isdraw = true;
            }
        }
       

        public void Restart()
        {
            button1.Text = "";
            button1.BackColor = Color.White;
            button1.Enabled = true;

            button2.Text = "";
            button2.BackColor = Color.White;
            button2.Enabled = true;

            button3.Text = "";
            button3.BackColor = Color.White;
            button3.Enabled = true;

            button4.Text = "";
            button4.BackColor = Color.White;
            button4.Enabled = true;

            button5.Text = "";
            button5.BackColor = Color.White;
            button5.Enabled = true;

            button6.Text = "";
            button6.BackColor = Color.White;
            button6.Enabled = true;

            button7.Text = "";
            button7.BackColor = Color.White;
            button7.Enabled = true;

            button8.Text = "";
            button8.BackColor = Color.White;
            button8.Enabled = true;

            button9.Text = "";
            button9.BackColor = Color.White;
            button9.Enabled = true;

            RestartButton.Enabled = false;
            RestartButton.Visible = false;

            count = 0;

            Whos.Text = "Ходит O";

            isdraw = false;
        }
        public void Check()
        {
            if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                |
                (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"))
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                |
                (button4.Text == "X" && button5.Text == "X" && button6.Text == "X"))
            {
                button4.BackColor = Color.Yellow;
                button5.BackColor = Color.Yellow;
                button6.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                |
                (button7.Text == "X" && button8.Text == "X" && button9.Text == "X"))
            {
                button7.BackColor = Color.Yellow;
                button8.BackColor = Color.Yellow;
                button9.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
               |
               (button1.Text == "X" && button4.Text == "X" && button7.Text == "X"))
            {
                button1.BackColor = Color.Yellow;
                button4.BackColor = Color.Yellow;
                button7.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
               |
               (button3.Text == "X" && button6.Text == "X" && button9.Text == "X"))
            {
                button3.BackColor = Color.Yellow;
                button6.BackColor = Color.Yellow;
                button9.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
               |
               (button1.Text == "X" && button5.Text == "X" && button9.Text == "X"))
            {
                button1.BackColor = Color.Yellow;
                button5.BackColor = Color.Yellow;
                button9.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
               |
               (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                button3.BackColor = Color.Yellow;
                button5.BackColor = Color.Yellow;
                button7.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            if ((button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
               |
               (button2.Text == "X" && button5.Text == "X" && button8.Text == "X"))
            {
                button2.BackColor = Color.Yellow;
                button5.BackColor = Color.Yellow;
                button8.BackColor = Color.Yellow;
                EndGame();
                return;
            }

            count++;
            if (count == 9)
            {
                EndGame();
            }
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            
        }

        private void Whos_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString((TicTac)TicTacMove());
            button1.Enabled = false;
            Check();
            WhoseMove();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = Convert.ToString((TicTac)TicTacMove());
            button2.Enabled = false;
            Check();
            WhoseMove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = Convert.ToString((TicTac)TicTacMove());
            button3.Enabled = false;
            Check();
            WhoseMove();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = Convert.ToString((TicTac)TicTacMove());
            button4.Enabled = false;
            Check();
            WhoseMove();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = Convert.ToString((TicTac)TicTacMove());
            button5.Enabled = false;
            Check();
            WhoseMove();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = Convert.ToString((TicTac)TicTacMove());
            button6.Enabled = false;
            Check();
            WhoseMove();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = Convert.ToString((TicTac)TicTacMove());
            button7.Enabled = false;
            Check();
            WhoseMove();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = Convert.ToString((TicTac)TicTacMove());
            button8.Enabled = false;
            Check();
            WhoseMove();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = Convert.ToString((TicTac)TicTacMove());
            button9.Enabled = false;
            Check();
            WhoseMove();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
