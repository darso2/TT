using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace accounts_create_account
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlDataReader R;
        SqlCommand cmd;
        string id;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var acc = textBox1.Text;
            cmd.Parameters.AddWithValue("@acc", acc);
            cmd.CommandText = "Select accountid as id from account where accountid= '@acc';";
            using (R = cmd.ExecuteReader()) {
                {
                    if (R.Read())
                    {
                        id = R["id"].ToString();
                        if (acc == id)
                        {
                            richTextBox1.Text = "No account found \n";
                        }
                        else
                        {
                            richTextBox1.Text = " Account found! \n Your details are listed below";
                            this.Height = 360; label1.Visible = true; label2.Visible = true; label3.Visible = true; textBox2.Visible = true; textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true; button2.Visible = true; button3.Visible = true;
                            cmd.CommandText = "select name,address as name1 from account where accountid='@acc';";
                            using (R = cmd.ExecuteReader())
                            {
                                if (R.Read())
                                {
                                    var name = R["store[0]"].ToString();
                                    var address = R["store[1]"].ToString();

                                }
                            }
                    }
                    }
                    cmd.Parameters.Clear();
                }
            }
        }
   

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Height = 200;
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Administrator\\Documents\\Visual Studio 2015\\Projects\\TT\\accounts create account\\accounts create account\\Database1.mdf';Integrated Security=True;multipleactiveresultsets=True;");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

        }
    }
}
