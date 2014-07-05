using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleChart.Dto;

namespace GoogleChart.BusinessLayer
{
    public class ProductBo
    {
        /// <summary>
        /// Esse método em teoria buscaria os dados em uma base de dados. 
        /// Por questões didáticas ele está fixo aqui.
        /// </summary>
        /// <returns></returns>
        public List<BestSellingProducts> GetBestSellingProducts()
        {

            return new List<BestSellingProducts>(new List<BestSellingProducts>
            {
                new BestSellingProducts(new Product("Notebook"),475),
                new BestSellingProducts(new Product("Roteador"),250),
                new BestSellingProducts(new Product("Celular"),50),
                new BestSellingProducts(new Product("Computador"),70),
                new BestSellingProducts(new Product("Livro"),30),
                new BestSellingProducts(new Product("Tablet"),130),
                new BestSellingProducts(new Product("Servidor"),20)
            });
        }
    }
}
