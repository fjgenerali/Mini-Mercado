using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaAngeles.Modelo;
using BibliotecaAngeles;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Data.Entity;
namespace Angeles.Controlers
{
    public class VentasController : Controller
    {
        private BibliotecaAngeles.Modelo.AngelesContext db = new BibliotecaAngeles.Modelo.AngelesContext();

        public ICollection<Producto> BuscarProducto(string unNombre, string codigoBarras)
        {
            List<Producto> misProd = new List<Producto>();

            var prodcutos = from p
                            in db.Producto.OrderByDescending(s => s.nombre)
                            select p;

            if (!string.IsNullOrEmpty(unNombre))
            {
                prodcutos = prodcutos.Where(s => s.nombre.ToString().Contains(unNombre));
            }
            if (!string.IsNullOrEmpty(codigoBarras))
            {
                string a = Convert.ToString(codigoBarras);
                prodcutos = prodcutos.Where(s => s.codigoDeBarras==(a));
            }


            return prodcutos.ToList();
        }
        public bool agregar(int id)
        {
            bool retorno = false;
            AngelesContext db = new AngelesContext();
            Producto c = db.Producto.Find(id);
            try
            {
                if (CarritoVirtual.productoVirtuals == null)
                {
                    CarritoVirtual.productoVirtuals = new List<ProductoVirtual>();
                    ProductoVirtual p = new ProductoVirtual();
                    p.idProducto = c.idProducto;
                    p.nombre = c.nombre;
                    p.pVenta = c.pVenta;
                    p.cantidad = 1;
                    CarritoVirtual.productoVirtuals.Add(p);
                 retorno = true;
                    
                }
                else
                {
                    ProductoVirtual p = new ProductoVirtual();
                    int itemExistente = getIndex(id);
                    if (itemExistente == -1)
                    {
                        p.idProducto = c.idProducto;
                        p.nombre = c.nombre;
                        p.pVenta = c.pVenta;
                        p.cantidad = 1;
                        CarritoVirtual.productoVirtuals.Add(p);
                    }
                    else
                    {
                        CarritoVirtual.productoVirtuals[itemExistente].cantidad++;
                    }
                    retorno = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
           
            return retorno;
        }
        private int getIndex(int id)
        {
            
            for (int i = 0; i < CarritoVirtual.productoVirtuals.Count; i++)
            {

                if (CarritoVirtual.productoVirtuals[i].idProducto == id)
                {
                    return i;
                }

            }
            return -1;
        }
        public bool venderCredito()
        {
            bool retorno = false;
            AngelesContext db = new AngelesContext();

            try

            {
                
                Boleta b = new Boleta();
                Producto p = new Producto();
                Cliente c = new Cliente();
                List<Detalle> listaDetalles = new List<Detalle>();
                b.fecha = DateTime.Now;
                b.Cliente = CarritoVirtual.cliente;

                b.total = CarritoVirtual.total;
                db.Boletas.Add(b);
                db.SaveChanges();
                foreach (var item in CarritoVirtual.productoVirtuals)
                {
                    Detalle d = new Detalle();
                    d.cantUnidades = item.cantidad;
                    d.precio = item.pVenta;
                    d.producto = item.idProducto;
                    d.boleta = b;
                    db.Detalles.Add(d);
                    p = db.Producto.Find(item.idProducto);
                    p.stockActual = p.stockActual - Convert.ToDecimal(item.cantidad);
                    db.Entry(p).State = EntityState.Modified;

                }
                c = db.Clientes.Find(b.Cliente);
                c.deudaPesos =+ CarritoVirtual.total;
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }
        public bool vaciarCarriro()
        {
            bool retorno = false;
            CarritoVirtual.cambioCliente = 0;
            CarritoVirtual.cliente = -1;
            CarritoVirtual.contado = true;
            CarritoVirtual.productoVirtuals = null;
            CarritoVirtual.total = 0;
            return retorno;
        }
        public bool vender()
        {
            bool retorno = false;
            AngelesContext db = new AngelesContext();

            try

            {
                  
                Boleta b = new Boleta();
                Producto p = new Producto();
                List<Detalle> listaDetalles = new List<Detalle>();
                b.fecha = DateTime.Now;              
                b.total = CarritoVirtual.total;          
                db.Boletas.Add(b);
                db.SaveChanges();
                foreach (var item in CarritoVirtual.productoVirtuals)
                {
                    Detalle d = new Detalle();
                    d.cantUnidades = item.cantidad;
                    d.precio = item.pVenta;
                    d.producto = item.idProducto;
                    d.boleta = b;
                    db.Detalles.Add(d);
                    p = db.Producto.Find(item.idProducto);
                    p.stockActual =p.stockActual - Convert.ToDecimal( item.cantidad);
                    db.Entry(p).State= EntityState.Modified;

                }
                db.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
                  
            return retorno;
        }
        public bool quitarCompra(int id)
        {
            bool retorno=false;
            foreach (var item in CarritoVirtual.productoVirtuals) 
            {
            if (item.idProducto==id && item.cantidad>1)
            {
                    item.cantidad--;
                    return retorno;
            }
            }           
           
            CarritoVirtual.productoVirtuals.RemoveAt(getIndex(id));      

            return retorno;
        }
    }
}
