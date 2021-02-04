using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachineNew
{
    public class ListofProducts
    {
        List<Product> objProducts;
        public List<Product> GetProducts()
        {
            objProducts = new List<Product>();
            objProducts.Add(new Product("Cola", 1.00, 1));
            objProducts.Add(new Product("Chips", 0.50, 2));
            objProducts.Add(new Product("Candy", 0.65, 3));
            return objProducts;
        }
    }
}