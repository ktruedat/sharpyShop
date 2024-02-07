namespace sharpyShop.Models;

public class Product
{
    private int ProductId { get; set; }
    private String Name { get; set; } = string.Empty;
    private int CategoryId { get; set; }
    private Category Category { get; set; }  = default!;
    private decimal Price { get; set; }
    private int ProducerId { get; set; }
    private Producer Producer { get; set; } = default!;
}