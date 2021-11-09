using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Estudio.Models;

namespace Estudio.Controllers
{
    
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }
        
        public IActionResult Encuesta()
        {
            return View();
        }
        
        public IActionResult ProyectosRealizados()
        {
            return View();
        }
        
        
        public IActionResult Servicios()
        {
            return View();
        }

        public IActionResult ProyectA1()
        {
            return View();
        }
        public IActionResult ProyectA2()
        {
            return View();
        }
        public IActionResult ProyectA3()
        {
            return View();
        }
        public IActionResult ProyectR1()
        {
            return View();
        }
        public IActionResult ProyectR2()
        {
            return View();
        }
        public IActionResult ProyectR3()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
