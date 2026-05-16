namespace Exercise.Models;

public class Dog
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }

    public void Bark()
    {
        Console.WriteLine("Bark Bark");
    }

    public static bool Validate(Dog dog)
    {
        if (dog.Id < 0 || string.IsNullOrWhiteSpace(dog.Name) || dog.Name.Length < 2 || string.IsNullOrWhiteSpace(dog.Color))
        {
            return false;
        }
        return true;
    }

}