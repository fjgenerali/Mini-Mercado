using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BibliotecaAngeles.Modelo
{
   public  class Boleta
    {
        [Key]
        public int idBoleta { get; set; }
        [Required]
       
        public DateTime fecha { get; set; }
        [Required]
        public decimal total { get; set; }
        public int Cliente { get; set; }
        
       
    }
}
