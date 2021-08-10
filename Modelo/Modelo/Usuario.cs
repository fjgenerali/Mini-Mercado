using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelo.Modelo
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        [Required]
        public int cedula { get; set; }
        [Required]
        public int nombre { get; set; }
        [Required]
        public string clave { get; set; }
        [Required]
        public string tipoUsuario { get; set; }
    }
}
