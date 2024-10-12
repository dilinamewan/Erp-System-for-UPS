using System;
using System.Data;
using System.Data.SqlClient;

public class DbConnection : IDisposable
{
    private readonly string connectionString;
    private SqlConnection connection;

    public DbConnection(string connectionString)
    {
        this.connectionString = connectionString;
        connection = new SqlConnection(connectionString);
    }

    public void Open()
    {
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void Close()
    {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }

    public int ExecuteNonQuery(string commandText, SqlParameter[] parameters = null)
    {
        using (var command = new SqlCommand(commandText, connection))
        {
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            return command.ExecuteNonQuery();
        }
    }

    public DataTable ExecuteQuery(string commandText, SqlParameter[] parameters = null)
    {
        using (var command = new SqlCommand(commandText, connection))
        {
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            using (var adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }

    public void Dispose()
    {
        Close();
        connection.Dispose();
    }
}
public class Dbcon
{
    private SqlConnection connection;

    public bool Connect()
    {
        try
        {
            // Replace the connection string with your own
            string connectionString = "YourConnectionString";
            connection = new SqlConnection(connectionString);
            connection.Open();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to connect to the database: " + ex.Message);
            return false;
        }
    }

    public DataTable ExecuteQuery(string query)
    {
        DataTable dataTable = new DataTable();
        try
        {
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to execute query: " + ex.Message);
        }
        return dataTable;
    }

    public void Disconnect()
    {
        try
        {
            connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to disconnect from the database: " + ex.Message);
        }
    }
}
