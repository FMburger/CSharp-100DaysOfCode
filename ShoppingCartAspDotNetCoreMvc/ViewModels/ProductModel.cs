
using ShoppingCartAspDotNetCoreMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartAspDotNetCoreMvc.ViewModels
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
                    Id = "1", Name = "flower1", Photo = "thumb1.jpg", Price = 2.80
                },
                new Product()
                {
                    Id = "2", Name = "flower2", Photo = "thumb2.jpg", Price = 3.50
                },
                new Product()
                {
                    Id = "3", Name = "flower3", Photo = "thumb3.jpg", Price = 4.45
                },
                new Product()
                {
                    Id = "4", Name = "flower4", Photo = "thumb4.jpg", Price = 3.70
                },
                new Product()
                {
                    Id = "5", Name = "flower5", Photo = "thumb5.jpg", Price = 5.00
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
