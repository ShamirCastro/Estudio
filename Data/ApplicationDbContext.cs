using System;
using System.Collections.Generic;
using System.Text;
using Estudio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Estudio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {         
        }
        public DbSet<Comentarios> Comentarios{get;set;}
        public DbSet<Proyectos> Proyectos{get;set;}
        public DbSet<Consultoria> Consultoria{get;set;}
        public DbSet<DiseñoArquitectonico> DiseñoArquitectonico{get;set;}
        public DbSet<Construccion> Construccion{get;set;}
        public DbSet<Saneamiento> Saneamiento{get;set;}
        public DbSet<ProcesoCons> ProcesoCons{get;set;}
        public DbSet<ProcesoConstruccion> ProcesoConstruccion{get;set;}
        public DbSet<ProcesoDA> ProcesoDA{get;set;}
        public DbSet<ProcesoSa> ProcesoSa{get;set;}

        

        

        


    }
}