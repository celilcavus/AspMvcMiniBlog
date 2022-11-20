using MyMiniBlog1.Models.Crud.CrudHelperMetot;
using MyMiniBlog1.Models.Crud.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMiniBlog1.Controllers
{
    public class HomeController : Controller
    {
        CrudHomePage page = null;
        public HomeController()
        {
            page = new CrudHomePage();
        }
        // GET: Home
        public ActionResult homePage()
        {
            return View(page.getviewList($"select * from {ViewsName.ViewMyBlog.ToString()}"));
        }
    }
}