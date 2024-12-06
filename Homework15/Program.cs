using Homework15;

List<Product> products = new()
{
    new Potato(15.5m, 4),
    new Cucumber(9.5m, 6),
    new Carrot(12.5m),
    new Tomato(10.5m)
};

VegetableShop vegetableShop = new VegetableShop();
vegetableShop.AddProducts(products);
vegetableShop.PrintProductsInfo();