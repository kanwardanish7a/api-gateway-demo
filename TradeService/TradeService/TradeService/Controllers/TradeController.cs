using Microsoft.AspNetCore.Mvc;

namespace TradeService.Controllers
{
    [Route("api/trades")]
    public class TradeController : ControllerBase
    {
        [HttpPost]
        public IActionResult PlaceTrade([FromBody] Trade trade)
        {
            // Simulate trade placement logic
            return Ok(new { Message = "Trade placed successfully", Trade = trade });
        }
    }

    public class Trade
    {
        public string Symbol { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
