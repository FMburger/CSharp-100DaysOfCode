using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppigCartAspDotNetCoreMVC.Helper;
using ShoppigCartAspDotNetCoreMVC.Models;

namespace ShoppigCartAspDotNetCoreMVC.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(Item => Item.Product.Price * Item.Quantity);
            return View();
        }
    }
}
