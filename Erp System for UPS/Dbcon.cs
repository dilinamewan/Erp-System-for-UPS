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


    public async Task Connect()
    {
        string connectionString = "Server=localhost;Port=3306;Database=ups;Uid=root;Pwd=;";
        conn = new MySqlConnection(connectionString);
        await conn.OpenAsync();
    }


    public void Disconnect()
    {
        conn?.Close();
    }

  
    public async Task<MySqlDataReader> ExecuteQuery(string query, Dictionary<string, object> parameters = null)
    {
        MySqlCommand cmd = new MySqlCommand(query, conn);

       
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

    
    public async Task<int> ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
    {
        using (var command = new MySqlCommand(query, conn))
        {
       
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

   
    public async Task<object> ExecuteScalar(string query, Dictionary<string, object> parameters = null)
    {
        using (var command = new MySqlCommand(query, conn))
        {
           
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

    internal MySqlConnection GetConnection()
    {
        throw new NotImplementedException();
    }
}

