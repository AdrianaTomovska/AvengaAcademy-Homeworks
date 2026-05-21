using Task01;

List<string> names = ["Adriana", "Lana", "Mila", "Gligorij"];
List<int> numbers = [1, 2, 3, 4, 5, 6];

Console.ForegroundColor = ConsoleColor.Yellow;
PrintInConsole.Print(20);
PrintInConsole.Print("Avenga");
PrintInConsole.Print(false);
Console.ResetColor();

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
PrintInConsole.PrintCollection(names);
Console.ResetColor();
Console.WriteLine();

Console.ForegroundColor= ConsoleColor.Blue;
PrintInConsole.PrintCollection(numbers);
Console.ResetColor();