using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAngeles.Modelo
{  
    public   class CarritoVirtual
    {

      public static  List<ProductoVirtual> productoVirtuals { get; set; }
      public static decimal cambioCliente { get; set; }
      public static decimal total { get; set; }
      public static bool contado { get; set; }
      public static int cliente { get; set; }
    }
}
