using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //Naming convention
        public void Add(Product product) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + product.Name);
            
        }

        public void Add2(string productName, string productExplanation, double productCost, int productQuantity)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + productName);
        }

    }
}
