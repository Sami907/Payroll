using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollMSLibrary
{
    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection sqlConnection = null;

            string filePath = @"D:\\Project\\Visual Studio Projects\\Payroll\\PayrollMS\\PayrollMS\\Properties\\ConnectionFile.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    string SConnectionString = File.ReadAllText(filePath);
                    sqlConnection = new SqlConnection(SConnectionString);
                }
                else
                {
                    Console.WriteLine("The file does not exist.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file: " + e.Message);
            }

            return sqlConnection;
        }
    }
}
