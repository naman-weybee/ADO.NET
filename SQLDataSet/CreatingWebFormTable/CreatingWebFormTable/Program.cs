using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CreatingWebFormTable
{
    class CreatingTable
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
            Console.ReadLine();
        }

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=WebForm; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("create table student(id int not null IDENTITY(1,1), name varchar(100), email varchar(50), contact varchar(50))", con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully");
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
