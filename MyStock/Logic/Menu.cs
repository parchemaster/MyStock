using WeatherApp.Command;

namespace MyStock.Logic;

public class Menu
{
    private bool willContinue = true;
    private Navigation _navigation;
    private User _user;
    public async Task RunProgram()
    {
        _navigation = new Navigation();
        _user = new User();

        while (willContinue.Equals(true))
        {
            // Threads.StartThreadWithJoin(new Thread(new ThreadStart(OutPut.PrintMenuFrame)));
            // Threads.StartThreadWithJoin(new Thread(new ThreadStart(OutPut.PrintTitleFrame)));
            // Threads.StartThreadWithJoin(new Thread(new ThreadStart(OutPut.PrintMainMenu)));
            try
            {
                Console.WriteLine("1. Display specific stock for specific period of time");
                Console.Write("Choose your action: ");
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