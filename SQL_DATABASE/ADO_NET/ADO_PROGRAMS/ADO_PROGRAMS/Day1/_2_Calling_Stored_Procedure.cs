using System;
using Microsoft.Data.SqlClient;

namespace ADO_PROGRAMS.Day1
{
    class _2_Calling_Stored_Procedure
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
