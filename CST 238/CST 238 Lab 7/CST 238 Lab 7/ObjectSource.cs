using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_238_Lab_7
{
    class ObjectSource
    {
        private List<Category> categories;
        private List<Product> products;

        public ObjectSource()
        {
            categories = new List<Category>();
            categories.Add(new Category(0, "Softwares"));
            categories.Add(new Category(1, "School Equipments"));
            categories.Add(new Category(2, "Headphones"));
            categories.Add(new Category(3, "LCD Monitors"));
            categories.Add(new Category(4, "Computer Equipments"));

            products = new List<Product>();
            products.Add(new Product("Windows 7", 0, 99.99f, true));
            products.Add(new Product("Macintosh OSX", 0, 199.99f, false));
            products.Add(new Product("Microsoft Office 2014", 0, 198.99f, true));
            products.Add(new Product("Deep freeze", 0, 29.79f, false));
            products.Add(new Product("Pencil", 1, 0.25f, true));
            products.Add(new Product("Erasers", 1, 0.25f, false));
            products.Add(new Product("Sharpners", 1, 0.35f, true));
            products.Add(new Product("Rulers", 1, 0.29f, false));
            products.Add(new Product("Beats", 2, 99.99f, true));
            products.Add(new Product("Sony", 2, 89.99f, false));
            products.Add(new Product("Bose", 2, 98.99f, true));
            products.Add(new Product("Apple", 2, 79.99f, false));
            products.Add(new Product("19 inch Monitor", 3, 49.99f, true));
            products.Add(new Product("21 inch Monitor", 3, 59.99f, false));
            products.Add(new Product("24 inch Monitor", 3, 69.99f, false));
            products.Add(new Product("29 inch Monitor", 3, 79.99f, true));
            products.Add(new Product("Mac Lightning Cable", 4, 20.95f, true));
            products.Add(new Product("Vga to Hdmi Cable", 4, 5.99f, false));
            products.Add(new Product("Keyboard", 4, 19.99f, false));
            products.Add(new Product("Mouse", 4, 10.25f, true));

        }

        public IList<Category> GetCategory()
        {
            return categories;
        }

        public IList<Product> GetProducts(int categoryID)
        {
            IEnumerable<Product> result = from p in products where p.CategoryID == categoryID select p;
            return result.ToList<Product>();
        }
    }

    
}
