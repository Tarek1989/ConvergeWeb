using ConvergeDB;
using ConvergeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConvergeWeb.Controllers
{
    public class ConvergeController : Controller
    {
        // GET: Converge

        /*Always remember that that action's method name should be identical with the View
        In this case action method Home should have a View cshtml called Home. */


        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Products()
        {
            //Instantiatin data model
            Product p = new Product();
            //Instantiatin class with db methods
            Repo<Product> r = new Repo<Product>();

            List<Product> showdata = r.GetData();


            return View(showdata);
            


        }
    }
}