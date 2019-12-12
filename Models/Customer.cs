using System;
using System.Collections.Generic;

namespace kleinandwolfeapi.Models
{
  public class Customer
  {
    public int CustomerId { get; set; }
    public int Name { get; set; }
    public DateTime DateJoined{get;set;}
    public DateTime LastPurchase {get;set;}
    public DateTime LastVisit {get;set;}

    public Client Client { get; set; }

  }

}