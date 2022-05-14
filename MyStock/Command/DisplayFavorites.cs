using MyStock;

namespace WeatherApp.Command;

public class DisplayFavorites : CommandFunction
{
    public override async Task ExecutCommand(User user)
    {
        foreach (var favorite in user.Favorites)
        {
            Console.WriteLine(user.Favorites.IndexOf(favorite) + 1 + ": " + favorite);
        }
    }
}