using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudio.Models
{
    [Table ("t_diseñoArquitectonico")]
    public class DiseñoArquitectonico 
    {

        public int id {get;set;}

        public string descripcionDA{get;set;}
        public string imagenDA{get;set;}
        public ICollection<ProcesoDA> procesoDA { get; set; }
    }
}