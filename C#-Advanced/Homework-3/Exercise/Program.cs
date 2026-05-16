using Exercise.Models;

Dog dog1 = new Dog
{
    Id = 1,
    Name = "Max",
    Color = "Brown"
};

Dog dog2 = new Dog
{
    Id = 2,
    Name = "Bella",
    Color = "Black"
};

Dog dog3 = new Dog
{
    Id = 3,
    Name = "Rocky",
    Color = "White"
};

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(Dog.Validate(dog1));
Console.WriteLine(Dog.Validate(dog2));
Console.WriteLine(Dog.Validate(dog3));
Console.ResetColor();

Console.WriteLine();

DogShelter.dogs.Add(dog1);
DogShelter.dogs.Add(dog2);
DogShelter.dogs.Add(dog3);

DogShelter.PrintAll();