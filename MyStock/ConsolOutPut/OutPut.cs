
using MyStock.Data;

namespace WeatherApp
{
    public class OutPut
    {
        private static int width = Console.WindowWidth / 2;
        public static void PrintMenu()
        {
            String [] menuLine = {
                "1. Display specific stock", 
                "2. Add stock to favorite", 
                "3. Display favorite list",
                "4. Delete stock from favorites",
                "5. Check the history of stock",
                "6. Exit"
            };
            ColorAndStyle.PrintSetedTextPosition(menuLine, width + menuLine.Length / 2, 20);
            Console.Write("Choose your action: ");
        }

        public static void PrintStocks(List<Stock> stocks)
        {
            foreach (var favorite in stocks)
            {
                Console.WriteLine(stocks.IndexOf(favorite) + 1 + ": " + favorite);
            }
        }
    }
}
