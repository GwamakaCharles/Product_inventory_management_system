using System;

namespace library
{
    /// <summary>
    /// Manages products carried in inventory.
    /// </summary>
    public class Product
    {
        public Product(int productId, string productName, string description)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;
            
            Console.WriteLine("Product instance has a name: " + ProductName);
        }
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        private int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        
        public string SayHello()
        {
            return "Hello " + ProductName + " (" + ProductId + "): " + Description;
        }

    }
}
