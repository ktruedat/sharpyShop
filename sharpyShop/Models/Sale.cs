namespace sharpyShop.Models;

public class Sale
{
    private int Id { get; set; }
    private int ProductId { get; set; }
    private int CustomerId { get; set; }
    private decimal Quantity { get; set; }
    private int Amount { get; set; }
    private int PromotionId { get; set; }
    private DateTime Date { get; set; }
}