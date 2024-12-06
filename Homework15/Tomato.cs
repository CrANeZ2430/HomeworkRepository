namespace Homework15;

public sealed class Tomato : Product
{
    public Tomato(decimal basePrice) : base(basePrice)
    {
        Price = basePrice;
    }
    
    protected override decimal Price { get; }

    public override void PrintVegetableInfo()
    {
        Console.WriteLine($"Product: {nameof(Tomato)} Total Price: {Price}");
    }
}