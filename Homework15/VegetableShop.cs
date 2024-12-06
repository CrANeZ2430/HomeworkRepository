namespace Homework15;

public class VegetableShop
{
    private List<Product> vegetableList = new ();

    public void AddProducts(List<Product> products)
    {
        foreach (var product in products)
        {
            vegetableList.Add(product);
        }
    }

    public void PrintProductsInfo()
    {
        foreach (var vegetable in vegetableList)
        {
            vegetable.PrintVegetableInfo();
        }
    }
}