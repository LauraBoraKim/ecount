using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] {
            new Product { Id = 1, Name = "soup" , Category="Foods" , Price= 1},
            new Product { Id = 2, Name = "yoyo" , Category="Toys" ,  Price= 4},
            new Product { Id = 3, Name = "note" , Category="Elec" ,  Price= 10}
        };

        //Action  Method
        //      /api/products     >> GET                          >> GetAllProducts
        //      /api/products/id  >> GET id                       >> GetProductsById  
        //      /api/products/?category=Toys  >>  GET              >> GetProdcutsByCategory

        //http://localhost:57604/api/products/                 >> GetAllProducts
        //http://localhost:57604/api/products/1                >> GetProductsById 
        //http://localhost:57604/api/products/?category=Toys   >> GetProdcutsByCategory
        public IEnumerable<Product> GetAllProducts() { 
            return products;
        }

        public Product GetProductById(int id) { 
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null) { 
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }

        public IEnumerable<Product> GetProductByName(string category) { 
            return products.Where(x => x.Category == category);
        }

    }
}
