using System;
using System.Data.SqlClient;

namespace WebFormExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm3.aspx");
        }
    }
}