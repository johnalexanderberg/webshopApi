namespace webshopApi.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Product> Products { get; set; } = new();
    public List<ProductCategory> ProductCategories { get; set; }
}