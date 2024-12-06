using Homework15;

List<Product> products = new()
{
    new Potato(15.5m, 4),
    new Cucumber(9.5m, 6),
    new Carrot(12.5m),
    new Tomato(10.5m)
};

VegetableShop shop = new VegetableShop();
shop.AddProducts(products);
shop.PrintProductsInfo();