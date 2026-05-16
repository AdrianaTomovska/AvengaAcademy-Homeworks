using Task2.BaseEntity;

namespace Task2.Models;

public class Car : Vehicle
{
    public override void DisplayInfo()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("I’m a car and I drive on 4 wheels :)");
        Console.ResetColor();
    }
}

