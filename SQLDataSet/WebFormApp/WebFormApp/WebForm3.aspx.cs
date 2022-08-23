using System;
using System.Data.SqlClient;
using System.Data;

namespace WebFormApp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=WebForm; integrated security=SSPI");
                string user = Request.Form["txtUserName"];
                string email = Request.Form["txtEmail"];
                string contact = Request.Form["txtContact"];
                string query = "insert into student(name, email, contact)values('" + user + "','" + email + "','" + contact + "')";
                SqlCommand sc = new SqlCommand(query, con);
                con.Open();
                int status = sc.ExecuteNonQuery();
                Label7.Text = "Your record has been saved with the following details!";
                SqlDataAdapter sde = new SqlDataAdapter("select * from Student", con);
                DataSet ds = new DataSet();
                sde.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong." + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}