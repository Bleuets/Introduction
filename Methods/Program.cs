using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Product urun1 = new Product();
            urun1.productName = "Product 1";
            urun1.productPrice = 10;
            urun1.productDetail = "This is Product number 1.";

            Product urun2 = new Product();
            urun2.productName = "Product 2";
            urun2.productPrice = 100;
            urun2.productDetail = "This is Product number 2.";

            Product[] products = new Product[] {urun1, urun2};

            foreach (Product product in products)
            {
                //Sağdan Sola.
                //products  = ürünleri gez.
                //product   = her ürün için ad.
                //Product   = ürünler için class adı.

                Console.WriteLine(product.productName);
                Console.WriteLine(product.productPrice);
                Console.WriteLine(product.productDetail);
                Console.WriteLine(" ");
            }

            Console.WriteLine("- - - Methods - - -");

            //Instance
            //Encapsulation'u oku.
            CartManager cartManager = new CartManager();
            cartManager.AddedToCart(urun1);
            cartManager.AddedToCart(urun2);
            //Product class olarak tanımlı. urun1 ve urun2 olarak 2 ürün mevcut.
            //Method, Product'tan product alarak, geri dönütünü productName ile sağlıyor.
            //AddedToCart(urun1) gittiğinde, "urun1.productName added to cart." dönütü sağlanıyor.

            //AddedToCartAlternative
            //Eğer "Stok" gibi bir bilgi eklenmesi gerekirse, methodun değiştirilmesi gerekir.
            //Stok eklenmesi gerekir, stok eklendikten sonra aşağıdaki kodun "İMZA"sının doğru olması için stok belirtilmelidir.
            //Yanlış bir pratiktir.
            cartManager.AddedToCartAlternative("Product 3", 1000, "Product 3 with alternative method.");

        }
    }
}
