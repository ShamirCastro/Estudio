using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estudio.Models
{
    [Table ("t_procesoCons")]
    public class ProcesoCons
    {

        public int id {get;set;}

        public string procesoConsultoria{get;set;}
        public Consultoria Consultoria { get; set; }
    }
}