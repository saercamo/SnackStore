using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace SnackStore.Models
{
    public class PriceLog
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int priceLog_id { get; set; }
        public int product_id { get; set; }
        public float price_old { get; set; }
        public float price_current { get; set; }
        public DateTime price_updated { get; set; }
    }
}
