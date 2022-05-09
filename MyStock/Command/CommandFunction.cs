using MyStock.Logic;

namespace WeatherApp.Command;

public abstract class CommandFunction
{

    public AVConnection conn = new AVConnection("T74XLTWLXCZKB3XX");

    public virtual async Task ExecutCommand()
    {
        Console.WriteLine("aa");
    }
}