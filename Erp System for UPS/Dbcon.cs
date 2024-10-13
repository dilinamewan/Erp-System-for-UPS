using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;

public class Dbcon
{
    private MySqlConnection conn;

    public Dbcon()
    {
        conn = null;
    }

    // Connect to the database
    public async Task Connect()
    {
        string connectionString = "Server=localhost;Port=3306;Database=ups;Uid=root;Pwd=;";
        conn = new MySqlConnection(connectionString);
        await conn.OpenAsync();
    }

    // Disconnect the database
    public void Disconnect()
    {
        conn?.Close();
    }

    // Execute a SELECT query and return a data reader
    public async Task<MySqlDataReader> ExecuteQuery(string query, Dictionary<string, object> parameters = null)
    {
        MySqlCommand cmd = new MySqlCommand(query, conn);

        // If parameters are provided, add them to the command
        if (parameters != null)
        {
            foreach (var param in parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
        }

        DbDataReader reader = await cmd.ExecuteReaderAsync();
        return (MySqlDataReader)reader;
    }

    // Execute a non-query (INSERT, UPDATE, DELETE) and return the number of affected rows
    public async Task<int> ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
    {
        using (var command = new MySqlCommand(query, conn))
        {
            // If parameters are provided, add them to the command
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            return await command.ExecuteNonQueryAsync();
        }
    }

    // Execute a scalar query and return a single value (useful for retrieving auto-generated IDs)
    public async Task<object> ExecuteScalar(string query, Dictionary<string, object> parameters = null)
    {
        using (var command = new MySqlCommand(query, conn))
        {
            // If parameters are provided, add them to the command
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            return await command.ExecuteScalarAsync();
        }
    }


    // Method to add a new package to the Packagestracker table
    public async Task<int> AddPackage(string currentLocation, string status, string destination, double weight, string sender, string recipient, DateTime creationDate, DateTime estimatedDeliveryDate)
    {
        string query = "INSERT INTO Packagestracker (CurrentLocation, Status, Destination, Weight, Sender, Recipient, CreationDate, EstimatedDeliveryDate) " +
                       "VALUES (@CurrentLocation, @Status, @Destination, @Weight, @Sender, @Recipient, @CreationDate, @EstimatedDeliveryDate)";
        var parameters = new Dictionary<string, object>
        {
            { "@CurrentLocation", currentLocation },
            { "@Status", status },
            { "@Destination", destination },
            { "@Weight", weight },
            { "@Sender", sender },
            { "@Recipient", recipient },
            { "@CreationDate", creationDate },
            { "@EstimatedDeliveryDate", estimatedDeliveryDate }
        };

        return await ExecuteNonQuery(query, parameters);
    }

    // Method to get all packages from the Packagestracker table
    public async Task<MySqlDataReader> GetAllPackages()
    {
        string query = "SELECT * FROM Packagestracker";
        return await ExecuteQuery(query);
    }
}
