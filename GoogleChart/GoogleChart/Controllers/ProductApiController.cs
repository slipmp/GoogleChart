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
    /// <summary>
    /// Classe que representa o WebAPI Controller. 
    /// </summary>
    public class ProductApiController : ApiController
    {
        /// <summary>
        /// Método no controller que faz a busca na Camada de negócios.
        /// O retorno será básicamente o que será usado no nosso gráfico.
        /// </summary>
        /// <returns>Retorna no formato JSON</returns>
        public IEnumerable<BestSellingProducts> GetBestSellingProducts()
        {
            var productBo = new ProductBo();
            return productBo.GetBestSellingProducts();
        }
    }
}