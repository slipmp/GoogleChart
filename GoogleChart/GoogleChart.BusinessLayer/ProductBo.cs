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
        public List<BestSellingProducts> BestSellingProducts()
        {

            return new List<BestSellingProducts>(new List<BestSellingProducts>
            {
                new BestSellingProducts(new Product("Notebook"),475),
                new BestSellingProducts(new Product("Roteador"),250),
                new BestSellingProducts(new Product("Celular"),50),
                new BestSellingProducts(new Product("Computador"),70),
                new BestSellingProducts(new Product("Livro"),30),
                new BestSellingProducts(new Product("Tablet"),130),
                new BestSellingProducts(new Product("Servidor"),10)
            });
        }
    }
}
