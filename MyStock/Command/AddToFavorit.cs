using Microsoft.Data.Analysis;
using MyStock;
using MyStock.Data;

namespace WeatherApp.Command;

public class AddToFavorit : CommandFunction
{
    public override async Task ExecutCommand(User user)
    {
        // finding stock info  
        Console.Write("Choose specific company: ");
        var company = Console.ReadLine().ToUpper();
        List<SecurityData> prices = conn.GetDailyPrices(company);
        PrimitiveDataFrameColumn<DateTime> date = new PrimitiveDataFrameColumn<DateTime>("Date", prices.Select(sd => sd.Timestamp));
        PrimitiveDataFrameColumn<decimal> closePrice = new PrimitiveDataFrameColumn<decimal>("Close Price", prices.Select(sd => sd.Close));

        // checking if favorites contains new stock
        var newStock = new Stock(company, date[0]!.Value, closePrice[0]!.Value);
        if (!user.Favorites.Contains(newStock))
        {
            user.Favorites.Add(newStock);
        }
    }
    
}