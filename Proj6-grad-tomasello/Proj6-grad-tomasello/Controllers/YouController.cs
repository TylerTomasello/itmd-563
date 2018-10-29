using Proj6_grad_tomasello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// github repo link: https://github.com/TylerTomasello/itmd-563/tree/master/Proj6-grad-tomasello
namespace Proj6_grad_tomasello.Controllers
{
    public class YouController : Controller
    {
        
        // GET: You
        public ActionResult ViewBagNames()
        {
            List<string> list = new List<string>
            {
                "Tyler",
                "Steve",
                "Tom"
            };
            

            // Display Date and time but does not update
            ViewData["DateTime"] = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");

            ViewBag.Message = "Main view of names";
            ViewBag.Names = list;

            return View();
        }

        // GET: NameList
        public ActionResult List()
        {
            List<Name> namesList = new List<Name>
            {
                new Name()
                {
                    FirstName = "Tyler",
                    LastName = "Tomasello",
                    CourseName = "Intermediate Web App Dev"
                },

                new Name()
                {
                    FirstName = "Steve",
                    LastName = "Rogers",
                    CourseName = "History"
                },

                new Name()
                {
                    FirstName = "Tom",
                    LastName = "Tanks",
                    CourseName = "Engineering"
                }
            };
            ViewBag.Message = "Hard Code the list";

            // Display Date and time but does not update
            ViewData["DateTime"] = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");

            return View(namesList);
        }
        public ActionResult Create()
        {
            // Display Date and time but does not update
            ViewData["DateTime"] = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");

            return View();
        }
    }
}