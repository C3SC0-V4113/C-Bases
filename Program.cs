// See https://aka.ms/new-console-template for more information
using csbases.Fundamentals;

class Program
{
    static async Task Main(string[] args)
    {
        var laptop = new Product("Laptop", 1200);
        WriteLine(laptop.GetDescription());
        var soporte = new ServiceProduct("Soporte Técnico", 300, 30);
        WriteLine(soporte.GetDescription());

        var product = new Product("Mouse Gamer", 300);
        var productDto = ProductAdapter.ToDto(product);
        WriteLine($"DTO - Name: {productDto.Name}, Price: {productDto.Price:C}, Code: {productDto.Code}");

        // Dependency Injection Example
        ILabelService labelService = new LabelService();
        var manager = new ProductManager(labelService);
        var monitor = new Product("Monitor", 100);
        var installation = new ServiceProduct("Instalación", 20, 30);

        manager.PrintLabel(monitor);
        manager.PrintLabel(installation);

        var firstProduct = await new ProductRepository().GetProduct(1);
        firstProduct.Description = "Esta es la descripcion del primer producto";
        AttributeProcessor.ApplyUpperCase(firstProduct);
        WriteLine($"{firstProduct.Name} - {firstProduct.Price:C} - {firstProduct.Description}");
    }
}