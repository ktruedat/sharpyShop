namespace sharpyShop.Models;

public class Sale
{
    private int Id { get; set; }
    private int ProductId { get; set; }
    private Product Product { get; set; } = default!;
    private int CustomerId { get; set; }
    private Customer Customer { get; set; } = default!;
    private decimal Quantity { get; set; }
    private int Amount { get; set; }
    private int PromotionId { get; set; }
    private Promotion Promotion { get; set; } = default!;
    private DateTime Date { get; set; }
}