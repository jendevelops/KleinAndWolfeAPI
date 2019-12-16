using System;

namespace kleinandwolfeapi.Models
{
  public class Traffic
  {
    public int TrafficId { get; set; }
    public int ClientId {get;set;}
    public DateTime Date {get;set;}
    public int Location { get; set; }
    public Order Order {get;set;}
  }

}