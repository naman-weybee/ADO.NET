using System;
using System.Data.SqlClient;

namespace SQL_Server_Connection
{
    // Establish connection and create a table
    //class Program
    //{
    //    public void CreateTable()
    //    {
    //        SqlConnection con = null;
    //        try
    //        {
    //            con = new SqlConnection("data source=.; database=Student; integrated security=SSPI");
    //            SqlCommand cm = new SqlCommand("create table student(id int not null, name varchar(100), email varchar(50), join_date date)", con);
    //            con.Open();
    //            cm.ExecuteNonQuery();
    //            Console.WriteLine("Table created Successfully");
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine("OOPs, something went wrong." + e);
    //        }
    //        finally
    //        {
    //            con.Close();
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        new Program().CreateTable();
    //        Console.ReadLine();
    //    }
    //}


    //Insert Data into the Table
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=Student; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date)values('101','jonas stive','jonas@example.com','5/07/2005')", con);
                SqlCommand cm2 = new SqlCommand("insert into student(id, name, email, join_date)values('102','bob stive','bob@example.com','5/09/2015')", con);
                SqlCommand cm3 = new SqlCommand("insert into student(id, name, email, join_date)values('103','yash patel','yash@example.com','8/09/2015')", con);
                SqlCommand cm4 = new SqlCommand("insert into student(id, name, email, join_date)values('104','raj patel','raj@example.com','7/07/2002')", con);
                SqlCommand cm5 = new SqlCommand("insert into student(id, name, email, join_date)values('105','jonny depp','jonny@example.com','9/05/2008')", con);
                con.Open();
                cm.ExecuteNonQuery();
                cm2.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
                cm4.ExecuteNonQuery();
                cm5.ExecuteNonQuery();
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
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
            new Program().CreateTable();
            Console.ReadLine();
        }
    }


    //Retrieve Record
    //class Program
    //{
    //    public void CreateTable()
    //    {
    //        SqlConnection con = null;
    //        try
    //        {
    //            con = new SqlConnection("data source=.; database=Student; integrated security=SSPI");
    //            SqlCommand cm = new SqlCommand("select * from student", con);
    //            con.Open();
    //            cm.ExecuteNonQuery();
    //            SqlDataReader sdr = cm.ExecuteReader();
    //            while (sdr.Read())
    //            {
    //                Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"] + " " + sdr["join_date"]);
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine("OOPs, something went wrong." + e);
    //        }
    //        finally
    //        {
    //            con.Close();
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        new Program().CreateTable();
    //        Console.ReadLine();
    //    }
    //}


    // Deleting Record
    //class Program
    //{
    //    public void CreateTable()
    //    {
    //        SqlConnection con = null;
    //        try
    //        {
    //            con = new SqlConnection("data source=.; database=Student; integrated security=SSPI");
    //            SqlCommand cm = new SqlCommand("delete from student where id='102'", con);
    //            con.Open();
    //            cm.ExecuteNonQuery();
    //            Console.WriteLine("Record Deleted Successfully");
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine("OOPs, something went wrong." + e);
    //        }
    //        finally
    //        {
    //            con.Close();
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        new Program().CreateTable();
    //        Console.ReadLine();
    //    }
    //}
}
