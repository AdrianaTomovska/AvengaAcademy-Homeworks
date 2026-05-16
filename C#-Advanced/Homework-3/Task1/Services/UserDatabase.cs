using Task1.Models;

namespace Task1.Services;

public static class UserDatabase
{
    public static List<User> Users { get; set; } = new List<User>
    {
        new User { Id = 1, Name = "Adriana", Age = 34 },
        new User { Id =2, Name = "Gligorij", Age = 39 }
    };

    public static List<User> SearchById(int id)
    {
        return Users.Where(u => u.Id == id).ToList();
    }


    public static List<User> SearchByName(string name)
    {
        return Users.Where(u => u.Name == name).ToList();
    }

    public static List<User> SearchByAge(int age)
    {
        return Users.Where(u => u.Age == age).ToList();
    }

}
