using Microsoft.Data.SqlClient;
using System.Data;

namespace ADO_PROGRAMS.Day3
{
    public class _5_Insert_values
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

                    using (SqlCommand cmd =new SqlCommand("sp_InsertCanteenItems", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Execute
                        cmd.ExecuteNonQuery();

                        // Checking the number of inputs
                        Console.WriteLine("TOtal numbers of affected is ::>> "+rowsAffected);
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
