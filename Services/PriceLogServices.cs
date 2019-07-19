using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnackStore.Models;

namespace SnackStore.Services
{
    public class PriceLogServices : IPriceLogServices
    {
        private readonly Dictionary<int, PriceLog> _precios;

        public PriceLogServices()
        {
            _precios = new Dictionary<int, PriceLog>();
        }

        public Boolean AddPriceLog(PriceLog precio)
        {
            
            _precios.Add(precio.priceLog_id, precio);

            return true;
            //throw new NotImplementedException();
        }

        public Dictionary<int, PriceLog> GetPriceLog(int producto_id)
        {
            IEnumerable<KeyValuePair<int, PriceLog>> r;
            r = _precios.Where(p => p.Value.product_id == producto_id);
            
            return r.ToDictionary(x => x.Key, x => x.Value);
        }

        //Funcion para incrementar en uno el identificador de bitacora
        public int IdMaximo()
        {
            var maximo = _precios.SingleOrDefault();
            
            return maximo.Key + 1;


        }
    }
    
}
