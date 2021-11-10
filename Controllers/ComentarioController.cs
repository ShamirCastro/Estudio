using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Estudio.Models;
using Estudio.Data;

namespace Estudio.Controllers
{
    public class ComentarioController : Controller
    {
        private readonly ILogger<ComentarioController> _logger;
        private readonly ApplicationDbContext _context;


        public ComentarioController(ILogger<ComentarioController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult MostrarComentarios()
        {
            
            var listcomentarios = _context.Comentarios.ToList();
            ViewData["Message"] = "";
            return View(listcomentarios);
        }

        [HttpGet]
        public IActionResult CrearComentario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearComentario(Comentarios objComentarios)
        {
            _context.Add(objComentarios);
            _context.SaveChanges();            
            TempData["mensaje"] = "El comentario se ha subido correctamente";
            return RedirectToAction("MostrarComentarios");
        }

        public IActionResult EliminarComentario(int id){
            var comentario = _context.Comentarios.Find(id);
            _context.Remove(comentario);
            _context.SaveChanges();
            TempData["mensaje"] = "El mensaje se ha elimnado correctamente";

            
            return RedirectToAction("MostrarComentarios");
        }
        

    }
}
