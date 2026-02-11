using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADO_PROGRAMS.Day3
{
    public class _7_Calling_Function
    {
        static string connectionString =
            "Server=localhost\\SQLEXPRESS;" +
            "Database=_2_TEST;" +
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True;";


        public static void main()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("COnnection Stablished successfully");

                    string query = "SELECT dbo.SQUARENUM(@num)";
                    using(SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@num", 6);
                        int square = Convert.ToInt32(command.ExecuteScalar());
                        Console.WriteLine("Square of the 6 is " + square);
                    }
                }
            }catch(SqlException ex)
            {
                Console.WriteLine("Sql Error : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
        }
    }
}
