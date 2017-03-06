using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename ='c:\\users\\administrator\\documents\\visual studio 2015\\Projects\\TT\\WebApplication1\\WebApplication1\\App_Data\\Database1.mdf'; Integrated Security = True");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            icity.InnerHtml += "<table border = \"1\" width=\"100%\" >";
            icity.InnerHtml += "<tr> <th> Name </th> <th> Address </th> <th> Operations </th> </tr>";
            var city = Request.QueryString["city"];
            com.CommandText = "select * from personal_info where address ='"+city+"';";
            SqlDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    var name = r[1];
                    var location = r[2];
                    icity.InnerHtml += "<tr> <td> " + name + "</td> <td>" + location + "</td> </td>";
                }

        }
    }
}