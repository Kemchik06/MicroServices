using Microsoft.AspNetCore.Mvc;
using ProductUser.Microservice.Model;
using ProductUser.Microservice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductUser.Microservice.Controllers
{
    public class UserOffersController : ControllerBase
    {
        private readonly IUserService userService;

        public UserOffersController(IUserService _userService) => userService = _userService;

        [HttpGet("offerlist")]
        public Task<IEnumerable<ProductOfferDetail>> ProductListAsync()
        {
            var productList = userService.GetProductListAsync();
            return productList;

        }

        [HttpGet("getofferbyid")]
        public Task<ProductOfferDetail> GetProductByIdAsync(int Id)
        {
            return userService.GetProductByIdAsync(Id);
        }
    }
}
