using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CartManager
    {
        public void AddedToCart(Product product)
        {
            Console.WriteLine(product.productName + " added to cart.");
        }


        //Check the alternative.

        public void AddedToCartAlternative(string productName, double productPrice, string productDetail)
        {
            Console.WriteLine(productName + " added to cart.");
        }

    }
}
