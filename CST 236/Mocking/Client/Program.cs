using System;
using Microsoft.Practices.Unity;
using ProductInventory;

namespace Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var repository = new ProductRespository();
            var repository = IoC.GetInstance().Resolve<IProductRepository>();

            foreach (var product in repository.FindAll())
            {
                Console.WriteLine(product);
            }

            Console.ReadKey();
        }
    }
}
