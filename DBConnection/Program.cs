using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection sql = new SqlConnection("Data Source=SASI-PC\\MICROSOFTSQL;Initial Catalog=employee;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tbl_employee", sql);
            sql.Open();
            SqlDataReader dr = cmd.ExecuteReader();


            Console.WriteLine("Name" + "\t\t" + "Department" + "\t\t" + "Gender" +"\t\t" + "Salary" + "\t\t" + "EmpID");
            Console.WriteLine("--------------------------------------------------------------------------------------");

           
            try
            {
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + "\t\t" + dr[1] + "\t\t" + dr[2] + "\t\t" + dr[3] + "\t\t" + dr[4]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
         }
    }
}
