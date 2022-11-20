using MyMiniBlog1.Models.Crud.ContactAndAboutPage;
using MyMiniBlog1.Models.Crud.CrudHelperMetot;
using MyMiniBlog1.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMiniBlog1.Controllers
{
    public class ContactAndAboutController : Controller
    {
        CrudContactAndAboutPage page = null;
        contact cont = null;
        public ContactAndAboutController()
        {
            page = new CrudContactAndAboutPage();
            cont = new contact();
        }
        // GET: ContactAndAbout
        public ActionResult about()
        {
            return View(page.getaboutList($"select * from {TableName.about.ToString()}"));
        }
        public ActionResult contact()
        {
           
            
            return View();
        }
        [HttpPost]
        public ActionResult contact(contact contact)
        {
            cont.userid = contact.userid;
            cont.username = contact.username;
            cont.userlastname = contact.userlastname;
            cont.useremail  = contact.useremail;
            cont.usermessage = contact.usermessage;
            page.contactAdd(cont);
            return View();
        }
    }
}