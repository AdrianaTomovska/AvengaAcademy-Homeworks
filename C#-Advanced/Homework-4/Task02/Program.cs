using Task02.BaseEntity;
using Task02.Models;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("====== Tak 2 =====");
Console.WriteLine();

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

Console.ResetColor();
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("==== Task 3 ====");
Console.WriteLine();

Car car1 = new Car();
car1.Drive();

MotorBike motor = new MotorBike();
motor.Wheelie();

Boat boat1 = new Boat();
boat1.Sail();

Airplane airplane1 = new Airplane();
airplane1.Fly();

Console.ResetColor();