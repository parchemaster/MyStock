
using ServiceStack;
using System;
using System.Collections.Generic;

public class AVConnection
{
    private readonly string _apiKey;

    public AVConnection(string apiKey)
    {
        this._apiKey = apiKey;
    }

    public List<SecurityData> GetDailyPrices(string symbol)
    {
        try
        {
            const string FUNCTION = "TIME_SERIES_DAILY";
            string connectionString = "https://" + $@"www.alphavantage.co/query?function={FUNCTION}&symbol={symbol}&apikey={this._apiKey}&datatype=csv";
            List<SecurityData> data = connectionString.GetStringFromUrl().FromCsv<List<SecurityData>>();
            return data;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public List<SecurityData> GetMonthsPrices(string symbol)
    {
        const string FUNCTION = "TIME_SERIES_MONTHLY_ADJUSTED";
        string connectionString = "https://" + $@"www.alphavantage.co/query?function={FUNCTION}&symbol={symbol}&apikey={this._apiKey}&datatype=csv";
        List<SecurityData> data = new List<SecurityData>();
        Console.WriteLine(symbol);
        try
        {
            var testData = connectionString.GetStringFromUrl();
            var testUrl = testData.FromCsv<List<SecurityData>>();
            return testUrl;
        }
        catch
        {
            while (true)
            {
                data = connectionString.GetStringFromUrl().FromCsv<List<SecurityData>>();
                return data;
            }
        }
    }

    public List<SecurityData> GetListinigStatus()
    {
        const string FUNCTION = "LISTING_STATUS";
        string connectionString = "https://" + $@"www.alphavantage.co/query?function={FUNCTION}&apikey={this._apiKey}";
        List<SecurityData> data = connectionString.GetStringFromUrl().FromCsv<List<SecurityData>>();
        return data;
    }
}