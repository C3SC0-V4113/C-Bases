using csbases.Fundamentals;

public class ProductRepository
{
    public async Task<Product> GetProduct(int id)
    {
        // Simulación de obtención de un producto desde una fuente de datos
        WriteLine("Buscando producto...");
        await Task.Delay(2000); // Simulación de operación asíncrona
        return new Product("Producto simulado", 500);
    }
}