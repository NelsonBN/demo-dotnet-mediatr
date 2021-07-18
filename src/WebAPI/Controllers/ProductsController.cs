using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WebAPI.Commands;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IMediator _mediator;

        private readonly ProductsStorage _storage;

        public ProductsController(
            ILogger<ProductsController> logger,
            IMediator mediator,
            ProductsStorage storage
        )
        {
            this._logger = logger;
            this._mediator = mediator;

            this._storage = storage;
        }


        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductRequest request)
        {
            var command = new AddProductCommand(
                request.Name,
                request.Quantity
            );

            var id = await this._mediator.Send(command);

            return this.Ok(id);
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var response = this._storage.GetList();

            return this.Ok(response);
        }
    }
}