namespace MyStock.ConsoleInPut;

public class InPut
{
    public static int ReadNumber(int range)
    {
        try
        {
            Console.Write("Select stock: ");
            string stringNumber = Console.ReadLine();
            
            var number = Int32.Parse(stringNumber);
            
            if (number <= 0 || number > range)
            {
                Console.WriteLine("Select diapason from 1 to " + range);
                return ReadNumber(range);
            }

            return number;
        }
        catch (Exception e)
        {
            Console.WriteLine("You should to choose integer number");
            return ReadNumber(range);
        }
    }
}