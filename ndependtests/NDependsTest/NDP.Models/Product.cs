using System;
using NDP.Abstract;


namespace NDP.Models
{
    public class Product : IProduct
    {
        
        public string Name;
        public double Price;
        public uint Quantity;

        public Product(string name, double price, uint quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public void AddProduct(object obj)
        {
            throw new NotImplementedException();
        }

        public void ShowProducts(object obj)
        {
            throw new NotImplementedException();
        }

        public void RemoveProducts(object obj)
        {
            throw new NotImplementedException();
        }

        public double CalculateProductTax(object obj)
        {
            throw new NotImplementedException();
        }

        public uint CalculateProductQuantityInStorage(object obj)
        {
            throw new NotImplementedException();
        }
    }

   
}
