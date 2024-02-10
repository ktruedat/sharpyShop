namespace sharpyShop.Models;

public class Producer
{
    private int Id { get; set; }
    private String Name { get; set; } = string.Empty;
    private String Location { get; set; } = string.Empty;
    private List<Product>? Products { get; set; }

}