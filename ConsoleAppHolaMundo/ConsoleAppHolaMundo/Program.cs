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
    Name = "Vocho",
    Brand = "VW"
};

var bernieBus = new Bus()
{
    Brand = "Volvo",
    Name = "Peludo",
    Id = 2,
    Size = 40
};










Console.WriteLine(baldoCar.Id);
Console.WriteLine();
Console.WriteLine(baldoCar.Name);
Console.WriteLine();
Console.WriteLine(baldoCar.Brand);


Console.WriteLine("falto esto");
Console.WriteLine("**************************BUS************************************");
Console.WriteLine(bernieBus.Id);
Console.WriteLine(bernieBus.Name);
Console.WriteLine(bernieBus.Brand);
Console.WriteLine(bernieBus.Size);
Console.WriteLine("**************************BUS************************************");





Console.ReadLine(); 
