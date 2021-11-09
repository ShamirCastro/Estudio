using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudio.Models
{
    [Table ("t_saneamiento")]
    public class Saneamiento 
    {

        public int id {get;set;}

        public string descripcionSa{get;set;}
        public string imagenSa{get;set;}
        public ICollection<ProcesoSa> procesoSa { get; set; }
    }
}