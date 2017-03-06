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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader R;
        List<string> textarray1 = new List<string>();
        List<string> textarray2 = new List<string>();
        List<string> textarray3 = new List<string>();

        int i;
        int j;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'c:\\users\\administrator\\documents\\visual studio 2015\\Projects\\TT\\WindowsFormsApplication2\\WindowsFormsApplication2\\Database1.mdf'; Integrated Security = True ; multipleactiveresultsets=True;") ;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from school";
            using (SqlDataReader R = cmd.ExecuteReader())
            {
                while (R.Read())
                {
                    textarray1.Add(R["regno"].ToString());
                    textarray2.Add(R["name"].ToString());
                    textarray3.Add(R["marks"].ToString());
                    i++;
                }
                R.Close();
            }
            i = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            j = textarray1.Count - 1;

            if (i <= j)
            {
                textBox1.Text = textarray1[i];
                textBox2.Text = textarray2[i];
                textBox3.Text = textarray3[i];
                i++;
            }
            else
            {
                MessageBox.Show("End of records.");
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_click(object sender, EventArgs e)
        {
            
                cmd.CommandText = "Insert into school values (@rego,@name,@marks)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@rego", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@marks", textBox3.Text);
                    cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();


        }

    }
}

