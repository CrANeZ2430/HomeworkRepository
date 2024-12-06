namespace Homework15;

public sealed class Carrot : Product
{
    public Carrot(decimal basePrice) : base(basePrice)
    {
        Price = basePrice;
    }
    
    protected override decimal Price { get; }

    public override void PrintVegetableInfo()
    {
        Console.WriteLine($"Product: {nameof(Carrot)} Total Price: {Price}");
    }
}