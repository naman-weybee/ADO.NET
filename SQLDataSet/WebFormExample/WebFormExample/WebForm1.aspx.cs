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
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=WebForm; integrated security=SSPI");
                string query = "insert into student(name, email, contact)values('" + txtUserName.Text + "','" + txtEmail.Text + "','" + txtContact.Text + "')";
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