using Microsoft.Data.Analysis;
using MyStock;
using MyStock.Data;

namespace WeatherApp.Command;

public class HistoryOfStock : CommandFunction
{
    public override async Task ExecutCommand(User user)
    {
        Console.Write("Choose specific company: ");
        var company = Console.ReadLine().ToUpper();
        List<SecurityData> prices = conn.GetMonthsPrices(company);
        PrimitiveDataFrameColumn<DateTime> date = new PrimitiveDataFrameColumn<DateTime>("Date", prices.Select(sd => sd.Timestamp));
        PrimitiveDataFrameColumn<decimal> closePrice = new PrimitiveDataFrameColumn<decimal>("Close Price", prices.Select(sd => sd.Close));
        DataFrame df = new DataFrame(date, closePrice);
            
        PrimitiveDataFrameColumn<decimal> pctChange = new PrimitiveDataFrameColumn<decimal>("Percent Change", prices.Count);
            
        for(int i=1; i < prices.Count; i++)
        {
            decimal prevPrice = (decimal)df.Columns["Close Price"][i - 1];
            decimal currPrice = (decimal)df.Columns["Close Price"][i];
            decimal delta = ((currPrice / prevPrice) - 1) * 100;
            pctChange[i] = Math.Round(delta, 3);
            Console.WriteLine("Current cost of " + company + " stock is " + closePrice[i] + "$ " + "on " + date[i]);

        }
        df.Columns.Add(pctChange);
    }
}