using ProductOwner.Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOwner.Microservice.Services
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDetails>> GetProductListAsync();
        public Task<ProductDetails> GetProductByIdAsync(int id);
        public Task<ProductDetails> AddProductAsync(ProductDetails product);
        public bool SendProductOffer(ProductOfferDetail productOfferDetails);
    }
}
