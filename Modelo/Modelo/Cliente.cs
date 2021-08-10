using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Modelo
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public decimal deudaPesos { get; set; }
        public List<Boleta> listaBoletas { get; set; }
    }
}
