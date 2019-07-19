using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnackStore.Models;
using SnackStore.Services;

namespace SnackStore.Controllers
{
    [Route("v1")]
    [ApiController]
    public class PriceLogController : ControllerBase
    {
        private readonly IPriceLogServices _priceServices;

        //Constructor
        public PriceLogController(IPriceLogServices servicioPrecios)
        {
            _priceServices = servicioPrecios;
        }

        [HttpPost]
        [Route("GetPriceLog")]
        public ActionResult<Dictionary<int, PriceLog>> GetPriceLog(int product_id)
        {
            var priceLog = _priceServices.GetPriceLog(product_id);

            if (priceLog.Count == 0)
            {
                return NotFound();
            }
            
            return priceLog;
        }
    }
}