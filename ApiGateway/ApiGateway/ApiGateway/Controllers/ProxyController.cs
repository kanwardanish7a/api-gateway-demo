using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiGateway.Controllers
{
    [Authorize] // Require authentication for all endpoints in this controller

    public class ProxyController : Controller
    {
        private readonly HttpClient _httpClient;

        public ProxyController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpPost("trades")]
        public async Task<IActionResult> PlaceTrade([FromBody] object trade)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5001/api/trades", trade);
            var content = await response.Content.ReadAsStringAsync();
            return StatusCode((int)response.StatusCode, content);
        }

        [HttpGet("books")]
        public async Task<IActionResult> GetPortfolio()
        {
            var response = await _httpClient.GetAsync("http://localhost:5002/api/books");
            var content = await response.Content.ReadAsStringAsync();
            return StatusCode((int)response.StatusCode, content);
        }


    }
}
