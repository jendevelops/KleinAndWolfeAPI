namespace kleinandwolfeapi.Models
{
  public class PromotionOrder
  {
    public int PromotionOrderId { get; set; }
    public int PromotionId { get; set; }
    public int OrderId { get; set; }
    public string Name { get; set; }
    public decimal PercentOff { get; set; }

    public Order Order {get;set;}
    public Promotion Promotion {get;set;}

  
  }
}