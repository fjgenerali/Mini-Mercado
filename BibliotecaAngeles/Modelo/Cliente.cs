using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BibliotecaAngeles.Modelo
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        [Required]
        public string cedula { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public decimal deudaPesos { get; set; }

        public static ICollection<Boleta> boletas { get; set; }
    }
}
