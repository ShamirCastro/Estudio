using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudio.Models
{
    [Table ("t_procesoDA")]
    public class ProcesoDA
    {

        public int id {get;set;}

        public string procesoDA{get;set;}
        public DiseñoArquitectonico DiseñoArquitectonico { get; set; }
    }
}