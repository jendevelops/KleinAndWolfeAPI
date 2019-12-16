using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kleinandwolfeapi.Models;

namespace kleinandwolfeapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {

    private ApplicationDbContext _db;

    public ValuesController(ApplicationDbContext db)
    {
      _db = db;
    }
    // GET api/values/orders
    [HttpGet("orders")]
    public ActionResult<IEnumerable<Order>> GetOrders(string startDate, string endDate, int brandId)
    {
      DateTime startDateValue = new DateTime();
      DateTime endDateValue = new DateTime();
      var query = _db.Orders.AsQueryable();
      if (DateTime.TryParse(startDate, out startDateValue) && DateTime.TryParse(endDate, out endDateValue))
      {
        query.Where(o => (o.Date >= startDateValue) && (o.Date <= endDateValue) && (o.ClientId == brandId));
      }
      return query.ToList();

    }

    [HttpGet("traffic")]
    public ActionResult<IEnumerable<Order>> GetTraffic(string startDate, string endDate, int brandId)
    {
      DateTime startDateValue = new DateTime();
      DateTime endDateValue = new DateTime();
      var query = _db.SiteTraffic.AsQueryable();
      if (DateTime.TryParse(startDate, out startDateValue) && DateTime.TryParse(endDate, out endDateValue) );
      {
        query.Where(o => (o.Date >= startDateValue) && (o.Date <= endDateValue) && (o.ClientId == brandId));
      }
      return query.ToList();

    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
