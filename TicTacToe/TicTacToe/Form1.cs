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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Counter { get; set; }

        private void Play (object sender)
        {
            if(sender is Button)
            {
                var btn = sender as Button;

                if (btn.Text == "")
                {
                    if (Counter % 2 == 0)
                        btn.Text = "X";
                    else
                        btn.Text = "O";
                    Counter++;
                }
                if(GameOver())
                {
                    SetButton(false);
                }

            }

        }

        private void SetButton(bool enabled, bool resetText = false,bool resetColor=false)
        {
            foreach(var control in this.Controls)
            {
                if(control is Button)
                {
                    var cBtn = control as Button;

                    if (cBtn != button10)
                    { 
                        cBtn.Enabled = enabled;
                        cBtn.Text = resetText ? "" : cBtn.Text;
                        if (resetColor)
                        {
                            cBtn.BackColor = Color.Silver;
                            Counter = 0;
                        }
                    }
                }
            }
        }

        private bool GameOver()
        {
            return CheckRows() || CheckColumns() || CheckDiagonals();
        }
        private bool Win(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Text != "")
            {
                if(btn1.Text==btn2.Text&& btn2.Text == btn3.Text && btn1.Text == btn3.Text)
                {
                    btn1.BackColor = btn2.BackColor = btn3.BackColor = Color.DarkRed;
                    return true;
                }
            }
            return false;
        }
        private bool CheckRows()
        {
            return Win(button1, button2, button3) ||
                Win(button4, button5, button6) ||
                Win(button7, button8, button9);
                
        }
        private bool CheckColumns()
        {
            return Win(button1, button4, button7) ||
                Win(button2, button5, button8) ||
                Win(button3, button6, button9);
        }
        private bool CheckDiagonals()
        {
            return Win(button1, button5, button9) ||
                Win(button3, button5, button7);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Play(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Play(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Play(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Play(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Play(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Play(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Play(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Play(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SetButton(true, true, true);
        }
    }
}
