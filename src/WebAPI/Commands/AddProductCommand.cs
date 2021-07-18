using MediatR;
using System;

namespace WebAPI.Commands
{
    public record AddProductCommand : IRequest<Guid>
    {
        public string Name { get; init; }
        public uint Quantity { get; init; }

        public AddProductCommand(string name, uint quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }
    }
}