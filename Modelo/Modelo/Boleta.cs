using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelo.Modelo
{
   public  class Boleta
    {
        [Key]
        public int idBoleta { get; set; }
        [Required]
        public string rut { get; set; }
        [Required]
        public DateTime fecha { get; set; }
        [Required]
        public decimal total { get; set; }
    }
}
