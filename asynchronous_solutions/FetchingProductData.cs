public class Product
{
    public string Name { get; set; }

    public Product(string name)
    {
        Name = name;
    }
}

public class FetchingProductData
{
    // Asynchronous method to fetch product data
    public async Task<List<Product>> FetchProductsAsync()
    {
        await Task.Delay(2000); // Simulating a 2-second delay for data fetching
        return new List<Product>
        {
            new Product("Eco Bag"),
            new Product("Reusable Straw")
        };
    }

    // Asynchronous method to display product data
    public async Task DisplayProductsAsync()
    {
        List<Product> products = await FetchProductsAsync();
        foreach (Product product in products)
        {
            Console.WriteLine(product.Name);
        }
    }

    // Main entry point
    /*public static async Task Main(string[] args)
    {
        // Calling the asynchronous method
        FetchingProductData productData = new FetchingProductData();
        await productData.DisplayProductsAsync();
    }*/
}