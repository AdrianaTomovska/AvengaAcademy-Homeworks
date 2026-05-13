List<string> holidays = new List<string>()
        {
            "01-01",
            "07-01",
            "20-04",
            "01-05",
            "25-05",
            "03-08",
            "08-09",
            "12-10",
            "23-10",
            "08-12"
        };

bool runAgain = true;

while (runAgain)
{
    Console.WriteLine("Enter a date (dd-MM-yyyy):");
    string input = Console.ReadLine();

    DateTime date;

    if (DateTime.TryParseExact(input,"dd-MM-yyyy",null,System.Globalization.DateTimeStyles.None,out date))
    {
        string dayMonth = date.ToString("dd-MM");

        bool isWeekend =date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;

        bool isHoliday = holidays.Contains(dayMonth);

        if (isWeekend || isHoliday)
        {
            Console.WriteLine("The date is NOT a working day.");
        }
        else
        {
            Console.WriteLine("The date is a working day.");
        }
    }
    else
    {
        Console.WriteLine("Invalid date format!");
    }

    Console.Write("Do you want to check another date? (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    if (answer != "Y")
    {
        runAgain = false;
    }

    Console.WriteLine();
}

Console.WriteLine("Application closed.");
    