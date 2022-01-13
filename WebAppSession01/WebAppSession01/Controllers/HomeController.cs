using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppSession01.Models;

namespace WebAppSession01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            String _page = "This is Home"; //Variable
            Product _pd = new Product();
            _pd.ProductID = 1002;
            _pd.ProductName = "Milk Pack";

            ViewBag.Products = _pd.GetAllProducts();
            ViewBag.PageName = _page;
            ViewBag.ProductData = _pd;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
    }
}