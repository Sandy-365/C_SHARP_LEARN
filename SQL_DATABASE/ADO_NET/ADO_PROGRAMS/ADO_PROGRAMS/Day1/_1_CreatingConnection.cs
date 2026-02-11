using System;
using System.Collections.Generic;
using System.Text;

namespace ADO_PROGRAMS.Day1
{
    using System;
    using Microsoft.Data.SqlClient;

    class _1_CreatingConnection

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

                    string query = "SELECT Id, ItemName, Price FROM CanteenItemMaster";
                    Console.WriteLine(query);

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine(reader);
                        Console.WriteLine("Id\tItemName\tPrice");
                        Console.WriteLine("--------------------------------");

                        while (reader.Read())
                        {
                            Console.WriteLine(
                                reader["Id"] + "\t" +
                                reader["ItemName"] + "\t" +
                                reader["Price"]
                            );
                        }
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
