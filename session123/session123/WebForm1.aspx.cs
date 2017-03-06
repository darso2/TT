using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace session123
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "Rabbithole";
            Session["data"] = TextBox2.Text;
            Response.Redirect("WebForm2.aspx");
        }
    }
}