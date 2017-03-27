using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_238_Lab_7
{
    class Product
    {
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public float UnitPrice { get; set; }
        public bool OnSale { get; set; }

        public Product(string product, int categoryID, float price, bool onSale)
        {
            ProductName = product;
            CategoryID = categoryID;
            UnitPrice = price;
            OnSale = onSale;
        }
    }
}
