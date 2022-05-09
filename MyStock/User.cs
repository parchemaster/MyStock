using WeatherApp.Command;

namespace MyStock;

public class User
{
    public List<CommandFunction> Commands { get; set; }

    public User()
    {
        Commands = createFunctions();
    }

    private List<CommandFunction> createFunctions()
    {
        return new List<CommandFunction>(){new CurrentStock()};
    }
}