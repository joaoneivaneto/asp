using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethenyPieShop2.Models
{
    public class OrderRepository: IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;

        }
        public void  CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var ShoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach(var shoppingCartItem in ShoppingCartItems)
            {
                var OrderDeatil = new OrderDetail
                {
                    Amout = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Pie.PieId,
                    Price = shoppingCartItem.Pie.Price
                };
                order.OrderDetails.Add(OrderDeatil);
            }
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

        }
    }
}
