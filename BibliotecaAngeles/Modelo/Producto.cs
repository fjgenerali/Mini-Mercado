using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BibliotecaAngeles.Modelo
{
    public class Producto
    {
        [Key]
        public int idProducto { get; set; }
        [Required]
        public string codigoDeBarras { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public decimal pCosto { get; set; }
        [Required]
        public decimal pVenta { get; set; }
        [Required]
        public decimal porsGanancia { get; set; }
        [Required]
        public decimal stockActual { get; set; }
        [Required]
        public decimal iva { get; set; }
        [Required]
        public decimal stockMinimo { get; set; }

    }
}
