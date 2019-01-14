using AHBC_JJ2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AHBC_JJ2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
         
            return View();

        }

        public ActionResult Edit(ProductsInputModel model)
        {
            if (ModelState.IsValid == true)
            {
                // Maybe save this?
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            else if (ModelState.IsValid == false)
            {
                return RedirectToRoute(new { controller = "Products", action = "Index" });
            }

            return View();
        }
    }
}