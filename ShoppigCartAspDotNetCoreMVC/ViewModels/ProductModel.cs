using ShoppigCartAspDotNetCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppigCartAspDotNetCoreMVC.ViewModels
{
    public class ProductModel
    {
        public List<Product> _products { get; set; }
        public List<Product> findall()
        {
            _products = new List<Product>
            {
                new Product()
                {
                    Id = "1", Name = "book1", Photo = "thumb1.jpg", Price = 2.80
                },
                new Product()
                {
                    Id = "2", Name = "book2", Photo = "thumb2.jpg", Price = 3.50
                },
                new Product()
                {
                    Id = "3", Name = "book3", Photo = "thumb3.jpg", Price = 4.45
                },
                new Product()
                {
                    Id = "4", Name = "book4", Photo = "thumb4.jpg", Price = 3.70
                },
                new Product()
                {
                    Id = "5", Name = "book5", Photo = "thumb5.jpg", Price = 5.00
                }
            };
            return _products;
        }
        public Product find(string id)
        {
            List<Product> products = findall();
            var prod = products.Where(a => a.Id == id).FirstOrDefault();
            return prod;
        }
    }
}
