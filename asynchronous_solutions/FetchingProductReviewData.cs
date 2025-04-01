using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ProductData
{
    public string Name { get; set; }

    public ProductData(string name)
    {
        Name = name;
    }
}

public class ReviewData
{
    public string Content { get; set; }

    public ReviewData(string content)
    {
        Content = content;
    }
}

public class FetchingProductReviewData
{
    // Asynchronous method to fetch product data
    public async Task<List<ProductData>> FetchThisProductsAsync()
    {
        await Task.Delay(2000); // Simulating a 2-second delay for fetching products
        return new List<ProductData> { new ProductData("Eco Bag"), new ProductData("Reusable Straw") };
    }

    // Asynchronous method to fetch review data
    public async Task<List<ReviewData>> FetchReviewsAsync()
    {
        await Task.Delay(3000); // Simulating a 3-second delay for fetching reviews
        return new List<ReviewData>
        {
            new ReviewData("Great product!"),
            new ReviewData("Good value for the money."),
        };
    }

    // Asynchronous method to display both products and reviews
    public async Task FetchDataAsync()
    {
        // Start fetching products and reviews concurrently
        Task<List<ProductData>> productsTask = FetchThisProductsAsync();
        Task<List<ReviewData>> reviewsTask = FetchReviewsAsync();

        // Wait for both tasks to complete
        await Task.WhenAll(productsTask, reviewsTask);

        // Get the results
        List<ProductData> products = await productsTask;
        List<ReviewData> reviews = await reviewsTask;

        // Display the results
        Console.WriteLine("Products:");
        foreach (ProductData product in products)
        {
            Console.WriteLine(product.Name);
        }

        // Display fetched reviews
        Console.WriteLine("\nReviews:");
        foreach (ReviewData review in reviews)
        {
            Console.WriteLine(review.Content);
        }
    }

    // Main entry point
    public static async Task Main(string[] args)
    {
        // Calling the asynchronous method to fetch and display products and reviews
        FetchingProductReviewData productReviewData = new FetchingProductReviewData();
        await productReviewData.FetchDataAsync();
    }
}
