using System;
using System.Collections.Generic;

namespace kleinandwolfeapi.Models
{
  public class Order
  {
    public int OrderId { get; set; }
    public DateTime Date {get;set;}
    public decimal Subtotal {get;set;}
    public decimal Tax {get;set;}
    public decimal Total {get;set;}

    public string Origination {get;set;}

    public double TimeToPurchase {get;set;}

    public Customer Customer {get;set;}

    public int ClientId { get; set; }
    public ICollection<PromotionOrder> Promotions { get; set; }
    public ICollection<OrderProduct> Products {get;set;} 


    public Order()
    {
      Promotions = new HashSet<PromotionOrder>();
      Products = new HashSet<OrderProduct>();
    }
  }

}