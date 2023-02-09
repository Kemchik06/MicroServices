using ProductUser.Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductUser.Microservice.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<ProductOfferDetail>> GetProductListAsync();
        public Task<ProductOfferDetail> GetProductByIdAsync(int id);
        public Task<ProductOfferDetail> AddProductAsync(ProductOfferDetail product);
    }
}
