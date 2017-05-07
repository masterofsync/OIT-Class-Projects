using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProductInventory;
using System.Collections.Generic;
using System.Linq;

namespace ProductInventoryUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            IList<Product> products = new List<Product>
            {
                 new Product { ProductId = 1, Name = "C# Unleashed", Description = "Short description here", Price = 49.99m },
                 new Product { ProductId = 2, Name = "ASP.Net Unleashed", Description = "Short description here", Price = 59.99m },
                 new Product { ProductId = 3, Name = "Silverlight Unleashed", Description ="Short description here", Price = 29.99m }
            };
            Mock<IProductRepository> mockProductRepository = new Mock<IProductRepository>();

            mockProductRepository.Setup(x => x.FindAll()).Returns(products);

            mockProductRepository.Setup(x => x.FindById(It.IsAny<int>())).Returns((int i) => products.Where(x => x.ProductId == i).Single());

            mockProductRepository.Setup(x => x.FindByName(It.IsAny<string>())).Returns((string s) => products.Where(x => x.Name == s).Single());

            mockProductRepository.Setup(x => x.Save(It.IsAny<Product>())).Returns(
                (Product target) =>
                {
                    DateTime now = DateTime.Now;

                    if (target.ProductId.Equals(default(int)))
                    {
                        target.ProductId = products.Count() + 1;
                        products.Add(target);
                    }
                    else
                    {
                        var original = products.Where(q => q.ProductId == target.ProductId).Single();

                        if (original == null)
                        {
                            return false;
                        }

                        original.Name = target.Name;
                        original.Price = target.Price;
                        original.Description = target.Description;
                    }
                    return true;
                });
            this.MockProductsRepository = mockProductRepository.Object;

        }

        public TestContext TestContext { get; set; }

        public readonly IProductRepository MockProductsRepository;

        [TestMethod]

        public void CanReturnProductById()
        {
            var testProduct = this.MockProductsRepository.FindById(2);

            Assert.IsNotNull(testProduct);
            Assert.IsInstanceOfType(testProduct, typeof(Product));
            Assert.AreEqual("ASP.Net Unleashed", testProduct.Name);
        }

        [TestMethod]

        public void CanReturnProductByName()
        {
            var testProduct = this.MockProductsRepository.FindByName("Silverlight Unleashed");

            Assert.IsNotNull(testProduct);
            Assert.IsInstanceOfType(testProduct, typeof(Product));
            Assert.AreEqual(3, testProduct.ProductId);
        }

        [TestMethod]

        public void CanReturnAllProducts()
        {
            var testProduct = this.MockProductsRepository.FindAll();

            Assert.IsNotNull(testProduct);
            Assert.IsInstanceOfType(testProduct, typeof(List<Product>));
            Assert.AreEqual(3, testProduct.Count());
        }

        [TestMethod]

        public void InsertANewProduct()
        {
            // a.Verify the pre - insert count
            var products = MockProductsRepository.FindAll();
            Assert.AreEqual(3,products.Count);

            //b.Instantiate a new product
            var newProduct = new Product
            {
                Description="This is New Product",
                Name="New Products Name",
                Price=2.9m
            };


            //c.Try saving the new product in the repository: MockProductsRepository.Save(your new product instance name here);
            var saveResult= MockProductsRepository.Save(newProduct);

            //d.Verify the product has been saved
            Assert.IsTrue(saveResult);

            //i.Retrieve the product back using the FindByName() method
            var productToRetrieve = MockProductsRepository.FindByName("New Products Name");

            Assert.IsNotNull(productToRetrieve);

            //ii.Verify the repository count is correct

            var totalProducts = MockProductsRepository.FindAll().Count();

            Assert.AreEqual(4,totalProducts);

        }

        [TestMethod]

        public void UpdateAProduct()
        {
            //a.Get a product from the repository (using FindById() or FindByName())
            var product = MockProductsRepository.FindById(2);

            //b.Change one of the product’s properties
            product.Description = "New Updated Description!";

            //c.Save the changes(using Save())
            MockProductsRepository.Save(product);

            //d.Verify the change(get the product back and verify it has the new property you changed)
            product = MockProductsRepository.FindById(2);

            Assert.AreEqual(product.Description, "New Updated Description!");

        }
    }
}
