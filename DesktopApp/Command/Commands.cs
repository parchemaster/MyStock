using Microsoft.Data.Analysis;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Commands
{
    private AVConnection conn;

    public Commands()
    {
        conn = new AVConnection("T74XLTWLXCZKB3XX");
    }


    private List<Stock> HistoryOfStock(User user, string company)
    {

        List<SecurityData> prices = conn.GetMonthsPrices(company);
        PrimitiveDataFrameColumn<DateTime> date = new PrimitiveDataFrameColumn<DateTime>("Date", (IEnumerable<DateTime>)prices.Select(sd => sd.Timestamp));
        PrimitiveDataFrameColumn<decimal> closePrice = new PrimitiveDataFrameColumn<decimal>("Close Price", prices.Select(sd => sd.Close));
        DataFrame df = new DataFrame(date, closePrice);

        PrimitiveDataFrameColumn<decimal> pctChange = new PrimitiveDataFrameColumn<decimal>("Percent Change", prices.Count);
        List<Stock> stocks = new List<Stock>();
        for (int i = 1; i < prices.Count; i++)
        {
            decimal prevPrice = (decimal)df.Columns["Close Price"][i - 1];
            decimal currPrice = (decimal)df.Columns["Close Price"][i];
            decimal delta = ((currPrice / prevPrice) - 1) * 100;
            pctChange[i] = Math.Round(delta, 3);
            
            stocks.Add(new Stock(company, (DateTime)date[i], (decimal)closePrice[i]));
        }
        df.Columns.Add(pctChange);
        return stocks;
    }

    public Task<List<Stock>> HistoryOfStockAsync(User user, string company)
    {
        return Task.Run(() => HistoryOfStock(user, company));
    }

    private string AddToFavorit(User user, string company)
    {
       
        if (!user.Favorites.Any(stock => stock.Name.Equals(company)))
        {
            List<SecurityData> prices = conn.GetDailyPrices(company);
            if (prices == null)
            {
                return ("There is not such a company");
            }
            PrimitiveDataFrameColumn<DateTime> date = new PrimitiveDataFrameColumn<DateTime>("Date", (IEnumerable<DateTime>)prices.Select(sd => sd.Timestamp));
            PrimitiveDataFrameColumn<decimal> closePrice = new PrimitiveDataFrameColumn<decimal>("Close Price", prices.Select(sd => sd.Close));

            // checking if favorites contains new stock
            var newStock = new Stock(company, date[0].Value, closePrice[0].Value);

            DBService.AddStockToDB(newStock);
            user.Favorites.Add(newStock);
            return (company + " was added to DB");
        }
        return (company + " wasn't added becase it's already there");
    }

    public Task<string> addToFavouritesAsync(User user, string company)
    {
        return Task.Run(() => AddToFavorit(user, company));
    }

    private string DeleteStockFromFavorites(User user, string company)
    {
        if (user.Favorites.Any(stock => stock.Name.Equals(company)))
        {

            var selectedStock = user.Favorites.Find(s => s.Name.Equals(company));
            DBService.DeleteStockFromDB(selectedStock.Name);
            user.Favorites.Remove(selectedStock);
            return company + " was successfully deleted";
        }
        return (company + " wasn't deleted becase there is no such stock");
    }

    public Task<string> DeleteStockFromFavouritesAsync(User user, string company)
    {
        return Task.Run(() => DeleteStockFromFavorites(user, company));
    }
    private List<string> DisplayFavorites(User user)
    {

        return user.Favorites.Select(s => s.ToString()).ToList();
    }

    public Task<List<string>> DisplayFavouritesAsync(User user)
    {
        return Task.Run(() => DisplayFavorites(user));
    }
}