using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSemana10.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DatosPersonales()
        {
            return View();
        }

        public ActionResult Direccion()
        {
            return View();
        }



        public string Mensaje()
        {
            return "Hola Tecsup";
        }

        public string Mensaje2()
        {
            return "<h1>Hola Tecsup</h1>";
        }


        public List<string> Paises()
        {
            List<string> paises = new List<string>();
            paises.Add("Venezuela");
            paises.Add("Perú");
            return  paises;
        }
    }
}