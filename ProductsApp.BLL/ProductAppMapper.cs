using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ProductsApp.DAL;

namespace ProductsApp.BLL
{
    public static class ProductAppMapper
    {
        public static IMapper Instance { get; private set; }

        static ProductAppMapper()
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<Product, ProductBll>(); });
            Instance = config.CreateMapper();
        }
    }
}
