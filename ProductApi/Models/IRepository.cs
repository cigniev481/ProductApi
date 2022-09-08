using System;
using System.Collections.Generic;

namespace ProductApi.Models
{
    interface IRepository : IDisposable
    {
        IEnumerable<Product> GetProductList();
        Product GetProduct(int id);
        void Create(Product item);
        void Update(Product item);
        void Delete(int id);
        void Save();

    }
}
