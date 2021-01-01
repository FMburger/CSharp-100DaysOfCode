using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppigCartAspDotNetCoreMVC.ViewModels;

namespace ShoppigCartAspDotNetCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.findall();
            return View();
        }
    }
}
