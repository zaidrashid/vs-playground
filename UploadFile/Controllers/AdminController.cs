﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UploadFile.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UploadFile()
        {
            ViewData["Success"] = "";
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult UploadFile(string Title)
        {
            //_DB.Upload.Add(new Upload() { Title = Title });
            //_DB.SaveChanges();

            //int Id = (from a in _DB.Upload

            //          select a.Upload_id).Max();

            //if (Id > 0)
            //{

            
                if (Request.Files["file"].ContentLength > 0)
                {
                    string extension = System.IO.Path.GetExtension(Request.Files["file"].FileName);
                    string path1 = string.Format("{0}/{1}{2}", Server.MapPath("~/documents/Files"), Title, extension);
                    if (System.IO.File.Exists(path1))
                        System.IO.File.Delete(path1);

                    Request.Files["file"].SaveAs(path1);

                }
                ViewData["Success"] = "Success";
            //}
            //else
            //{
            //    ViewData["Success"] = "Upload Failed";
            //}
            return View();
        }

    }
}
