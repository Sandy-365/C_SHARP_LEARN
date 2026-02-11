using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADO_PROGRAMS.Day2
{
    public class _3_Store_Procedure_Param_inpu
    {
        public static void main()
        {
            string connectionString =
                "Server=SANDY\\SQLEXPRESS;" +
                "Database=_2_TEST;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Database connected successfully\n");

                    using (SqlCommand cmd = new SqlCommand("GetAverageSalary", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // 🔹 Parameter 1
                        cmd.Parameters.Add("@DeptName", SqlDbType.VarChar, 50).Value = "IT";

                        // 🔹 Parameter 2
                        cmd.Parameters.Add("@Grade", SqlDbType.Int).Value = 3;


                        object result = cmd.ExecuteScalar();
                        Console.WriteLine("Average Salary = " + result);
                    }

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
