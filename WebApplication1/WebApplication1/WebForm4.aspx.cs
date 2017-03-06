using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename ='c:\\users\\administrator\\documents\\visual studio 2015\\Projects\\TT\\WebApplication1\\WebApplication1\\App_Data\\Database1.mdf'; Integrated Security = True");

            SqlCommand cmd = new SqlCommand();
        string name;
        string address;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            name = Request.QueryString["name"];
            address = Request.QueryString["address"];

            TextBox1.Text = name;
            TextBox2.Text = address;
        }     
               
        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            cmd.CommandText = "UPDATE personal_info SET name='"+TextBox1.Text+"' city='"+TextBox2.Text+"' where name='" + name + "AND address='" + address + "';";
            using (SqlDataReader r = cmd.ExecuteReader())
                while (r.Read())
                {
                }
        }
    }
}