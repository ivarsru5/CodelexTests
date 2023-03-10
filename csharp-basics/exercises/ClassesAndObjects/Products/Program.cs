namespace Products;
class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        products.Add(new Product("Logitech mouse", 70.00, 14));
        products.Add(new Product("iPhone 5s", 999.99, 3));
        products.Add(new Product("Epson EB-U05", 440.46, 1));

        PrintObjects(products);
    }

    static void PrintObjects(List<Product> products)
    {
        foreach (var product in products)
        {
            Console.WriteLine($"{product.name}, {product.price}, {product.amount}");

            Console.Write("Change {0} price: ", product.name);
            var newPrice = double.Parse(Console.ReadLine()!);
            product.ChangePrice(newPrice);
            Console.WriteLine("Price Changed");

            Console.Write("Change {0} product quantity: ", product.name);
            var newAmount = int.Parse(Console.ReadLine()!);
            product.ChangeQuantity(newAmount);
            Console.WriteLine("Amount changed");
        }
    }
}

