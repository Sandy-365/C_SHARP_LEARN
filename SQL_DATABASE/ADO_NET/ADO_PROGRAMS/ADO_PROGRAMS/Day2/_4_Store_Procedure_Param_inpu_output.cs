using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADO_PROGRAMS.Day2
{
    public class _4_Store_Procedure_Param_inpu_output
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

                    using (SqlCommand cmd =
                        new SqlCommand("GetAverageSalaryByDeptAndGrade", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // 🔹 INPUT parameter 1
                        cmd.Parameters.Add("@DeptName", SqlDbType.VarChar, 50).Value = "IT";

                        // 🔹 INPUT parameter 2
                        cmd.Parameters.Add("@Grade", SqlDbType.Int).Value = 3;

                        // 🔹 OUTPUT parameter
                        SqlParameter avgSalaryParam = new SqlParameter("@AvgSalary", SqlDbType.Float);
                        avgSalaryParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(avgSalaryParam);

                        // Execute
                        cmd.ExecuteNonQuery();

                        // Read OUTPUT value
                        Console.WriteLine("Average Salary = " + avgSalaryParam.Value);
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
