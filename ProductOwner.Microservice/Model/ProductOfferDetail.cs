using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOwner.Microservice.Model
{
    public class ProductOfferDetail
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductOfferDetails { get; set; }
    }
}
