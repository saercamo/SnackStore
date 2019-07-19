using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnackStore.Models;

namespace SnackStore.Services
{
    public interface IPriceLogServices
    {
        Boolean AddPriceLog(PriceLog precio);
        Dictionary<int, PriceLog> GetPriceLog(int product_id);
        int IdMaximo();
    }
}
