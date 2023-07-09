using System;
using System.Configuration;
using System.Data.SqlClient;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

      using (SqlConnection connection = new SqlConnection(connectionString))
      {
        try
        {
          connection.Open();
          Console.WriteLine("Connection successful!");
          connection.Close();
        }
        catch (SqlException ex)
        {
          Console.WriteLine("Connection failed: " + ex.Message);
        }
      }
    
  }
  }
}
