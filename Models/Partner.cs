using System;
using System.Collections.Generic;

namespace kleinandwolfeapi.Models
{
  public class Partner
  {
    public int PartnerId {get;set;}
    public int Name {get;set;}
    public ICollection<Client> Clients {get;set;}

    public Partner()
    {
      Clients = new HashSet<Client>();
    }
  }
}
