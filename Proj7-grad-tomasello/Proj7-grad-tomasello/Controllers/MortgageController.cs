using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proj7_grad_tomasello.Controllers
{
    public class MortgageController : Controller
    {
        // GET: Mortgage
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult CalcMortgage()
        {
            // Display Date and time but does not update
            ViewData["DateTime"] = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");

            return View();
        }
    }
}