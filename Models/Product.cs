using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace SnackStore.Models
{
    public class Product
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int product_id { get; set; }
        [Required]
        public string product_name { get; set; }
        public string product_description { get; set; }
        public DateTime creation_date { get; set; }        
        public int quantity_stock { get; set; }
        public float price_product { get; set; }
    }
}
