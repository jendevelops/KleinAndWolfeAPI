using System.Collections.Generic;
namespace kleinandwolfeapi.Models
{
  public class Promotion
  {
    public int PromotionId { get; set; }
    public Client Client {get;set;}
    public string Name { get; set; }
    public decimal PercentOff { get; set; }

    public ICollection<PromotionOrder> Orders {get;set;}

    public Promotion()
    {
      Orders = new HashSet<PromotionOrder>();
    }
  }
}