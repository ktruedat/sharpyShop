namespace sharpyShop.Models;

public class Promotion
{
    private int Id { get; set; }
    private String Name { get; set; }
    private decimal DiscountPercentage { get; set; }
    private DateTime StartDate { get; set; }
    private DateTime EndDate { get; set; }
}