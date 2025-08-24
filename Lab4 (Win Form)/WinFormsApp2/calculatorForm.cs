using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class calculatorForm : Form
    {
        string expression = "";
        public calculatorForm()
        {
            InitializeComponent();
        }


        // Numeric Button and Operator Button action
        private void inputString(char c)
        {
            string number = textBox1.Text + c.ToString();
        }


        // Equal to button click event
        private void equalToButton_Click(object sender, EventArgs e)
        {
            List<string> inputTokens = tokenizeInput(textBox1.Text);
            string inputExpressionResult = evaluateInputExpression(inputTokens);
            textBox1.Text = inputExpressionResult;

        }

        // Function to tokenize the input string
        private List<string> tokenizeInput(string input)
        {
            List<string> tokens = new List<string>();
            string number = "";

            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    number += c;
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    if (number != "")
                    {
                        tokens.Add(number);
                        number = "";
                    }
                    tokens.Add(c.ToString());

                }
            }

            // Add any remaining number to the tokens
            if (number != "")
                tokens.Add(number);

            return tokens;
        }

        private string evaluateInputExpression(List<string> inputTokenList)
        {
            // first perform * and / operations and save new expression
            for (int i = 0; i < inputTokenList.Count; i++)
            {
                if (inputTokenList[i] == "*" || inputTokenList[i] == "/")
                {
                    double numberOnLeft = Convert.ToDouble(inputTokenList[i - 1]);
                    double numberOnRight = Convert.ToDouble(inputTokenList[i + 1]);

                    if (numberOnRight == 0)
                    {
                        MessageBox.Show("Error: Division by zero is not allowed.");
                        return ("");
                    }

                    double result = inputTokenList[i] == "*" ? numberOnLeft * numberOnRight : numberOnLeft / numberOnRight;

                    inputTokenList[i - 1] = result.ToString();
                    inputTokenList.RemoveAt(i + 1);
                    inputTokenList.RemoveAt(i);

                    i--;
                }
            }

            // Now perform + and - operations
            double total = Convert.ToDouble(inputTokenList[0]);
            for (int i = 1; i < inputTokenList.Count; i += 2)
            {
                string operatorSign = inputTokenList[i];
                double number = Convert.ToDouble(inputTokenList[i + 1]);

                total = operatorSign == "+" ? total + number : total - number;
            }


            return (total.ToString());
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            expression += btn.Text;
            textBox1.Text = expression;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            expression = "";
            textBox1.Text = expression;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(expression.Length > 0)
            {
                expression = expression.Substring(0, expression.Length - 1);
                textBox1.Text = expression;
            }
        }
    }
}
