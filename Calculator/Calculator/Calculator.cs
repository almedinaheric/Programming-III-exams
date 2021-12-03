using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double first = 0.0;
        double result=0.0;
        string function;
        double second = 0.0;

        private void num0_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text == "0")
                CalculatorDisplay.Text="0";
            else
                CalculatorDisplay.Text += 0;

        }
        private void num1_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text == "0")
                CalculatorDisplay.Text = "1";
            else
                CalculatorDisplay.Text += 1;
        }
        private void num2_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text == "0")
                CalculatorDisplay.Text = "2";
            else
                CalculatorDisplay.Text += 2;
        }
        private void num3_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text == "0")
                CalculatorDisplay.Text = "3";
            else
                CalculatorDisplay.Text += 3;
        }
        private void num4_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text == "0")
                CalculatorDisplay.Text = "4";
            else
                CalculatorDisplay.Text += 4;
        }
        private void num5_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text == "0")
                CalculatorDisplay.Text = "5";
            else
                CalculatorDisplay.Text += 5;
        }
        private void num6_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text == "0")
                CalculatorDisplay.Text = "6";
            else
                CalculatorDisplay.Text += 6;
        }
        private void num7_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text == "0")
                CalculatorDisplay.Text = "7";
            else
                CalculatorDisplay.Text += 7;
        }
        private void num8_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text == "0")
                CalculatorDisplay.Text = "8";
            else
                CalculatorDisplay.Text += 8;
        }
        private void num9_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text == "0")
                CalculatorDisplay.Text = "9";
            else
                CalculatorDisplay.Text += 9;
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += ".";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            function = "+";
            if (result != 0)
                CalculatorDisplay.Text = "0";
            first += Convert.ToDouble(CalculatorDisplay.Text);
            CalculatorDisplay.Text = "";
        }
        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            function = "-";
            if (result != 0)
                CalculatorDisplay.Text = "0";
            first += Convert.ToDouble(CalculatorDisplay.Text);
            CalculatorDisplay.Text = "";
        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            function = "*";
            if (result != 0)
                CalculatorDisplay.Text = "0";
            first += Convert.ToDouble(CalculatorDisplay.Text);
            CalculatorDisplay.Text = "";
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            function = "/";
            if (result != 0)
                CalculatorDisplay.Text = "0";
            first +=Convert.ToDouble(CalculatorDisplay.Text);
            CalculatorDisplay.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(CalculatorDisplay.Text);
            switch (function)
            {
                case "+":
                    result = Math.Round((first + second),5);
                    CalculatorDisplay.Text = Convert.ToString(result);
                    first = result;
                    break;
                case "-":
                    result = Math.Round((first - second), 5);
                    CalculatorDisplay.Text = Convert.ToString(result);
                    first = result;
                    break;
                case "*":
                    result = Math.Round((first * second), 5);
                    CalculatorDisplay.Text = Convert.ToString(result);
                    first = result;
                    break;
                case "/":
                    if (second == 0)
                    {
                        MessageBox.Show("You cannot divide by 0");
                        btnClearAll_Click(sender, e);
                    }
                    else if (first == 0)
                        btnClearAll_Click(sender, e);
                    else
                    {
                        result = Math.Round((first / second), 5);
                        CalculatorDisplay.Text = Convert.ToString(result);
                        first = result;
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "0";
            result = 0.0;
            first = 0.0;
        }
    }
}
