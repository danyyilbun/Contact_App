using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;
using BLL;
namespace ContactExcercise.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ContactBAL CB = new ContactBAL();
            var records = CB.GetAll();

            return View(records);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ContactRec p)
        {
            ContactBAL CB = new ContactBAL();
            CB.Add(p);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            ContactBAL CB = new ContactBAL();
            var currentRecord = CB.Details(id);

            return View(currentRecord);
        }

        public ActionResult Delete(int id)
        {
            ContactBAL CB = new ContactBAL();
            CB.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ContactBAL CB = new ContactBAL();
            var record = CB.Details(id);

            return View(record);
        }

        [HttpPost]
        public ActionResult Edit(ContactRec p)
        {
            ContactBAL CB = new ContactBAL();
            CB.Update(p);

            return RedirectToAction("Index");
        }
    }
}