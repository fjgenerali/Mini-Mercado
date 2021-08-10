using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelo.Modelo
{
    public class Detalle
    {
        [Key]
        public int idDetalle { get; set; }
        [Required]
        public DateTime fecha { get; set; }
        [Required]
        public decimal precio { get; set; }
        [Required]
        public decimal cantUnidades { get; set; }
        [Required]
        public decimal iva { get; set; }
        [Required]
        public Producto producto { get; set; }

    }
}
