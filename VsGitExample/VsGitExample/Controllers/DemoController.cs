﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VsGitExample.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        { 
        viewbag.name="naresh";
            return View();
        }
    }
}
