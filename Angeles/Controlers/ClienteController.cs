using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaAngeles.Modelo;
using BibliotecaAngeles;
using System.Web.Mvc;

  
  
namespace Angeles.Controlers
{
    public  class ClienteController: Controller
    {
        private BibliotecaAngeles.Modelo.AngelesContext db = new BibliotecaAngeles.Modelo.AngelesContext();
     public bool agregarCliente(string ci,string nomb, decimal deuda)
        {
            bool retorno = false;

            Cliente c = new Cliente();
            c.nombre = nomb;
            c.cedula = ci;
            c.deudaPesos = deuda;
            Cliente c1 = null;


               var cli = from clien
               in db.Clientes
               
               select clien;
               foreach (var misCli in cli)
            {
                if (c.cedula==misCli.cedula)
                {
                    c1 = misCli;
                }                                                          
            }

            if (c1==null)
            {

                db.Clientes.Add(c);
                db.SaveChanges();
                retorno = true;
            }
           
            return retorno;
        }
    }
}
