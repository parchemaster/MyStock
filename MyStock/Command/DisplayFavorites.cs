using MyStock;

namespace WeatherApp.Command;

public class DisplayFavorites : CommandFunction
{
    public override async Task ExecutCommand(User user)
    {
        OutPut.PrintStocks(user.Favorites);
    }
}