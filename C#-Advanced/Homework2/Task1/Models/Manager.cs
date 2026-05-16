using Task1.BaseEntity;

namespace Task1.Models;

public class Manager : Employee
{
    public decimal BaseSalary { get; set; }
    public decimal Bonus { get; set; }

    public override decimal CalculateSalary()
    {
        return BaseSalary + Bonus;
    }

    public override void DisplayInfo()
    {

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Role: Manager");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Salary: {CalculateSalary()}");
        Console.ResetColor();
        Console.WriteLine();
    }
}

