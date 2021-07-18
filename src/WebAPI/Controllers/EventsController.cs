using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        private readonly EventsStorage _storage;

        public EventsController(
            ILogger<ProductsController> logger,
            EventsStorage storage
        )
        {
            this._logger = logger;

            this._storage = storage;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var response = this._storage.GetList();

            return this.Ok(response);
        }
    }
}