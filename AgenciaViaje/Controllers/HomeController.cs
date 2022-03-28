using AgenciaViaje.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AgenciaViaje.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Destinos()
        {
            return View();
        }

        public IActionResult Promocoes()
        {
            return View();
        }

        public IActionResult Contato()

        {
            return View();
        }

        public IActionResult Adm()

        {
            return View();
        }

        public IActionResult CadastrarCliente()

        {
            return View();
        }

        public IActionResult CadastrarDestino()

        {
            return View();
        }

    }
}