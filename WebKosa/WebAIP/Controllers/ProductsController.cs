using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAIP.Models;
namespace WebAIP.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };


        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return product;
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return products.Where(
                (p) => string.Equals(p.Category, category,
                    StringComparison.OrdinalIgnoreCase));
        }

        /*
         GetAllProducts 메서드는 제품들의 전체 목록을 IEnumerable<Product> 형식으로 반환합니다.
         GetProductById 메서드는 제품의 ID를 지정해서 단일 제품을 찾습니다.
         GetProductsByCategory 메서드는 특정 카테고리의 모든 제품들의 목록을 반환합니다. 
          
          
        컨트롤러 메서드	URI
        GetAllProducts	         /api/products
        GetProductById	         /api/products/id
        GetProductsByCategory	 /api/products/?category=category



        동작	HTTP 메서드	관련 URI
        모든 제품들의 목록을 가져옵니다.	        GET	/api/products
        ID를 기준으로 제품을 조회합니다.	        GET	/api/products/id
        카테고리를 기준으로 제품들을 조회합니다.  	GET	/api/products?category=category
                        새로운 제품을 생성합니다.	POST	/api/products
                                 제품을 갱신합니다.	PUT	/api/products/id
                                제품을 삭제합니다.	DELETE	/api/products/id


         */
        /*
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        */
    }
}