namespace Exercise.Models;

public static class DogShelter 
{
    public static List<Dog> dogs = new List<Dog>();

    public static void PrintAll()
    {
        foreach (Dog dog in dogs)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Id: {dog.Id}");
            Console.WriteLine($"Name: {dog.Name}");
            Console.WriteLine($"Color: {dog.Color}");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
