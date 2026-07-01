using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Define the connection string to your SQL Server database.
        string connectionString = "Server=your_server;Database=your_database;User Id=your_username;Password=your_password;";

        try
        {
            // Create a SqlConnection object with the connection string.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection.
                connection.Open();

                // Define the SQL query to execute.
                string query = "SELECT FirstName, LastName FROM Employee";

                // Create a SqlCommand object to execute the query and associate it with the SqlConnection.
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query and obtain a SqlDataReader.
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if there are rows in the result set.
                        if (reader.HasRows)
                        {
                            // Iterate through the result set and read data.
                            while (reader.Read())
                            {
                                string firstName = reader["FirstName"].ToString();
                                string lastName = reader["LastName"].ToString();
                                Console.WriteLine($"Name: {firstName} {lastName}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No rows found.");
                        }
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Database connection error: " + ex.Message);
        }
    }
}
