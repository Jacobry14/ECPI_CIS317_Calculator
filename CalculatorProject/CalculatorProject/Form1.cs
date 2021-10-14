using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class Calculator : Form
    {
        Double value1 = 0;
        Double value2 = 0;
        String operation = "";
        bool operationPressed = false;
        bool newNumber = true;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            if (newNumber == true)
            {
                txtDisplay.Text = "0";
            }
        }

        private void NumberClick(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (operationPressed) || (newNumber == true))
            {
                newNumber = false;
                txtDisplay.Clear();
            }

            operationPressed = false;
            Button number;
            number = (System.Windows.Forms.Button)sender;
            txtDisplay.Text += number.Text;
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button _operator = (Button)sender;

                btnEqual.PerformClick();

                operation = _operator.Text;
                value1 = Double.Parse(txtDisplay.Text);
                operationPressed = true;
                txtCurrentEquation.Text = txtDisplay.Text + " " + _operator.Text + " ";
        }

        private void ClearInputClick(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void EqualClick(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    value2 = Double.Parse(txtDisplay.Text);
                    txtDisplay.Text = (value1 + Double.Parse(txtDisplay.Text)).ToString();
                    txtCurrentEquation.Text += value2 + " = ";
                    newNumber = true;
                    break;
                case "-":
                    value2 = Double.Parse(txtDisplay.Text);
                    txtDisplay.Text = (value1 - Double.Parse(txtDisplay.Text)).ToString();
                    txtCurrentEquation.Text += value2 + " = ";
                    newNumber = true;
                    break;
                case "*":
                    value2 = Double.Parse(txtDisplay.Text);
                    txtDisplay.Text = (value1 * Double.Parse(txtDisplay.Text)).ToString();
                    txtCurrentEquation.Text += value2 + " = ";
                    newNumber = true;
                    break;
                case "/":
                    value2 = Double.Parse(txtDisplay.Text);
                    txtDisplay.Text = (value1 / Double.Parse(txtDisplay.Text)).ToString();
                    txtCurrentEquation.Text += value2 + " = ";
                    newNumber = true;
                    break;
                default:
                    break;
            }//end switch
            operation = "";
        }//end equalClick

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtCurrentEquation.Clear();
            Double value1 = 0;
            Double value2 = 0;
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text = txtDisplay.Text;
            }
            else
            {
                txtDisplay.Text += ".";
            }
        }

        
    }
}
