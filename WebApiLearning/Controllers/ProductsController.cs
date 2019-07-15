using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiLearning.Models;

namespace WebApiLearning.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] Products = new Product[]
        {
           new Product { Id=1, Name = "Playing Car", Category="Toys", Price = 10  },
           new Product { Id=2, Name = "Hammer", Category="Hardware", Price = 20 }
        };

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return this.Products;
        }

        [HttpGet]
        public IHttpActionResult GetProduct(int id)
        {
            var product = this.Products.FirstOrDefault((p) => p.Id == id);
            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
