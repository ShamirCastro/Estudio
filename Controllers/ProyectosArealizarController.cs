using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Estudio.Models;
using Estudio.Data;
using Microsoft.EntityFrameworkCore;


namespace Estudio.Controllers
{
    public class ProyectosArealizar : Controller
    {
        private readonly ILogger<ProyectosArealizar> _logger;
        private readonly ApplicationDbContext _context;


        public ProyectosArealizar(ILogger<ProyectosArealizar> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<IActionResult> ProyectosRealizados(string searchString)
        {
            ViewData["CurrentFilter"]=searchString;
            var proyectos = from o in _context.Proyectos select o;
 
            if (!String.IsNullOrEmpty(searchString) ){
                proyectos = proyectos.Where(o=>o.nombre.Contains(searchString) || o.descripcion.Contains(searchString));
            }
            
            
            return View(await proyectos.ToListAsync());
            
        }
        public async Task<IActionResult> ProyectosRealizar(string searchString)
        {
            ViewData["CurrentFilter"]=searchString;
            var proyectos = from o in _context.Proyectos select o;
 
            if (!String.IsNullOrEmpty(searchString) ){
                proyectos = proyectos.Where(o=>o.nombre.Contains(searchString) || o.descripcion.Contains(searchString));
            }
            
            
            return View(await proyectos.ToListAsync());
            
        }
        
        public IActionResult CrearProyectoRealizar()
        {            
            return View();
            
        }
        [HttpPost]
        public IActionResult CrearProyectoRealizar(Proyectos objProyect)
        {            
            _context.Add(objProyect);
            _context.SaveChanges();
            TempData["mensaje"] = "El proyecto se ha subido correctamente";
            return RedirectToAction("ProyectosRealizar");
            
        }

        [HttpGet]
        public IActionResult EditarProyectoRealizar(int? id )
        { 

                if(id == null || id == 0){

                    return NotFound();
            }

            var proyecto = _context.Proyectos.Find(id);

            if(proyecto == null){
                return NotFound();

            } 

            return View(proyecto);           
         }
        
        
        [HttpPost]

        public IActionResult EditarProyectoRealizar(Proyectos proyecto){

            if(ModelState.IsValid){
                _context.Proyectos.Update(proyecto);
                _context.SaveChanges();
                
                TempData["mensaje"] = "El proyecto se ha actualizado correctamente";
                return RedirectToAction("ProyectosRealizar");
            }
            return View ();
        }   
        
        [HttpGet]
        public async Task<IActionResult> Caracteristicas(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proyecto = await _context.Proyectos
                .FirstOrDefaultAsync(m => m.id == id);
            if (proyecto == null)
            {
                return NotFound();
            }

            return View(proyecto);
        }
     
    }
}
