using System;
using System.Data.SqlClient;

namespace MyADO.NetApp
{
    class Program
    {
        static void Main(string[] args)
        {
          

        }
    }
}
/* public const string ConnectionString = @"Data Source=CODLING;Initial Catalog=ITCompany;Integrated Security=SSPI;";
        static void Main(string[] args)
        {
            var queryString = "SELECT * FROM Employees";

            using var connStr = new SqlConnection(ConnectionString);
            connStr.Open();

            SqlCommand command = new(queryString, connStr);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                
                while (reader.Read())
                {
                    Console.WriteLine(reader[7].ToString() +". "+  reader[0].ToString() + "/ " + reader[1].ToString() + "/ " + reader[2].ToString() + "/ " + reader[3].ToString() + "/ " + reader[4].ToString() + "/ " + reader[5].ToString() + "/ " + Convert.ToDateTime(reader[6]).ToString("yyyy/MM/dd"));
                   
                }
            }

            Console.WriteLine("************************************************************");

            var queryString2 = " select PMName, count(*) from ProjectManagers join Employees on Employees.ReportingTo = ProjectManagers.PMID Group by PMName Order by count(*) asc  ";

            SqlCommand command2 = new(queryString2, connStr);
            using (SqlDataReader reader = command2.ExecuteReader())
            {
                var i = 1;
                while (reader.Read())
                {
                    Console.WriteLine($"{i}. "+ reader[0].ToString() + "/ " + reader[1].ToString());
                    i++;
                }
            }

            connStr.Close();

        }*/
