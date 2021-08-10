using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BibliotecaAngeles.Modelo
{
    public class Detalle
    {
        [Key]
        public int idDetalle { get; set; }
        [Required]
       
        public decimal precio { get; set; }
        [Required]
        public decimal cantUnidades { get; set; }
        
        [Required]
        public int producto { get; set; }

        public Boleta boleta { get; set; }


    }
}
