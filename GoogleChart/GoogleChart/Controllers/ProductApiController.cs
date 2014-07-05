using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GoogleChart.Controllers
{
    public class ProductApiController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> GetBestSellingProducts()
        {
            return new string[] { "value1", "value2" };
        }
    }
}