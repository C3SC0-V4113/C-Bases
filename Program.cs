// See https://aka.ms/new-console-template for more information
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
    }
}