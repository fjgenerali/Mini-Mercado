using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BibliotecaAngeles.Modelo
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        [Required]
        public string cedula { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string clave { get; set; }
        [Required]
        public string tipoUsuario { get; set; }
    }
}
