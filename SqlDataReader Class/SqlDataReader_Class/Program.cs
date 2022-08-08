using System;
using System.Data.SqlClient;

namespace SqlDataReader_Class
{
    class Program
    {
        public void Connection()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database = student; integrated security = SSPI");
                SqlCommand cm = new SqlCommand("select * from student", con);
                con.Open();
                cm.ExecuteNonQuery();
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                con.Close();
            }
        }
        
        static void Main(string[] args)
        {
            new Program().Connection();
            Console.ReadLine();
        }
    }
}
