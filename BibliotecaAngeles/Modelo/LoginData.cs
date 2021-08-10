using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAngeles.Modelo
{
    public abstract  class LoginData
    {
        public static string loginID { get; set; }
        
        public static string pass { get; set; }

        public static string Admin = "facu";
        public static string key = "123";   
        
        public static bool soyAdmin { get; set; }
        
    }

   
}
