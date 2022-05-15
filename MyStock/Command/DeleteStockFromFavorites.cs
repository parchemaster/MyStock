using MyStock;
using MyStock.ConsoleInPut;
using MyStock.Data;

namespace WeatherApp.Command;

public class DeleteStockFromFavorites : CommandFunction
{
    public override async Task ExecutCommand(User user)
    {
        Console.WriteLine("What stock would you like to delete?");
        OutPut.PrintStocks(user.Favorites);
        var selectedStockIndex = InPut.ReadNumber(user.Favorites.Count) - 1;
        DBService.DeleteStockFromDB(user.Favorites[selectedStockIndex].Name);
        user.Favorites.Remove(user.Favorites[selectedStockIndex]);
    }
}