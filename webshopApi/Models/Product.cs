namespace webshopApi.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
    public List<Category> Categories { get; set; } = new();
    public List<ProductCategory> ProductCategories { get; set; }
}