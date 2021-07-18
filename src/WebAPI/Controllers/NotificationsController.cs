using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        private readonly NotificationsStorage _storage;

        public NotificationsController(
            ILogger<ProductsController> logger,
            NotificationsStorage storage
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