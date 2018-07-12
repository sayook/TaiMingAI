﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaiMingAI.Manager.BLL;
using TaiMingAI.Manager.Models;

namespace TaiMingAI.Manager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NavbarManager navbarManager = new NavbarManager();
            ViewBag.NavBar = navbarManager.GetNavbarJson();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}