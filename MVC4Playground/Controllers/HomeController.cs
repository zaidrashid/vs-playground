using MVC4Playground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4Playground.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Morning" : "Afternoon";
            return View();
            //return RedirectResult();
        }

        [HttpGet]
        public ViewResult RvspForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RvspForm(GuestResponse guestReponse)
        {
            // TODO: Email response to the party organizer

            if (ModelState.IsValid)
            {
                return View("Thanks", guestReponse);
            }
            else 
            {
                return View();
            }

        }

    }
}
