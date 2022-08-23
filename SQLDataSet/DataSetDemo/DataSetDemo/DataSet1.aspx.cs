using System;
using System.Data.SqlClient;
using System.Data;
public partial class DataSet1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection("data source=.; database=student; integrated security=SSPI"))
        {
            SqlDataAdapter sde = new SqlDataAdapter("select * from Student", con);
            DataSet ds = new DataSet();
            sde.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}