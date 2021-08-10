using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using BibliotecaAngeles.Modelo;
using BibliotecaAngeles;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Angeles.Controlers
{
   public  class UsuariosController : Controller
    {
        private BibliotecaAngeles.Modelo.AngelesContext db = new BibliotecaAngeles.Modelo.AngelesContext();
        
        public bool agregarUsuario(string cedula, string nombre ,string clave ,string tipo)
        {
            Usuario u1 = new Usuario();
            bool retorno = false;

            var losUsu = from u2
             in db.Usuarios
                         where u2.cedula == cedula && u2.clave == clave
                         select u2;
            foreach (var usu in losUsu)
            {
                u1.clave = usu.clave;
                u1.idUsuario = usu.idUsuario;
                u1.nombre = usu.nombre;

            }

            if (u1.clave!=clave && u1.cedula!=cedula)
             {
            
            u1.cedula = cedula;
            u1.clave = clave;
            u1.tipoUsuario = tipo;
            u1.nombre = nombre;
            db.Usuarios.Add(u1);
            db.SaveChanges(); 
            retorno = true;
            }
            return retorno;
        }

        public bool logearUsuario(string nick , string clave)
        {
            bool retorno = false;
            
            if (LoginData.key == clave && LoginData.Admin == nick)
            {
                LoginData.loginID = nick;
                LoginData.pass = clave;
                LoginData.soyAdmin = true;
                retorno = true;
                return retorno;
            }
            Usuario u1 = new Usuario();
            List<Usuario> misUsuarios = new List<Usuario>();

            var losUsu = from u
                         in db.Usuarios                       
                         select u;
            foreach (var usu in losUsu)
            {
                if ( usu.nombre == nick && usu.clave == clave)
                {          
                    LoginData.loginID = usu.nombre;
                    LoginData.pass = usu.clave;
                    retorno = true;
                }             
            }            
            return retorno;
        }
    }
}
