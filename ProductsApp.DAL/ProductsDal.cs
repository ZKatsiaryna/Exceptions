using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp.DAL
{
    public class ProductsDal
    {
        public List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Rachel", Category = "Groceries", Price = 3 },
            new Product { Id = 2, Name = "Nigella", Category = "Toys", Price = 3.88M },
            new Product { Id = 3, Name = "Justeene", Category = "Hardware", Price = 20.99M }
        };
    }
}
