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

        [Required(ErrorMessage = "Porfavor ingrese el nombre")]
        public string nombre{get;set;}

        [Required(ErrorMessage = "Porfavor ingrese la url de la imagen")]
        public string imagen{get;set;}

        [Required(ErrorMessage = "Porfavor ingrese la descripcion")]
        public string descripcion{get;set;}

        [Required(ErrorMessage = "Porfavor ingrese la locacion del proyecto")]
        public string lugar{get;set;}

        [Required(ErrorMessage = "Porfavor ingrese el precio del proyecto")]
        public decimal precio{get;set;}

        [Required(ErrorMessage = "Porfavor ingrese el estado del proyecto")]
        public string estado{get;set;}
    }
}