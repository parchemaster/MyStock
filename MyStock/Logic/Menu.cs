using WeatherApp;
using WeatherApp.Command;

namespace MyStock.Logic;

public class Menu
{
    private bool willContinue = true;
    private Navigation _navigation = new Navigation();
    private User _user = new User();
    public async Task RunProgram()
    {
        // _navigation = new Navigation();
        // _user = new User();

        while (willContinue.Equals(true))
        {
            try
            {
                OutPut.PrintMenu();
                willContinue = await FinishProcessChecking(int.Parse(Console.ReadLine()));// if false program will close
            }
            catch (FormatException)
            {
                   
                Console.WriteLine("Input cant be empty or in wrong format!!");
            }
            finally
            {
                if (willContinue.Equals(true))
                    Console.ReadKey();

                Console.Clear();
            }

        }

    }
    
    private async Task<bool> FinishProcessChecking(int userInput)
    {
        if (!userInput.Equals((int)Commands.Exit))
        {
            _navigation.NavigationDecision(userInput, _user);
        }
        else
        {
            willContinue = false;
        }
        return willContinue;
    }
}