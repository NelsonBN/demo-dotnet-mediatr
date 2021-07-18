using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using WebAPI.Commands;
using WebAPI.Entities;
using WebAPI.Services;

namespace WebAPI.Handlers
{
    public class ProductHandler
         : IRequestHandler<AddProductCommand, Guid>
    {
        private readonly IMediator _mediator;

        private readonly ProductsStorage _storage;

        public ProductHandler(
            IMediator mediator,
            ProductsStorage storage
        )
        {
            this._mediator = mediator;

            this._storage = storage;
        }

        public Task<Guid> Handle(AddProductCommand command, CancellationToken cancellationToken)
        {
            var product = this._storage
                .GetByName(command.Name);

            if(product == null)
            {
                product = new Product(command.Name);

                this._storage.Add(product);
            }
            
            product.AddQuantity(command.Quantity);


            this._mediator.Publish(
                new EventNotification($"ADDED product Id: {product.Id}, Name: {product.Name}, Quantity: {command.Quantity}")
            );

            return Task.FromResult(product.Id);
        }
    }
}