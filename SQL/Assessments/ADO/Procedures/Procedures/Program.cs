using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Procedures
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        static void Main(string[] args)
        {
            Console.WriteLine("enter employee name");
            string name=Console.ReadLine();
            Console.WriteLine("enter employee salary");
            decimal sal =Convert.ToDecimal( Console.ReadLine());
            Console.WriteLine("enter employeeType");
            char emptype =Convert.ToChar( Console.ReadLine());

            con = new SqlConnection("data source=ICS-LT-5S26573; initial catalog=employeeManagement;" +
                "user id=sa;password=Infinite@552;");
            con.Open();
            cmd = new SqlCommand("add_row_in_employee_Details", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empname", name);
            cmd.Parameters.AddWithValue("empsal", sal);
            cmd.Parameters.AddWithValue("@emptype", emptype);
            int no_of_rows = cmd.ExecuteNonQuery();
            Console.WriteLine($"Inserted {no_of_rows} rows effected successfully.");
            Console.Read();
        }
    }
}
