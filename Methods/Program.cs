using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Cost = 3.95;
            product1.Explanation = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Cost = 16.9;
            product2.Explanation = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Cost);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("---------------------");
                
            }

            Console.WriteLine("----------------Methods-------------");
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Ankara", 5.49, 26);
            sepetManager.Add2("Erik", "Can", 8.75, 4);
            sepetManager.Add2("Muz", "İthal", 12.5, 16);





        }
    }
}


// Don't Repeat Yourself (DRY) - Clean code - Best Practice (Doğru uygulama teknikleri)
