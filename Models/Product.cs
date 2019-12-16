using System.Collections.Generic;

namespace kleinandwolfeapi.Models
{
  public class Product
  {
    public int ProductId { get; set; }
    public int ClientId {get;set;}
    public virtual Client Client {get;set;}
    public string Name { get; set; }
    public string Description { get; set; }

    public ICollection<OrderProduct> Orders { get; set; }

    public Product()
    {
      Orders = new HashSet<OrderProduct>();
    }
  }
}