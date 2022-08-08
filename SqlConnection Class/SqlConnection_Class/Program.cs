using System;
using System.Data.SqlClient;

namespace SqlConnection_Class
{
    //class Program
    //{
    //    public void Connecting()
    //    {
    //        SqlConnection con = null;
    //        try
    //        {
    //            con = new SqlConnection("data source=.; database=Student; integrated security=SSPI");
    //            con.Open();
    //            Console.WriteLine("Connection Established Successfully");
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine("OOPs, something went wrong.\n" + e);
    //        }
    //        finally
    //        {
    //            con.Close();
    //            Console.WriteLine("Connection Closed Successfully");
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        new Program().Connecting();
    //        Console.ReadLine();
    //    }
    //}



    class Program
    {
        public void Connecting()
        {
            using (
                SqlConnection con = new SqlConnection("data source=.; database=student; integrated security=SSPI")
            )
            {
                con.Open();
                Console.WriteLine("Connection Established Successfully");
            }
        }
        static void Main(string[] args)
        {
            new Program().Connecting();
            Console.ReadLine();
        }
    }
}