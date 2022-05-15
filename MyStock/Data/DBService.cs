using System.Data.SQLite;
using System.Globalization;

namespace MyStock.Data;

public class DBService
{
    
    static string format =  "MM/dd/yyyy HH:mm:ss";


    public static void AddStockToDB(Stock stock)
    {
        Database database = new Database();
    
        string query = "INSERT INTO stock ('name', 'date', 'price') VALUES (@name, @date, @price)";
        SQLiteCommand myCommand = new SQLiteCommand(query, database.myConnection);
        database.OpenConnection();
        myCommand.Parameters.AddWithValue("@name", stock.Name);
        myCommand.Parameters.AddWithValue("@date", stock.Date.ToString());
        myCommand.Parameters.AddWithValue("@price", stock.ClosePrice.ToString());
        var resultIn = myCommand.ExecuteNonQuery();
        database.CloseConnection();
        Console.WriteLine("Stock was added to DB");
    }

    public static List<Stock> UploadStocksFromDB()
    {
        Database database = new Database();

        string Query = "SELECT * FROM stock";
        SQLiteCommand myCommand = new SQLiteCommand(Query, database.myConnection);
        database.OpenConnection();
        SQLiteDataReader result = myCommand.ExecuteReader();
        if (result.HasRows)
        {
            List<Stock> stocks = new List<Stock>();
            while (result.Read())
            {
                var name = result["name"].ToString();
                var date = DateTime.ParseExact(result["date"].ToString(), format, CultureInfo.InvariantCulture);
                var price = decimal.Parse(result["price"].ToString());
                stocks.Add(new Stock(name, date, price));
            }
            Console.WriteLine("Stocks was uploaded from DB");
            return stocks;
        }
        database.CloseConnection();

        return new List<Stock>();
    }

    public static void DeleteStockFromDB(string name)
    {
        Database database = new Database();

        string Query = "DELETE FROM  stock WHERE name = " + "'" + name + "'";
        SQLiteCommand myCommand = new SQLiteCommand(Query, database.myConnection);
        database.OpenConnection();
        var result = myCommand.ExecuteNonQuery();
        database.CloseConnection();
        Console.WriteLine(result);
    }
}