using webshopApi.Models;

namespace webshopApi.Data;

public class DbInitializer
{
    public static void Initialize(AppDbContext context)
    {
        if (context.Products.Any())
        {
            return; // Database has been seeded
        }

        var categories = new Category[]
        {
            new Category
            {
                Name = "Jackets"
            },
            new Category
            {
                Name = "Shoes"
            }
        };

        var products = new Product[]
        {
            
            new Product
            {
                Name = "Sko 1",
                ImageUrl = "Sko 1",
                Price = (decimal) 1.5,

            },
            new Product
            {
                Name = "Jacka 1",
                ImageUrl = "Jacka 1",
                Price = (decimal) 2.5,
            }
        };
        
        categories[0].Products.Add(products[1]);
        context.Products.AddRange(products);
        context.Categories.AddRange(categories);
        context.SaveChanges();
    }
}