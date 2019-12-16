using System.Collections.Generic;

namespace kleinandwolfeapi.Models
{
  public class Client{
    public int ClientId {get;set;}
    public int Name {get;set;}
    public int PartnerId{get;set;}
    public virtual Partner Partner {get;set;}
    public virtual ICollection<Product> Products {get;set;}

    Client(){
      Products = new HashSet<Product>();
    }
  }
  
}