namespace Homework15;

public abstract class Product
{
    protected Product(decimal basePrice)
    {
        if (basePrice <= 0)
        {
            throw new ArgumentException("Price cannot be negative");
        }
        BasePrice = basePrice;
    }
    
    protected abstract decimal Price { get; }
    protected decimal BasePrice { get; private set; }

    public abstract void PrintVegetableInfo();
}