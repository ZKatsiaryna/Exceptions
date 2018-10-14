using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.BLL;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        private ProductsBll ProductsBll { get; set; }

        public ProductsController()
        {
            ProductsBll = new ProductsBll();
        }

        public IEnumerable<ProductBll> GetAllProducts()
        {
            return ProductsBll.GetProducts();
        }

        public object GetProduct(int id)
        {
            try
            {
                var product = ProductsBll.GetProduct(id);
                return Ok(product);
            }
            catch(InvalidProductExeptions ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        public object Post([FromBody]ProductBll model)
        {
            try
            {
                ProductsBll.Post(model);
                return null;
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public object Put([FromBody]ProductBll model)
        {
            try
            {
                ProductsBll.Put(model);
                return null;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public object Delete(int id)
        {
            ProductsBll.Delete(id);
            try
            {
                ProductsBll.Delete(id);
                return Ok();
            }
            catch (InvalidProductExeptions ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}
