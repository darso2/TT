using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string name;
        string city;
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
//            var myMessage = "Hello World";
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename ='c:\\users\\administrator\\documents\\visual studio 2015\\Projects\\TT\\WebApplication1\\WebApplication1\\App_Data\\Database1.mdf'; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from personal_info;";

            table.InnerHtml += "<table border = \"1\" width=\"100%\" >";
            table.InnerHtml += "<tr> <th> Name </th> <th> Address </th> <th> Operations </th> </tr>";
            using (SqlDataReader r = cmd.ExecuteReader())
                while (r.Read())
                {
                    id = r[0].ToString();
                    name = r[1].ToString();
                    city = r[2].ToString();
                    table.InnerHtml += "<tr> <td> <a href=\"Webform3.aspx?name=" + name + "\"> " + name + " </a> </td> <td> <a href=\"WebForm2.aspx?city=" + city + "\"> " + city + " </a></td>";
                    table.InnerHtml += "<td> <a href=\"Webform4.aspx?name="+name+"&address="+city+"\">edit </a> , <a href=\"\">delete </a></td>    </tr>";
                }



        }
    }
}