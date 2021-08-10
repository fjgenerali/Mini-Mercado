using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAngeles.Modelo
{
   public abstract  class CajaVirtual
    {
        public static decimal GananciaAnio { get; set; }
        public static decimal GananciaMes { get; set; }
        public static decimal GananciaDia { get; set; }

        public static decimal CreditoDia { get; set; }
        public static decimal CreditoMes { get; set; }
        public static decimal CreditoAnio { get; set; }

        public static List<Boleta> Boletas { get; set; }
        public static List<Detalle> Detalles { get; set; }
    }
}
