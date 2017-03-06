using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringApplication
{
    public partial class Form1 : Form
    {
        string s,s1;
        string[] r;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            s = textBox1.Text;
            Button b = (Button)sender;
            if ((String.IsNullOrEmpty(s) & b == button1) || s.Trim() == "")
            {
                MessageBox.Show("Please enter a word.");
                return;
            }

            else
            {
                r = s.Split();
                textBox2.Text = Convert.ToString((r.Count()));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            StringBuilder con = new StringBuilder();
            textBox4.Text = "";
            s = textBox3.Text;
            r=s.Split();
            for (int i = 0; i <= r.Count()-1; i++)
            {
                s1 = r[i];
                textBox4.Text += " ";
                for (int j = 0; j <= s1.Length -1; j++)
                {

                    if (char.IsUpper(s1[j]))
                    {
                        con = con.Append(char.ToLower(s1[j]));
                        textBox4.Text += con;
                        con.Clear();
                    }

                    else if (char.IsLower(s1[j]))
                    {
                        con = con.Append(char.ToUpper(s1[j]));
                        textBox4.Text += con;
                        con.Clear();
                    }

                    else if (char.IsNumber(s1[j]))
                    {
                        double x = char.GetNumericValue(s1[j]);
                       
 con =                        con.Append( 2*x);
                        textBox4.Text += con;
                        con.Clear();
                    }

                    else if (char.IsPunctuation(s1[j]))
                    {
 con=                        con.Append(s1[j]);
                        textBox4.Text += con;
                        con.Clear();
                    }
                }

            }
        }
    }
}
