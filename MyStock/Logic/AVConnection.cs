using MyStock.Data;
using ServiceStack;

namespace MyStock.Logic;

public class AVConnection
{
    private readonly string _apiKey;

    public AVConnection(string apiKey)
    {
        this._apiKey = apiKey;
    }

    public List<SecurityData> GetDailyPrices(string symbol)
    {
        const string FUNCTION = "TIME_SERIES_DAILY";
        string connectionString = "https://" + $@"www.alphavantage.co/query?function={FUNCTION}&symbol={symbol}&apikey={this._apiKey}&datatype=csv";
        List<SecurityData> prices = connectionString.GetStringFromUrl().FromCsv<List<SecurityData>>();
        return prices;
    }

    public List<SecurityData> GetMonthsPrices(string symbol)
    {
        const string FUNCTION = "TIME_SERIES_MONTHLY_ADJUSTED";
        string connectionString = "https://" + $@"www.alphavantage.co/query?function={FUNCTION}&symbol={symbol}&apikey={this._apiKey}&datatype=csv";
        List<SecurityData> prices = connectionString.GetStringFromUrl().FromCsv<List<SecurityData>>();
        return prices;
    }
}