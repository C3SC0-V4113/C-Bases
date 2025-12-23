using csbases.Fundamentals;

public class ProductManager
{
    private readonly ILabelService _labelService;

    public ProductManager(ILabelService labelService)
    {
        _labelService = labelService;
    }

    public string GetProductLabel(Product product)
    {
        return _labelService.GenerateLabel(product);
    }

    public void PrintLabel(Product product)
    {
        string label = GetProductLabel(product);
        Console.WriteLine(label);
    }
}