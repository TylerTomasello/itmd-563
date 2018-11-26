using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proj7_grad_tomasello.Models;

// Github link: https://github.com/TylerTomasello/itmd-563/tree/master/Proj7-grad-tomasello
namespace Proj7_grad_tomasello.Controllers
{
    public class CalcMortgagesController : Controller
    {
        private Proj7_grad_tomaselloContext db = new Proj7_grad_tomaselloContext();

        // GET: CalcMortgages
        public ActionResult Index()
        {
            // Display Date and time but does not update
            ViewData["DateTime"] = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");

            return View(db.CalcMortgages.ToList());
        }

        // GET: CalcMortgages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalcMortgage calcMortgage = db.CalcMortgages.Find(id);
            if (calcMortgage == null)
            {
                return HttpNotFound();
            }
            // Display Date and time but does not update
            ViewData["DateTime"] = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");

            return View(calcMortgage);
        }

        // GET: CalcMortgages/Create
        public ActionResult Create()
        {
            // Display Date and time but does not update
            ViewData["DateTime"] = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");

            return View();
        }

        // POST: CalcMortgages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Principle,Duration,Rate,Result")] CalcMortgage calcMortgage)
        {
            if (ModelState.IsValid)
            {
                ViewBag.CalculateTemp = CalculateMortgage.CalcMonthlyPayment(calcMortgage.Principle, calcMortgage.Duration, calcMortgage.Rate);
                //ViewBag.Msg = $"The Monthly Payment is {ViewBag.CalculateTemp}";
                string output = string.Format("Monthly Payment is {0:C}", ViewBag.CalculateTemp);
                calcMortgage.Result = output;

                db.CalcMortgages.Add(calcMortgage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            InterestAmounts();
            // Display Date and time but does not update
            ViewData["DateTime"] = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");
            return View(calcMortgage);
        }

        // GET: CalcMortgages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalcMortgage calcMortgage = db.CalcMortgages.Find(id);
            if (calcMortgage == null)
            {
                return HttpNotFound();
            }

            // Display Date and time but does not update
            ViewData["DateTime"] = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");

            return View(calcMortgage);
        }

        // POST: CalcMortgages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Principle,Duration,Rate,Result")] CalcMortgage calcMortgage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calcMortgage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            // Display Date and time but does not update
            ViewData["DateTime"] = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");

            return View(calcMortgage);
        }

        // GET: CalcMortgages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalcMortgage calcMortgage = db.CalcMortgages.Find(id);
            if (calcMortgage == null)
            {
                return HttpNotFound();
            }

            // Display Date and time but does not update
            ViewData["DateTime"] = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");

            return View(calcMortgage);
        }

        // POST: CalcMortgages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CalcMortgage calcMortgage = db.CalcMortgages.Find(id);
            db.CalcMortgages.Remove(calcMortgage);
            db.SaveChanges();

            // Display Date and time but does not update
            ViewData["DateTime"] = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            // Display Date and time but does not update
            ViewData["DateTime"] = DateTime.Now.ToString("dddd, MMMM dd yyyy hh:mm:ss tt");

            base.Dispose(disposing);
        }

        private List<SelectListItem> InterestAmounts()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            for (float i=0.25f; i<10.25; i += 0.25f)
            {
                SelectListItem item = new SelectListItem { Text = i.ToString(), Value = i.ToString() };
                items.Add(item);
            }
            return items;
        }
    }
}
