using SportsShop.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsShop.WebUi.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository db;
        public int PageSize = 4;

        public ProductController(IProductRepository _db) {
            db = _db;
        }
        // GET: Product
        public ViewResult List(int page = 1)
        {
            var products = db.Products.Skip((page - 1) * PageSize).Take(PageSize);
            //var products = db.Products.ToList();
            return View(products);
        }
    }
}