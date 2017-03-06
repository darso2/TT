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
    public partial class Form1 : Form
    {
        // Initializing the variables used.
        string operation = "";
        double number1;
        double number2;
        string entry = "";
        string entry2 = "";
        double total;
        public Form1()
        {
            InitializeComponent();
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
        }


        private void calculator(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            //Buttons for all the numbers.
            if (b == button1)
            {
                richTextBox1.Text += "1";
                entry = richTextBox1.Text;
            }

            if (b == button2)
            {
                richTextBox1.Text += "2";
                entry = richTextBox1.Text;
            }
            if (b == button3)
            {
                richTextBox1.Text += "3";
                entry = richTextBox1.Text;
            }
            if (b == button4)
            {
                richTextBox1.Text += "4";
                entry = richTextBox1.Text;
            }
            if (b == button5)
            {
                richTextBox1.Text += "5";
                entry = richTextBox1.Text;
            }
            if (b == button6)
            {
                richTextBox1.Text += "6";
                entry = richTextBox1.Text;
            }
            if (b == button7)
            {
                richTextBox1.Text += "7";
                entry = richTextBox1.Text;
            }
            if (b == button8)
            {
                richTextBox1.Text += "8";
                entry = richTextBox1.Text;
            }
            if (b == button9)
            {
                richTextBox1.Text += "9";
                entry = richTextBox1.Text;
            }
            if (b == button10)
            {
           

                richTextBox1.Text += "0";
                entry = richTextBox1.Text;
            }

            // Assign a tag for the operator, so the equals button can identify operations.
            if (b == button11)
            {
                entry2 = entry;
                operation = "+";
                richTextBox1.ResetText();
            }
            if (b == button12)
            {
                entry2 = entry;
                operation = "-";
                richTextBox1.ResetText();

            }
            if (b == button13)
            {
                entry2 = entry;
                operation = "*";
                richTextBox1.ResetText();

            }
            if (b == button14)
            {
                entry2 = entry;
                operation = "/";
                richTextBox1.ResetText();
            }


            // Total reset button.
            if (b == button15)
            {
                entry = "";
                entry2 = "";
                operation = "";
                richTextBox1.ResetText();
            }


            //Equals button.
            if (b == button16)
            {
                //Converts string to double number
                double.TryParse(entry, out number1);
                double.TryParse(entry2, out number2);
                if (operation == "+")
                {
                    richTextBox1.ResetText();
                    richTextBox1.Text += Convert.ToString((number1+number2));
                    entry = richTextBox1.Text;   //allows continuation of calculator from the result
                }

                if (operation == "-")
                {
                    richTextBox1.ResetText();
                    total = number2 - number1;
                    richTextBox1.Text += Convert.ToString(total);
                    entry = richTextBox1.Text;

                }

                if (operation == "*")
                {
                    richTextBox1.ResetText();
                    total = number2 * number1;
                    richTextBox1.Text += Convert.ToString(total);
                    entry = richTextBox1.Text;

                }

                if (operation == "/")
                {
                    // Zero option hehehe
                    if (entry == "0")
                    {
                        MessageBox.Show("Can't divide by 0, you doofus.\nPress Clear and try again!");

                    }
                    else
                    {
                        richTextBox1.ResetText();
                        total = number2 / number1;
                        richTextBox1.Text += Convert.ToString(total);
                        entry = richTextBox1.Text;
                    }
                }
            }
            if (b == button17)
            {
                button19.Visible = true;
                button20.Visible = true;
                button21.Visible = true; 
                this.Size = new Size(474,371);
                richTextBox1.Width = (434);
                button16.Location = new Point(135,254);
            }
            if (b == button18)
            {
                button19.Visible = false;
                button20.Visible = false;
                button21.Visible = false;
                this.Size = new Size(414, 371);
                richTextBox1.Width = 358;
                button16.Location = new Point(95, 254);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "addition";
        }
        private void button11_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }

}

