using System.Data.SQLite;

namespace MyStock.Data;

public class Database
{
    public SQLiteConnection myConnection;

    public Database()
    {
        myConnection = new SQLiteConnection("Data Source=database.sqlite3");
        if (!File.Exists("./database.sqlite3"))
        {
            SQLiteConnection.CreateFile("database.sqlite3");
            Console.WriteLine("Database was created");
        }
    }

    public void OpenConnection()
    {
        if (myConnection.State != System.Data.ConnectionState.Open)
        {
            myConnection.Open();
        }
    }

    public void CloseConnection()
    {
        if (myConnection.State != System.Data.ConnectionState.Closed)
        {
            myConnection.Close();
        }
    }
    
}