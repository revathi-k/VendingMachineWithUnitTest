using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachineNew
{
    public class Product
    {
        private string prdName;
        private double prdPrice;
        private int prdId;

        public  Product(string prdName, double prdPrice,int prdId)
        {
            ProductName = prdName; ProductPrice = prdPrice; ProductID = prdId;
        }
        public string ProductName
        {
            get { return prdName; }
            set { prdName = value; }
        }
        public double ProductPrice
        {
            get { return prdPrice; }
            set { prdPrice = value; }
        }
        public int ProductID
        {
            get { return prdId; }
            set { prdId = value; }
        }
    }
}