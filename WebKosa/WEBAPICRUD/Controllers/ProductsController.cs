using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPICRUD.Models;
namespace WEBAPICRUD.Controllers
{
    /*
    URI                          Method      처리 
    /api/products                  GET        모든 제품의 목록을 조회                     >> GetAllProducts()
    /api/products/id               GET        id를 기준으로 한제품을 조회                 >> GetProduct(int id)  
    /api/products?category=        GET        카테고리를 기준으로 한 제품을 조회          >> GetProductsByCategory(string category)
    /api/products                  POST       새로운 제품을 생산합니다 (new , insert)     >> PostProduct(Product item)
    /api/products/id               PUT        제품을 갱신합니다(수정) (update where id)   >> PutProduct(int id, Product product)
    /api/products/id               DELETE     제품을 삭제합니다                           >> DeleteProduct(int id)
 */
    public class ProductsController : ApiController
    {
       static readonly IProductRepository repository = new ProductRepository();

        public IEnumerable<Product> GetAllProducts() {  //함수의 이름이 중요 Get 으로 시작
            return repository.GetAll();
        }

        public Product GetProduct(int id) {

            Product item = repository.Get(id);
            if (item == null) { 
                throw new HttpResponseException(HttpStatusCode.NotFound);   
            }
            return item;
        }

        public IEnumerable<Product> GetProductsByCategory(string category) {  //인터페이스 함수 추가 하셔도 됩니다 .. 안만들어서 ..
           return  repository.GetAll().Where(p => string.Equals(p.Category, category , StringComparison.OrdinalIgnoreCase));        
        }

        public Product PostProduct(Product item) { 
             return repository.Add(item);
        }

        public void PutProduct(int id, Product product) {
            product.Id = id;
            if (!repository.Update(product)){
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        
        }

        public void DeleteProduct(int id) {
            Product item = repository.Get(id);
            if (item == null) {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            repository.Remove(id);
        }

    }
}
