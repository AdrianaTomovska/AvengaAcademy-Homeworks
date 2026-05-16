using Task1.BaseEntity;

namespace Task1.Models
{
    public class Programmer : Employee
    {
        public decimal HourlyRate { get; set; }
        public decimal HoursWorked { get; set; }
        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Role: Programmer");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Salary: {CalculateSalary()}");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
