using MyStock.Data;
using WeatherApp.Command;

namespace MyStock;

public class User
{
    public List<CommandFunction> Commands { get; set; }
    public List<Stock> Favorites { get; set; }

    public User()
    {
        Commands = createFunctions();
        Favorites = DBService.UploadStocksFromDB();
    }

    private List<CommandFunction> createFunctions()
    {
        return new List<CommandFunction>(){new CurrentStock(), new AddToFavorit(), new DisplayFavorites()};
    }
}