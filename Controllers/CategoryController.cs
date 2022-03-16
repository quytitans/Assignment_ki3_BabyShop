using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssignmentWCD_BabyFashionShop.Data;

namespace AssignmentWCD_BabyFashionShop.Controllers
{
    public class CategoryController : Controller
    {
        private ProductDBcontext productDBcontext = new ProductDBcontext();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
    }
}