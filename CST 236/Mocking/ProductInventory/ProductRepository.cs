using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProductInventory
{
    public class ProductRepository : IProductRepository
    {
        public IList<Product> FindAll()
        {
            var products = new List<Product>();
            using (var inFile = new StreamReader(@"..\..\Data\ProductDatabase.txt"))
            {
                var line = string.Empty;
                while ((line = inFile.ReadLine()) != null)
                {
                    var data = line.Split(';');
                    products.Add(new Product
                    {
                        ProductId = Convert.ToInt32(data[0]),
                        Name = Convert.ToString(data[1]),
                        Description = Convert.ToString(data[2]),
                        Price = Convert.ToDecimal(data[3])
                    });
                }    
            }
            return products;
        }

        public Product FindByName(string productName)
        {
            return FindAll().SingleOrDefault(product => product.Name.Equals(productName));
        }

        public Product FindById(int productId)
        {
            return FindAll().SingleOrDefault(product => product.ProductId.Equals(productId));
        }

        public bool Save(Product target)
        {
            var saveStatus = false;
            var products = FindAll();
            for (var i = 0; i < products.Count; ++i)
            {
                if (products[i].Equals(target))
                {
                    products[i] = target;
                    saveStatus = true;
                    using (var outFile = new StreamWriter(@"..\..\Data\ProductDatabase.txt"))
                    {
                        foreach (var product in products)
                        {
                            outFile.WriteLine("{0};{1};{2};{3}",product.ProductId, product.Name, product.Description, product.Price);
                        }
                        break;
                    }
                }
            }
            return saveStatus;
        }
    }
}
