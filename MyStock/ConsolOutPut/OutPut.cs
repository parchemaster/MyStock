
namespace WeatherApp
{
    public class OutPut
    {
        private static int width = Console.WindowWidth / 2;
        public static void PrintMenu()
        {
            String [] menuLine = {"1. Display specific stock", "2. Add stock to favorite", "3. Display favorite list"};
            ColorAndStyle.PrintSetedTextPosition(menuLine, width + menuLine.Length / 2, 20);
            Console.Write("Choose your action: ");
        }
    }
}
