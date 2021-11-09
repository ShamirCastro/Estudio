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
    public class ServiciosController : Controller
    {
        private readonly ILogger<ServiciosController> _logger;
        private readonly ApplicationDbContext _context;


        public ServiciosController(ILogger<ServiciosController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult DiseñoArquitectonico(){
            
            var diseño = _context.DiseñoArquitectonico.Include( x => x.procesoDA).ToList();          
            
            return View(diseño);
        }

        public IActionResult ModificarDiseño(int? id){
            if(id == null || id == 0){

                    return NotFound();
            }

            var diseño = _context.DiseñoArquitectonico.Find(id);

            if(diseño == null){
                return NotFound();

            } 

            return View(diseño);    
            
        }
        [HttpPost]
        public IActionResult ModificarDiseño(DiseñoArquitectonico objServicios){
            if(ModelState.IsValid){
                _context.DiseñoArquitectonico.Update(objServicios);
                _context.SaveChanges();
                
                TempData["mensaje"] = "El proyecto se ha actualizado correctamente";
                return RedirectToAction("DiseñoArquitectonico");
            }
            return View ();
        } 


        public IActionResult Construccion(){
            var construccion = _context.Construccion.Include( x => x.procesoConstruccion).ToList();          
            
            return View(construccion);
        }

        public IActionResult ModificarConstruccion(int? id){
            if(id == null || id == 0){

                    return NotFound();
            }

            var construccion = _context.Construccion.Find(id);

            if(construccion == null){
                return NotFound();

            } 

            return View(construccion);    
            
        }
        [HttpPost]
        public IActionResult ModificarConstruccion(Construccion objConstruccion){
            if(ModelState.IsValid){
                _context.Construccion.Update(objConstruccion);
                _context.SaveChanges();
                
                TempData["mensaje"] = "El proyecto se ha actualizado correctamente";
                return RedirectToAction("Construccion");
            }
            return View ();
        }    

        public IActionResult Consultoria(){
            var consultoria = _context.Consultoria.Include( x => x.procesoConsultoria).ToList();          
            
            return View(consultoria);
        }
        public IActionResult ModificarConsultoria(int? id){
            if(id == null || id == 0){

                    return NotFound();
            }

            var consultoria = _context.Consultoria.Find(id);

            if(consultoria == null){
                return NotFound();

            } 

            return View(consultoria);    
            
        }
        [HttpPost]
        public IActionResult ModificarConsultoria(Consultoria objConsultoria){
            if(ModelState.IsValid){
                _context.Consultoria.Update(objConsultoria);
                _context.SaveChanges();
                
                TempData["mensaje"] = "El proyecto se ha actualizado correctamente";
                return RedirectToAction("Conusltoria");
            }
            return View ();
        }

        public IActionResult Saneamiento(){
            var saneamiento = _context.Saneamiento.Include( x => x.procesoSa).ToList();          
            
            return View(saneamiento);
        }

        public IActionResult ModificarSaneamiento(int? id){
            if(id == null || id == 0){

                    return NotFound();
            }

            var saneamiento = _context.Saneamiento.Find(id);

            if(saneamiento == null){
                return NotFound();

            } 

            return View(saneamiento);    
            
        }
        [HttpPost]
        public IActionResult ModificarSaneamiento(Saneamiento objSaneamiento){
            if(ModelState.IsValid){
                _context.Saneamiento.Update(objSaneamiento);
                _context.SaveChanges();
                
                TempData["mensaje"] = "El proyecto se ha actualizado correctamente";
                return RedirectToAction("Saneamiento");
            }
            return View ();
        }
        public IActionResult AñadirDatos(){
            return View();
        }
       [HttpPost]

        public IActionResult AñadirDatos(DiseñoArquitectonico objServicios, ProcesoDA objProceso){
            _context.Add(objServicios);
            _context.Add(objProceso);
            _context.SaveChanges();
            TempData["mensaje"] = "El proceso se ha subido correctamente";
            return RedirectToAction("Servicios");
        }
        
        
        
        

    }
}
