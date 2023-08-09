using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurAppNunitExTwo
{
    public class ProductList<T>
    {
        List<T> products = new List<T>();

        public void AddProduct(T product)
        {
            products.Add(product);
        }

        public void RemoveProduct(T Product) 
        { 
            products.Remove(Product);
        }

        public bool Contains(T Product)
        {
            return products.Contains(Product);
        }

        public int Count { get { return products.Count;} }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

}