

using Microsoft.Data.Analysis;
using MyStock.Data;
using WeatherApp.Command;

namespace MyStock.Logic;

public class Navigation
{
    public async Task NavigationDecision(int command, User _user)
    {

        await _user.Commands[command-1].ExecutCommand();
    }
}