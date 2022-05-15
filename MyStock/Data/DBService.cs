using System.Data.SQLite;
using System.Globalization;

namespace MyStock.Data;

public class DBService
{
    
    static string format =  "MM/dd/yyyy HH:mm:ss";
    
    
    public static void AddStockToDB(Stock stock)
    {
        Database database = new Database();
    
        string queryIn = "INSERT INTO stock ('name', 'date', 'price') VALUES (@name, @date, @price)";
        SQLiteCommand myCommandIn = new SQLiteCommand(queryIn, database.myConnection);
        database.OpenConnection();
        myCommandIn.Parameters.AddWithValue("@name", stock.Name);
        myCommandIn.Parameters.AddWithValue("@date", stock.Date.ToString());
        myCommandIn.Parameters.AddWithValue("@price", stock.ClosePrice.ToString());
        var resultIn = myCommandIn.ExecuteNonQuery();
        database.CloseConnection();
        Console.WriteLine("Stock was added to DB");
    }

    public static List<Stock> UploadStocksFromDB()
    {
        Database database = new Database();

        string QueryOut = "SELECT * FROM stock";
        SQLiteCommand myCommandOut = new SQLiteCommand(QueryOut, database.myConnection);
        database.OpenConnection();
        SQLiteDataReader resultOut = myCommandOut.ExecuteReader();
        if (resultOut.HasRows)
        {
            List<Stock> stocks = new List<Stock>();
            while (resultOut.Read())
            {
                var name = resultOut["name"].ToString();
                var date = DateTime.ParseExact(resultOut["date"].ToString(), format, CultureInfo.InvariantCulture);
                var price = decimal.Parse(resultOut["price"].ToString());
                stocks.Add(new Stock(name, date, price));
            }
            Console.WriteLine("Stocks was uploaded from DB");
            return stocks;
        }
        database.CloseConnection();

        return new List<Stock>();
    }
}