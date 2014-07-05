using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GoogleChart.Dto;
using GoogleChart.BusinessLayer;

namespace GoogleChart.Controllers
{
    public class ProductApiController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<BestSellingProducts> GetBestSellingProducts()
        {
            var productBo = new ProductBo();
            return productBo.GetBestSellingProducts();
        }
    }
}