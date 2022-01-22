// See https://aka.ms/new-console-template for more information
using ConsoleAppHolaMundo;

Console.WriteLine("Hello, World!");


for (int i = 0; i < 100; i++)
{
    Console.WriteLine($"hola {i}");

}

var baldoCar = new Car()
{
    Id = 1,
    Name = "bocho",
    Brand = "VW"
};



Console.WriteLine(baldoCar.Id);
Console.WriteLine();
Console.WriteLine(baldoCar.Name);
Console.WriteLine();
Console.WriteLine(baldoCar.Brand);


Console.WriteLine("falto esto");
Console.ReadLine(); 
