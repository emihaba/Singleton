using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Product
    {
        public float price { private set; get; }

        private Product()
        {

        }

        static private Product getInstance()
        {
            return new Product();
        }

        public Product setPrice(float newPrice)
        {
            this.price = newPrice;

            return this;
        }

    }
}
