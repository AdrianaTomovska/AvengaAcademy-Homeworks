using Task2.BaseEntity;

namespace Task2.Models;

public class MotorBike : Vehicle
{
    public override void DisplayInfo()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Im a motorbike and i drive on 2 wheels :)");
        Console.ResetColor();
    }
}
