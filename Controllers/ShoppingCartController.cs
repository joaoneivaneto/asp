using BethenyPieShop2.Models;
using BethenyPieShop2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethenyPieShop2.Controllers
{
    public class ShoppingCartController : Controller
    {
       
        private readonly IPieRepository _pieRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPieRepository pieRepository, ShoppingCart shoppingCart)
        {
            _pieRepository = pieRepository;
            _shoppingCart = shoppingCart;
        } 
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        } 
        public RedirectToActionResult AddToShoppingCart(int pieId)
        {
            var selectPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieId == pieId);
            if(selectPie != null)
            {
                _shoppingCart.AddToCart(selectPie, 1);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int pieId)
        {
            var selectPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieId == pieId);
            if (selectPie != null)
            {
                _shoppingCart.RemoveFromCart(selectPie);
            }
            return RedirectToAction("Index");
        }

    }
}
