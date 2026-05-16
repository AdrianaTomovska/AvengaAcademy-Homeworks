using Task1.BaseEntity;
using Task1.Interfaces;
using Task1.Models;

Document document = new Document
{
    Title = "C# Notes",
    Content = "C# is a powerful programming language."
};


WebPage page = new WebPage
{
    Url = "https://google.com",
    Html = "<h1>Welcome</h1><p>Google</p>"
};

Console.WriteLine(document.Search("powerful")); 
Console.WriteLine(document.Search("c#"));   


Console.WriteLine(page.Search("programming")); 
Console.WriteLine(page.Search("google"));

Shape rectangle = new Rectangle
{
    Width = 5,
    Height = 4
};

Shape circle = new Circle
{
    Radius = 3
};

Shape triangle = new Triangle
{
    SideA = 3,
    SideB = 4,
    SideC = 5
};

rectangle.DisplayInfo();
Console.WriteLine();

circle.DisplayInfo();
Console.WriteLine();

triangle.DisplayInfo();

//Triangle triangle = new Triangle
//{
//    Base = 4.5,
//    Height = 2
//};


Employee manager = new Manager
{
    Name = "Alice",
    Id = 1,
    BaseSalary = 2000,
    Bonus = 500
};

Employee programmer = new Programmer
{
    Name = "Bob",
    Id = 2,
    HourlyRate = 20,
    HoursWorked = 160
};

Employee[] employees = { manager, programmer };

foreach (Employee emp in employees)
{
    emp.DisplayInfo();
}
    