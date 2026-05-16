using Task2.BaseEntity;

namespace Task2.Models;

public class Boat : Vehicle
{
    public override void DisplayInfo()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Im a boat and i do not have wheels :(");
        Console.ResetColor();
    }
}
