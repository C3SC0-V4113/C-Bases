using System;

namespace csbases.Fundamentals;

public class Product : IProduct
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid UniqueCode { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
        CreatedDate = DateTime.Now;
        UniqueCode = Guid.NewGuid();
    }

    public void ApplyDiscount(decimal percentage)
    {
        if (percentage < 0 || percentage > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(percentage), "Percentage must be between 0 and 100.");
        }

        decimal discountAmount = Price * (percentage / 100);
        Price -= discountAmount;
    }

    public virtual string GetDescription()
    {
        return $"{Name} - {Price:C}";
    }
}

class ServiceProduct : Product
{
    public int DurationInDays { get; set; }

    public ServiceProduct(string name, decimal price, int durationInDays) : base(name, price)
    {
        DurationInDays = durationInDays;
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()} - Duration: {DurationInDays} days";
    }
}
