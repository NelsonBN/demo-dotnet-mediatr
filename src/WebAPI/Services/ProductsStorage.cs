using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Entities;

namespace WebAPI.Services
{
    public class ProductsStorage
    {
        private List<Product> _storage { get; set; }

        public ProductsStorage()
        {
            this._storage = new List<Product>();
        }

        public void Add(Product product)
        {
            this._storage
                .Add(product);
        }

        public Product GetByName(string name)
        {
            var product = this._storage
                .SingleOrDefault(s => s.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));

            return product;
        }

        public IEnumerable<Product> GetList()
        {
            return this._storage;
        }
    }
}