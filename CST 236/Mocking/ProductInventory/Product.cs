namespace ProductInventory
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public override bool Equals(object obj)
        {
            var product = obj as Product;
            return this.ProductId == product.ProductId;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Name: {1}, Description: {2}, Price: {3}", ProductId, Name, Description, Price);
        }
    }
}
