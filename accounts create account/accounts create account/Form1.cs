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
    public partial class Form1 : Form
    {
        string accounts;
        string gender;
        SqlConnection con;
        SqlDataReader R;
        SqlCommand cmd, cmd2;
        Form2 myForm2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        public void form2_loader()
        {
        myForm2.Opacity=100;
            this.ShowInTaskbar = false;
        }

        private void typebuttons(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            // Current or Savings account
            if (radio == radioButton1)
            {
                accounts = "C";
            }
            else if (radio == radioButton2)
            {
                accounts = "S";
            }
        }

        private void genderbuttons(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio == radioButton3)
            {
                gender = "M";
            }
            else if (radio == radioButton4)
            {
                gender = "F";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\Administrator\\Documents\\Visual Studio 2015\\Projects\\TT\\accounts create account\\accounts create account\\Database1.mdf';Integrated Security=True;multipleactiveresultsets=True;");
            cmd = new SqlCommand();
            cmd2 = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd2.Connection = con;

            cmd.CommandText = "select * from accounts";
            using (R = cmd.ExecuteReader())
            {
                R.Read();
                R.Close();
            }
        }

        private void form1_Shown(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accounts != "" & gender != "" & textBox1.Text != "" & textBox1.Text != "")
            {
                cmd.CommandText = "Insert into account values (@idkey,@name,@address)";
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@address", textBox2.Text);
                string idkey;
                cmd.Parameters.AddWithValue("@accounts", accounts);

                cmd.CommandType = CommandType.Text;
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select format(coalesce(max(substring(accountid,3,3))+1,'000'), '000') AS nomb  from account where accountid like'" + accounts + "%';";
                cmd2.ExecuteNonQuery();

                using (R = cmd2.ExecuteReader())
                    if (R.Read())
                    {
                        string acno = R["nomb"].ToString();
                        idkey = accounts + gender + acno;
                        MessageBox.Show(idkey);
                        cmd.Parameters.AddWithValue("@idkey", idkey);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
            }
            else
                MessageBox.Show("Please input ALL the entries.");
        }
    }
}