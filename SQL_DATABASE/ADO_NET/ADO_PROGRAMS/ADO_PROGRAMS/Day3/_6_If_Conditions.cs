using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADO_PROGRAMS.Day3
{
    public class _6_If_Conditions
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

                    string query = "select Count(*) from Hostel";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object rowsAffected = cmd.ExecuteScalar();

                        Console.WriteLine("Total numbers of data is is ::>> " + rowsAffected);

                        if((int)rowsAffected > 9)
                        {
                            string deleteQuery = "DELETE FROM Hostel WHERE Marks > 60";
                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                            {
                                int deletedRows = deleteCmd.ExecuteNonQuery();
                                Console.WriteLine("Deleted rows count ::>> " + deletedRows);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Showing the data\n");
                            string querySelect ="SELECT RollNumber, StudentName, Marks FROM Hostel";
                            using (SqlCommand selectCmd = new SqlCommand(querySelect, conn))
                            using (SqlDataReader reader = selectCmd.ExecuteReader())
                            {
                                Console.WriteLine("Roll\tName\tMarks");
                                Console.WriteLine("-----------------------------");
                                while (reader.Read())
                                {
                                    Console.WriteLine( reader["RollNumber"] + "\t" + reader["StudentName"] + "\t" + reader["Marks"]);
                                }
                            }
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
