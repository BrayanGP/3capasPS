using GarPer._3CapasAzure.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3CapasAzure.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Pruebas
        public ActionResult Index()
        {
            
            return View(new AyudaNegocio().pruebasNegocio("select","","",0));
        }
    }
}