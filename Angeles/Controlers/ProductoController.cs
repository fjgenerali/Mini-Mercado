using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaAngeles.Modelo;
using BibliotecaAngeles;
using System.Web.Mvc;
using System.Data.Entity;
namespace Angeles.Controlers
{
    public class ProductoController: Controller
    {
        private BibliotecaAngeles.Modelo.AngelesContext db = new BibliotecaAngeles.Modelo.AngelesContext();
         
        public List<Producto> alertaStock()
        {
            List<Producto> listaP = misProductos() ;
            List<Producto> retorno = new List<Producto>();
            foreach (var p in listaP)
            {     


                if (p.stockActual <= p.stockMinimo)
                    retorno.Add((Producto)p);
            }                      
            return retorno;
        }
        public bool agregarProducto(string nombre, string codigoB, decimal costo,decimal porsG , decimal stock, decimal stockMin)
        {
            bool retorno= false;
            Producto p = new Producto();
            var misP = from p1
                       in db.Producto
                       where p1.codigoDeBarras == codigoB || p1.nombre==nombre
                       select p1;
            if (misP.Count()==0 && stock>stockMin)
            {
                p.codigoDeBarras = codigoB;
                p.nombre = nombre;
                p.pCosto = costo;   
                p.porsGanancia = porsG;
                p.pVenta =costo+( (costo/100)*porsG);
                p.stockActual = stock;
                p.stockMinimo = stockMin;
                db.Producto.Add(p);
                db.SaveChanges();
                retorno = true;
            }
          
            return retorno;
        }
        public List<Producto> misProductos()
        {
            List<Producto> ListaP = new List<Producto>();
            
            var productos = from p
                            in db.Producto
                            select p;
            foreach (var item in productos)
            {
                ListaP.Add((Producto)item);
            }
            return ListaP;
        }
        public bool modificarProducto(int id, string nombre, string codigoB, decimal costo, decimal porsG, decimal stock, decimal stockMin/* ,decimal iva*/)
    {
        bool retorno = false;
            AngelesContext db = new AngelesContext();
            try
            {            
            Producto p=  db.Producto.Find(id);
            p.codigoDeBarras = codigoB;
            p.nombre =nombre ;
            p.pCosto = costo;
            p.porsGanancia = porsG;
            p.pVenta= costo + ((costo / 100) * porsG);
            p.stockActual = stock;
            p.stockMinimo = stockMin;
           // p.iva = iva;
            db.Entry(p).State = EntityState.Modified;
            db.SaveChanges();
            retorno = true;
                      
            }  
            catch (Exception)
            {
                  
                throw;
            }
            return retorno;
    }
    }

}
