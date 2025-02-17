using System;
using System.Collections.Generic;

namespace BlazorSportStoreAuth.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}