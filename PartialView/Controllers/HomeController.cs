using PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "Partial View";

            SelectDDL selection = new SelectDDL();

            return View(selection);
        }

        //private List<PartialModel> SampleData()
        //{
        //    List<PartialModel> model = new List<PartialModel>();

        //    model.Add(new PartialModel()
        //    {

        //        Name = "Rima",
        //        Age = 20,
        //        Address = "Kannur"
        //    });

        //    model.Add(new PartialModel()
        //    {

        //        Name = "Rohan",
        //        Age = 23,
        //        Address = "Ernakulam"
        //    });
        //    model.Add(new PartialModel()
        //    {
        //        Name = "Reshma",
        //        Age = 22,
        //        Address = "Kannur"
        //    });

        //    return model;
        //}

    }
}
