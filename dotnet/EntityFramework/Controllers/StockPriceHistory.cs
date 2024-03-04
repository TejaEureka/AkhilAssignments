using Microsoft.AspNetCore.Mvc;
using EntityFramework.Interfaces;
using EntityFramework.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    public class StockPriceHistory : Controller
    {
        IStockPriceHistoryService service;
        public StockPriceHistory(IStockPriceHistoryService stockPriceHistoryService)
        {
            service = stockPriceHistoryService;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public List<StockPriceHistory> Get(int id)
        {
            return StockPriceHistoryService.GetStockPriceHistory(tickersymbol);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

