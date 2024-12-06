namespace Homework15;

public sealed class Cucumber : Product
{
    public Cucumber(decimal basePrice, int count) : base(basePrice)
    {
        if (count <= 0)
        {
            throw new ArgumentException("Price and count cannot be negative");
        }
        Count = count;
        Price = basePrice * count;
    }
    
    protected override decimal Price { get; }
    private int Count { get; }

    public override void PrintVegetableInfo()
    {
        Console.WriteLine($"Product: {nameof(Cucumber)}, Count: {Count}, Price: {BasePrice}, Total Price: {Price}");
    }
}