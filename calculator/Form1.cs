using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace calculator
{
    public partial class main : Form
    {

        double result;
        double a;
        double b;
        double elements = 0;
        char operation_type = ' ';
        public main()
        {
            InitializeComponent();
        }

        public void readBtn(object sender)
        {
            if (elements == 2)
            {
                inputField.Text = "";
                elements = 0;
            }

            Button btn = (Button)sender;
            inputField.Text = inputField.Text + btn.Text;

        }

        public void operate(object sender)
        {
            if (elements == 0)
            {
                double.TryParse(inputField.Text, out a);
                Button btn = (Button)sender;
                inputField.Text = inputField.Text + btn.Text;
                operation_type = btn.Text[0];
                elements++;
            }
            else if (elements == 2)
            {
                double.TryParse(inputField.Text, out a);
                Button btn = (Button)sender;
                inputField.Text = inputField.Text + btn.Text;
                operation_type = btn.Text[0];
                elements = 1;
            }
        }

        public void calculate(object sender)
        {
            if (elements > 0 && operation_type != ' ')
            {
                elements++;
                try
                {
                    b = double.Parse(inputField.Text.Split(operation_type)[1]);
                    switch (operation_type)
                    {
                        case '+':
                            result = a + b;
                            inputField.Text = "" + result;
                            break;
                        case '-':
       
                            // --- add logic --
                            break;

                        case '/':
                            // --- add logic --
                            break;

                        case '*':
                            // --- add logic --

                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    inputField.Text = "0";
                }

                operation_type = ' ';
            }
        }

        // clear input
        private void clearAll_Click(object sender, EventArgs e)
        {
            inputField.Text = "";
            elements = 0;
        }

        // read operands

        private void signPlus_Click(object sender, EventArgs e)
        {
            operate(sender);
        }

        private void signMinus_Click(object sender, EventArgs e)
        {
            operate(sender);
        }

        private void signDivision_Click(object sender, EventArgs e)
        {
            operate(sender);
        }

        private void sign_multiplication_Click(object sender, EventArgs e)
        {
            operate(sender);
        }

        // read operands

        private void button_0_Click(object sender, EventArgs e)
        {
            readBtn(sender);
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            readBtn(sender);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            readBtn(sender);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            readBtn(sender);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            readBtn(sender);
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            readBtn(sender);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            readBtn(sender);
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            readBtn(sender);
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            readBtn(sender);
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            readBtn(sender);
        }

        // read equel
        private void signEquel_Click(object sender, EventArgs e)
        {
            calculate(sender);
        }
    }
}
