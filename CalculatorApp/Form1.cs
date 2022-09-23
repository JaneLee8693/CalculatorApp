// Author: Jane Lee
// Description: Win form calculator app with C#

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string input = string.Empty; // String storing user input
        string operand1 = string.Empty; // String storing first operand
        string operand2 = string.Empty; //String storing second operand
        char operation; // Char for operation (+-*/)
        double result = 0.0; // Calculated result

        public Form1()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            this.calculatorDisplay.Text = "";
            input += "0";
            this.calculatorDisplay.Text += input;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            this.calculatorDisplay.Text = "";
            input += "1";
            this.calculatorDisplay.Text += input;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            this.calculatorDisplay.Text = "";
            input += "2";
            this.calculatorDisplay.Text += input;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            this.calculatorDisplay.Text = "";
            input += "3";
            this.calculatorDisplay.Text += input;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            this.calculatorDisplay.Text = "";
            input += "4";
            this.calculatorDisplay.Text += input;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            this.calculatorDisplay.Text = "";
            input += "5";
            this.calculatorDisplay.Text += input;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            this.calculatorDisplay.Text = "";
            input += "6";
            this.calculatorDisplay.Text += input;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            this.calculatorDisplay.Text = "";
            input += "7";
            this.calculatorDisplay.Text += input;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            this.calculatorDisplay.Text = "";
            input += "8";
            this.calculatorDisplay.Text += input;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            this.calculatorDisplay.Text = "";
            input += "9";
            this.calculatorDisplay.Text += input;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            this.calculatorDisplay.Text = "";
            input += ".";
            this.calculatorDisplay.Text += input;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            // Plus
            if (operation == '+')
            {
                result = num1 + num2;
                calculatorDisplay.Text = result.ToString();
            }
            // Minus
            else if (operation == '-')
            {
                result = num1 - num2;
                calculatorDisplay.Text = result.ToString();
            }
            // Multiply
            else if (operation == '*')
            {
                result = num1 * num2;
                calculatorDisplay.Text = result.ToString();
            }
            // Divide
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    calculatorDisplay.Text = result.ToString();
                }
                else
                {
                    calculatorDisplay.Text = "DIV/0";
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.calculatorDisplay.Text = "0";

        }

        private void clearLastButton_Click(object sender, EventArgs e)
        {
            // If the calculation is not empty, remove the last number/operator entered
            if (input.Length > 0)
            {
                input = input.Remove(input.Length - 1, 1);
                this.calculatorDisplay.Text = input;
            }
            else if (input.Length <= 0)
            {
                this.calculatorDisplay.Text = "0";
            }
        }
    }
}
