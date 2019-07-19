using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnackStore.Models;
using SnackStore.Services;

namespace SnackStore.Services
{
    public class ProductServices : IProductServices
    {
        private readonly Dictionary<int, Product> _products;
        

        //Constructor
        public ProductServices()
        {
            _products = new Dictionary<int, Product>();           
        }
        public Product AddProduct(Product products)
        {            
            _products.Add(products.product_id, products);

            return products;
        }
        
        public Dictionary<int, Product> GetProducts()
        {
            return _products;
        }

        //Funcion: enStock
        public Dictionary<int, Product> GetAvailableProducts()
        {
            IEnumerable<KeyValuePair<int, Product>> r;            
             r = _products.Where(p => p.Value.quantity_stock != 0);


            return r.ToDictionary(x => x.Key, x => x.Value);
        }

        public Boolean DeleteProduct(int prod_id)
        {
            var eliminado = _products.Remove(prod_id);
            

            return eliminado;
        }

        public Boolean UpdateStock(int product_id, int quantity)
        {
            _products[product_id].quantity_stock = quantity;

            return true;
        }

        public Boolean UpdatePrice(int product_id, float price, IPriceLogServices _precios)
        {
            PriceLog precios = new PriceLog();
            float price_old;
            price_old = _products[product_id].price_product;

            _products[product_id].price_product = price;

            //Construir objeto para registrar bitacora
            //precios.priceLog_id = 1;                        
            precios.priceLog_id = _precios.IdMaximo();
            precios.price_current = price;
            precios.price_old = price_old;
            precios.product_id = product_id;
            precios.price_updated = DateTime.Now;

            //Añadir bitacora 
            return _precios.AddPriceLog(precios);
        }
    }
}
