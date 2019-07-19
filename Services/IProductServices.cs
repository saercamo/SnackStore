using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnackStore.Models;
using SnackStore.Services;

namespace SnackStore.Services
{
    public interface IProductServices
    {
        
        Product AddProduct(Product products);        
        Dictionary<int, Product> GetProducts();
        Dictionary<int, Product> GetAvailableProducts();
        Boolean DeleteProduct(int prod_id);
        Boolean UpdateStock(int prod_id, int quantity);
        Boolean UpdatePrice(int product_id, float price, IPriceLogServices _precios);
    }
}
