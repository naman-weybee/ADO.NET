using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable table = new DataTable();
        table.Columns.Add("Id");
        table.Columns.Add("Name");
        table.Columns.Add("Email");
        table.Rows.Add("101", "Rameez", "rameez@example.com");
        table.Rows.Add("102", "Sam Nicolus", "sam@example.com");
        table.Rows.Add("103", "Subramanium", "subramanium@example.com");
        table.Rows.Add("104", "Ankur Kumar", "ankur@example.com");
        GridView1.DataSource = table;
        GridView1.DataBind();
    }
}