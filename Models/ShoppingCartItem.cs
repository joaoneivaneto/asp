using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethenyPieShop2.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Pie Pie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }

        public static implicit operator ShoppingCartItem(ShoppingCart v)
        {
            throw new NotImplementedException();
        }
    }
}
