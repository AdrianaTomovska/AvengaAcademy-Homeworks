using Task2.BaseEntity;

namespace Task2.Models;

public class Airplane : Vehicle
{
    public override void DisplayInfo()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Im a plane i have couple of wheels :)");
        Console.ResetColor();
    }
}
