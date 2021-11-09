using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudio.Models
{
    [Table ("t_proyectos")]
    public class Proyectos
    {
        public int id {get;set;}

        [Required]
        public string nombre{get;set;}

        
        public string imagen{get;set;}

        [Required]
        public string descripcion{get;set;}

        
        public string lugar{get;set;}

        public decimal precio{get;set;}
        public string estado{get;set;}
    }
}