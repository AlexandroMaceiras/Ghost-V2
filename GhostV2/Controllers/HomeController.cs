﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GhostV2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Ghost.";
            ViewBag.Versao = "Versão 2.0.1 - 06 de março de 2017";

            return View();
        }
        public ActionResult InfoFunciona()
        {
            ViewBag.Message = "Apresentação:";

            return View();
        }
        public ActionResult InfoModulos()
        {
            ViewBag.Message = "Veja:";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Entre em contato.";

            return View();
        }
    }
}