using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleChart.Dto
{
    /// <summary>
    /// Entidade que representa os produtos mais
    /// vendidos.
    /// </summary>
    public class BestSellingProducts
    {
        private Product _product;

        private Int32 _quantity;

        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public Int32 Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public BestSellingProducts(Product product,Int32 quantity)
        {
            _product = product;
            _quantity = quantity;
        }
    }
}
