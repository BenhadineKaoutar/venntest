using System.Collections.Generic;
using System.Web.Mvc;
using venntest.Models;
using venntest.ViewModels;

namespace venntest.Views
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var dumbproducts = new List<Product> 
            { 
             new Product() { Id=1, Name = "name1", Description="description here of product 1", Price=120, Quantity=2000, InStock=9 },
             new Product() { Id=2, Name = "name2", Description="description here of product 2", Price=250, Quantity=1000, InStock=0 },
             new Product() { Id=3, Name = "name3", Description="description here of product 3", Price=20, Quantity=2500, InStock=500 }
            };

            var allproducts = new AllProductsViewModel() { Products = dumbproducts };
            
            return View(allproducts);
        }

        public ActionResult Edit(int id) 
        {
            return Content("id: " + id);
        }

        public ActionResult Details(int id)
        {
            return View();
        }


    }
}