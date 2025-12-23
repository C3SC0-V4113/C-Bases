using csbases.Fundamentals;

public class LabelService : ILabelService
{
    public string GenerateLabel(Product product)
    {
        return $"{product.Name} - Precio: {product.Price:C} - Code: {product.GetType().Name}-{product.GetHashCode()}";
    }
}