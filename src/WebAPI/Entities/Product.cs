using System;

namespace WebAPI.Entities
{
    public class Product
    {
        public Guid Id { get; init; }
        public string Name { get; private set; }
        public uint Quantity { get; private set; }

        public Product(string name)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Quantity = 0;
        }

        public void AddQuantity(uint quantity)
        {
            this.Quantity += quantity;
        }
    }
}