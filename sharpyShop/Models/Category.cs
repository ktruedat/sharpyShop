namespace sharpyShop.Models;

public class Category
{
    private int Id { get; set; }
    private String Name { get; set; } = string.Empty;
    public List<Product>? Products { get; set; }
}