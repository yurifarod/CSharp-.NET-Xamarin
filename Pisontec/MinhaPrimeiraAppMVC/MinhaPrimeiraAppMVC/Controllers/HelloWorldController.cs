using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinhaPrimeiraAppMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        /*public ActionResult Index()
        {
            return View();
        }*/

        public string Index(int id, string nome)
        {
            string retorno = "<div align = center><h1>Meu id: " + id + "<br>Meu nome: " + nome + "</h1></div>";
            return retorno;
        }

        public string BemVindo()
        {
            return "Bem vindo ao meu mundo!";
        }
    }
}