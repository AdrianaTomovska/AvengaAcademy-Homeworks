using Task1.Models;
using Task1.Services;

User user = new User()
{
    Id = 3,
    Name = "Sara",
    Age = 36,
};

UserDatabase.Users.Add(user);

var users = UserDatabase.SearchByName("Sara");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Search By Name:");

foreach (var u in users)
{
    Console.WriteLine($"{u.Id} {u.Name} {u.Age}");
}
Console.ResetColor();

Console.WriteLine();

var user1 = UserDatabase.SearchById(1);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Search By Id:");

foreach(var u in user1)
{
    Console.WriteLine($"{u.Id} {u.Name} {u.Age}");
}

Console.ResetColor();

Console.WriteLine();


var user2 = UserDatabase.SearchByAge(39);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Search By Age:");

foreach (var u in user2)
{
    Console.WriteLine($"{u.Id} {u.Name} {u.Age}");
}

Console.ResetColor();

Console.WriteLine();