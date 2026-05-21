// 1. Filter all cars that have origin from Europe.

using Linq.Data;
using Linq.Models;

IEnumerable<Car> originEurope = CarsData.Cars.Where(c => c.Origin.Equals("Europe", StringComparison.OrdinalIgnoreCase));

foreach (Car car in originEurope)
{
    Console.WriteLine(car.Model);
}

Console.WriteLine();

// 2. Find all unique cylinder values for cars.

IEnumerable<int> uniqueCylinder = CarsData.Cars.Select(u => u.Cylinders).Distinct();
foreach (int unique in uniqueCylinder)
{
    Console.WriteLine(unique);
}

Console.WriteLine();


// 3. Select all car names with their model names converted to uppercase.

IEnumerable<string> allCarNames = CarsData.Cars.Select(c => c.Model.ToUpper());

foreach (string carName in allCarNames)
{
    Console.WriteLine(carName);
}

Console.WriteLine();


// 4. Check if there are any cars with horsepower greater than 300.

bool horesPower300 = CarsData.Cars.Any(c => c.HorsePower > 300);
Console.WriteLine(horesPower300);

Console.WriteLine();


// 5. Find the car with the highest horsepower.


var highestHorsepower = CarsData.Cars.MaxBy(c => c.HorsePower);
Console.WriteLine($"{highestHorsepower.Model} - {highestHorsepower.HorsePower} HP");

Console.WriteLine();


// 6. Filter all "Chevrolet" cars and order them by weight in descending order.

IEnumerable<Car> allChevrolet = CarsData.Cars.Where(c => c.Model.Contains("Chevrolet"))
                                             .OrderByDescending(c => c.Weight);
foreach (var car in allChevrolet)
{
    Console.WriteLine($"{car.Model} - {car.Weight}");
}
Console.WriteLine();



// 7. Find the car with the longest model name.


var longestModel = CarsData.Cars.OrderByDescending(c=> c.Model.Length).FirstOrDefault();
Console.WriteLine($" {longestModel.Model}");
Console.WriteLine();


// 8. Group cars by their origin and then order the groups by the number of cars in each group, in ascending order.

var groupedCars = CarsData.Cars.GroupBy(c => c.Origin)
                                .OrderBy(g => g.Count());

foreach (var car in groupedCars)
{
    Console.WriteLine($"{car.Key} - {car.Count()} cars");
}
Console.WriteLine();


// 9. Find the first 5 cars with the highest horsepower. (hint: read about LINQ methods Skip() and Take())

IEnumerable<Car> highestHorsepowerCars  = CarsData.Cars.OrderByDescending(c => c.HorsePower).Take(5);

foreach (var item in highestHorsepowerCars)
{
    Console.WriteLine($"{item.Model} - {item.HorsePower}");
}
Console.WriteLine();


// 10. Find the car with the highest acceleration time.

var highestAcceleration = CarsData.Cars.OrderByDescending(c => c.AccelerationTime).FirstOrDefault();
Console.WriteLine($"{highestAcceleration.Model}");
Console.WriteLine();



// 11. Select only the model and horsepower of cars with horsepower greater than 200.

var modelAndHorsepower = CarsData.Cars.Where(m => m.HorsePower > 200)
                                       .Select(m => new
                                       {
                                           m.Model,
                                           m.HorsePower
                                       });
foreach (var item in modelAndHorsepower)
{
    Console.WriteLine($"{item.Model} - {item.HorsePower}");
}
Console.WriteLine();


// 12. Select all unique origins of cars, ordered alphabetically (ascending).

IEnumerable<string> uniqueOrigins = CarsData.Cars.Select(u => u.Origin).Distinct().OrderBy(o => o);

foreach (var item in uniqueOrigins)
{
    Console.WriteLine(item);
}


// 13. Select all cars with more than 4 cylinders, and order them by origin and then by horsepower.


IEnumerable<Car> allCars = CarsData.Cars.Where(c => c.Cylinders > 4)
                                        .OrderBy(c => c.Origin)
                                        .ThenBy(c => c.HorsePower);

foreach (var car in allCars)
{
    Console.WriteLine($"{car.Origin} - {car.Model} - {car.HorsePower}");
}
Console.WriteLine();


// 14. Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result.

IEnumerable<Car> carCylinders = CarsData.Cars.Where(c => c.Cylinders > 6)
                                             .Concat(CarsData.Cars.Where(c => c.Cylinders == 4 && c.HorsePower > 110));

foreach (var car in carCylinders)
{
    Console.WriteLine($"{car.Model} - {car.Cylinders} cyl - {car.HorsePower} HP");
}
Console.WriteLine();



// 15. Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highest and average Miles per galon for these cars.

var filtered = CarsData.Cars.Where(c => c.HorsePower > 200)
                             .Select(c => c.MilesPerGalon);

double minMpg = filtered.Min();
double maxMpg = filtered.Max();
double avgMpg = filtered.Average();

Console.WriteLine($"Min MPG: {minMpg}");
Console.WriteLine($"Max MPG: {maxMpg}");
Console.WriteLine($"Average MPG: {avgMpg}");

Console.WriteLine();


// 16. Be creative and write requirement of your own choice :) (only one catch, must use at least 3 LINQ methods)
// Прво ги филтрираме сите автомобили кои имаат HorsePower поголем од 120 и не се од „US“,
// потоа ги подредуваме по MilesPerGallon опаѓачки, па ги зимаме првите 3 и ги прикажуваме само Model, MilesPerGallon и HorsePower.

var result = CarsData.Cars.Where(c => c.HorsePower > 120 && c.Origin != "US")
                            .OrderByDescending(c => c.MilesPerGalon)
                            .Take(3)
                            .Select(c => new
                            {
                                c.Model,
                                c.MilesPerGalon,
                                c.HorsePower
                            });
foreach (var car in result)
{
    Console.WriteLine($"{car.Model} - {car.MilesPerGalon} MPG - {car.HorsePower} HP");
}

Console.WriteLine();



// 17. Ги филтрираме сите автомобили кои имаат најмалку 6 цилиндри и HorsePower поголем од 150, потоа ги подредуваме по AccelerationTime (растечки), и ги зимаме првите 5 и ги прикажуваме.

IEnumerable<Car> result2 = CarsData.Cars.Where(c => c.Cylinders >= 6 && c.HorsePower > 150)
                                        .OrderBy(c => c.AccelerationTime)
                                        .Take(5);

foreach (var car in result2)
{
    Console.WriteLine($"{car.Model} - {car.Cylinders} cyl - {car.HorsePower} HP - {car.AccelerationTime}s");
}