using System;
using System.Data.SqlClient;

namespace WebFormApp
{
    public partial class WebForm2 : System.Web.UI.Page
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
                SqlCommand cm = new SqlCommand("select top 1 * from Student order by id desc", con);
                SqlDataReader sdr = cm.ExecuteReader();
                sdr.Read();
                Label1.Text = "User Name : ";
                Label2.Text = "Email ID : ";
                Label3.Text = "Contact : ";
                Label4.Text = sdr["name"].ToString();
                Label5.Text = sdr["email"].ToString();
                Label6.Text = sdr["contact"].ToString();
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