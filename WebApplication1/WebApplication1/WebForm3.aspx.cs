using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public string id;


        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename ='c:\\users\\administrator\\documents\\visual studio 2015\\Projects\\TT\\WebApplication1\\WebApplication1\\App_Data\\Database1.mdf'; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            var name = Request.QueryString["name"];
            usertable.InnerHtml += "Name: " + name + "<br>";
            cmd.CommandText = "SELECT Id from personal_info where name='" + name + "';";
            con.Open();
            using (SqlDataReader r = cmd.ExecuteReader())
            {
                
                while (r.Read())
                {
                    id = r["Id"].ToString();
                }
            }
                cmd.CommandText = "SELECT email FROM emails WHERE userId='" + id + "';";

            using (SqlDataReader r = cmd.ExecuteReader())
            {
                
                while (r.Read())
                {
                    usertable.InnerHtml += "Email: " + r["email"] + "<br>";
                    
                }
            }

                cmd.CommandText = "SELECT skills FROM skills WHERE userId='" + id + "';";
            using (SqlDataReader r = cmd.ExecuteReader())
            {
                
                while (r.Read())
                {
                    usertable.InnerHtml += "Skills: " + r["skills"] + "<br>";
                
                }
            }
        }
    }
}