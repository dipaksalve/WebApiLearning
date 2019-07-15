using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using WebApiLearning.Models;

namespace WebApiLearning.Controllers
{
    public class ValueController : ApiController
    {
        Product[] Products = new Product[]
        {
           new Product { Id=1, Name = "Playing Car", Category="Toys", Price = 10  },
           new Product { Id=2, Name = "Hammer", Category="Hardware", Price = 20 }
        };

        public void Post()
        {

        }

        public HttpResponseMessage Get()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Products);
            
            return response;
        }
    }
}
