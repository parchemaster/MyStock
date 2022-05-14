namespace MyStock.Data;

public class Stock
{
    public String Name { set; get; }
    public DateTime Date { set; get; }
    public decimal ClosePrice { set; get; }

    public Stock(string name, DateTime date, decimal closePrice)
    {
        Name = name;
        Date = date;
        ClosePrice = closePrice;
    }

    public override string ToString()
    {
        return "Current cost of " + Name + " stock is " + ClosePrice + "$";
    }
}