using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EventManagement
{

public class MySqlConnector
{
    public MySqlConnection connection;
    private string server;
    private string database;
    private string username;
    private string password;

    // constructor
    public MySqlConnector()
    {
        server = "localhost";
        database = "eventmanagement";
        username = "root";
        password = "";
        string connectionString = $"server={server};database={database};uid={username};password={password};";
        connection = new MySqlConnection(connectionString);
    }

    // open the database connection
    public bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            // handle the exception
            return false;
        }
    }

    // close the database connection
    public bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            // handle the exception
            return false;
        }
    }

}

}
