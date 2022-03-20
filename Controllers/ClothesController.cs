using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssignmentWCD_BabyFashionShop.Data;

namespace AssignmentWCD_BabyFashionShop.Controllers
{
    
    public class ClothesController : Controller
    {
        private ProductDBcontext productDBcontext = new ProductDBcontext();
        // GET: Clothes
        public ActionResult Index()
        {
            var clothesList = productDBcontext.Clothes.ToList();
            return View(clothesList);
        }

        public ActionResult SearchByName(string keyWord)
        {
            var clothes1 = productDBcontext.Clothes.Where(s => s.Name.Contains(keyWord));
            return PartialView("SearchByNamePatialView", clothes1);
        }

        public ActionResult TestView()
        {
            return View();
        }

        public ActionResult getAllProduct()
        {
            var clothesList = productDBcontext.Clothes.ToList();
            return View(clothesList);
        }
    }
}