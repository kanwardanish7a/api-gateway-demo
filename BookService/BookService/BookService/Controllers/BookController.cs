using Microsoft.AspNetCore.Mvc;

namespace BookService.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPortfolio()
        {
            // Simulate fetching portfolio
            var portfolio = new
            {
                Trades = new[]
                {
                    new { Symbol = "AAPL", Quantity = 100, Price = 150.25m },
                    new { Symbol = "GOOGL", Quantity = 50, Price = 2800.00m }
                }
            };
            return Ok(portfolio);
        }
    }
}
