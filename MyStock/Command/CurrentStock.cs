using Microsoft.Data.Analysis;
using MyStock.Data;
using MyStock.Logic;
using WeatherApp.Command;


public class CurrentStock : CommandFunction
{

    public override async Task ExecutCommand()
    {
        Console.Write("Choose specific company: ");
        var symbol = Console.ReadLine().ToUpper();
        List<SecurityData> prices = conn.GetDailyPrices(symbol);
        PrimitiveDataFrameColumn<DateTime> date = new PrimitiveDataFrameColumn<DateTime>("Date", prices.Select(sd => sd.Timestamp));
        PrimitiveDataFrameColumn<decimal> priceCol = new PrimitiveDataFrameColumn<decimal>("Close Price", prices.Select(sd => sd.Close));
        DataFrame df = new DataFrame(date, priceCol);
            
        PrimitiveDataFrameColumn<decimal> pctChange = new PrimitiveDataFrameColumn<decimal>("Percent Change", prices.Count);
            
        for(int i=1; i < prices.Count; i++)
        {
            decimal prevPrice = (decimal)df.Columns["Close Price"][i - 1];
            decimal currPrice = (decimal)df.Columns["Close Price"][i];
            decimal delta = ((currPrice / prevPrice) - 1) * 100;
            pctChange[i] = Math.Round(delta, 3);
        }
        df.Columns.Add(pctChange);
        Console.WriteLine("Current cost of " + symbol + " stock is " + priceCol[0] + "$");
    }
}