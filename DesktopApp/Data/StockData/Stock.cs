public class Stock
{
    public System.String Name { set; get; }
    public System.DateTime Date { set; get; }
    public decimal ClosePrice { set; get; }

    public Stock(string name, System.DateTime date, decimal closePrice)
    {
        Name = name;
        Date = date;
        ClosePrice = closePrice;
    }

    public override string ToString()
    {
        return "Current cost of " + Name + " stock is " + ClosePrice + "$" + " at " + Date;
    }
}