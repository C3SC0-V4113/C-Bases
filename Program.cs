// See https://aka.ms/new-console-template for more information
using csbases.Fundamentals;

class Program
{
    static void Main(string[] args)
    {
        // Explicit declaration of variables
        int quantity = 5;
        string message = "Hello, World!";
        decimal prices = 19.99m;
        WriteLine($"Message: {message}, Quantity: {quantity}, Prices: {prices:C}");

        // Implicit declaration of variables
        var greeting = "Welcome to C# programming!";
        var percentage = 20.00m;
        WriteLine($"Greeting: {greeting}, Percentage: {percentage}%");

        var laptop = new Product("Laptop", 1200);
        WriteLine(laptop.GetDescription());
        var soporte = new ServiceProduct("Soporte Técnico", 300, 30);
        WriteLine(soporte.GetDescription());
    }
}