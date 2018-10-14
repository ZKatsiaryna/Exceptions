using System;
using System.Collections.Generic;
using System.Linq;
using ProductsApp.DAL;

namespace ProductsApp.BLL
{
    public class ProductsBll
    {
        private ProductsDal ProductsDAL { get; set; }

        private List<ProductBll> Products { get; set; }

        public ProductsBll()
        {
            ProductsDAL = new ProductsDal();

            var source = ProductsDAL.products;
            Products = ProductAppMapper.Instance.Map<List<Product>, List<ProductBll>>(source);
        }

        /// <method>
        /// Get User Email By Firstname or Lastname and return VO
        /// </method>
        public IList<ProductBll> GetProducts()
        {
            return Products;
        }

        public ProductBll GetProduct(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new InvalidProductExeptions($"Unable to find a client by id {id}");
            }
            return product;
        }

        public void Post(ProductBll model)
        {
            if (model.Name == null)
            {
                throw new InvalidProductExeptions("Unable to add product without name");
            }
            try
            {
                var product = new ProductBll() { Id = model.Id, Category = model.Category, Name = model.Name, Price = model.Price };
                Products.ToList().Add(product);
            }
            catch (InvalidProductExeptions)
            {
                throw new InvalidProductExeptions("Unable to add product without name");
            }

            catch (NullReferenceException ex)
            {
                throw new NullReferenceException($"Exception caught: {ex}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception occurred: {ex}");
            }
        }

        public void Put(ProductBll model)
        {
            if (model.Name == null || model.Category == null)
            {
                throw new InvalidProductExeptions("The required fields are missing");
            }
            try
            {
                var product = new ProductBll() { Id = model.Id, Category = model.Category, Name = model.Name, Price = model.Price };
                Products.ToList().Add(product);
            }
            catch (InvalidProductExeptions)
            {
                throw new InvalidProductExeptions("The required fields are missing");
            }

            catch (NullReferenceException ex)
            {
                throw new NullReferenceException($"Exception caught: {ex}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception occurred: {ex}");
            }
        }

        public void Delete(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new InvalidProductExeptions($"Unable to find a client by id {id}");
            }
        }
    }
}
