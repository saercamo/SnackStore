using Microsoft.AspNetCore.Mvc;
using SnackStore.Models;
using SnackStore.Services;
using System;
using System.Collections.Generic;

namespace SnackStore.Controllers
{
    //[Route("api/[controller]")]
    [Route("v1")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _services;
        private readonly IPriceLogServices _priceServices;

        public ProductController(IProductServices services, IPriceLogServices priceServices)
        {
            _services = services;
            _priceServices = priceServices;
        }

        [HttpPost]
        [Route("AddProduct")]
        public ActionResult<Product> AddProduct(Product products)
        {
            var product = _services.AddProduct(products);                         

            //var product = _services
            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpGet]
        [Route("GetProducts")]
        public ActionResult<Dictionary<int, Product>> GetProducts()
        {
            var producto = _services.GetProducts();

            if (producto.Count == 0)
            {
                return NotFound();
            }

            return producto;

        }

        [HttpGet]
        [Route("GetAvailableProducts")]
        public ActionResult<Dictionary<int, Product>> GetAvailableProducts()
        {
            var producto = _services.GetAvailableProducts();

            if (producto.Count == 0)
            {
                return NotFound();  //Status Code 404
            }

            return producto;
        }

        [HttpDelete("{id}")]
        [Route("DeleteProduct")]
        public ActionResult<StatusCodeResult> DeleteProduct(int product_id)
        {
            var deleted = _services.DeleteProduct(product_id);

            if (deleted == true)
                return Ok();
            else
                return NotFound();

        }

        [HttpPost]
        [Route("UpdateStock")]
        public ActionResult<StatusCodeResult> UpdateStock(int product_id, int quantity)
        {
            var updated = _services.UpdateStock(product_id, quantity);

            if (updated == true)
                return Ok();
            else
                return NotFound();
        }

        [HttpPost]
        [Route("UpdatePrice")]
        public ActionResult<StatusCodeResult> UpdatePrice(int product_id, float price)
        {
            var _updated = _services.UpdatePrice(product_id, price, _priceServices);

            if (_updated == true)
                return Ok();
            else
                return NotFound();
        }
    }
}