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
  public   class CajaController: Controller
    {
        AngelesContext db = new AngelesContext();

        public ICollection<Boleta> listaBoletasAnio()
        {
            List<Boleta> listaBoletas = new List<Boleta>();
            var lasboletas = from b1
                             in db.Boletas
                             select b1;       
            foreach (var item in lasboletas)
            {
                if (Convert.ToString(item.fecha.Year)==Convert.ToString( DateTime.Now.Year) )         
                listaBoletas.Add((Boleta)item);                
            }
            return listaBoletas;          
        }
        public ICollection<Boleta> listaBoletasMes()
        {
            List<Boleta> listaBoletas = new List<Boleta>();
            var lasboletas = from b1
                             in db.Boletas
                             select b1;
            foreach (var item in lasboletas)
            {
                if (Convert.ToString(item.fecha.Month) == Convert.ToString(DateTime.Now.Month))
                    listaBoletas.Add((Boleta)item);
            }
            return listaBoletas;
        }
        public ICollection<Boleta> listaBoletasDia()
        {
            List<Boleta> listaBoletas = new List<Boleta>();
            var lasboletas = from b1
                             in db.Boletas
                             select b1;
            foreach (var item in lasboletas)
            {
                if (Convert.ToString(item.fecha.Day) == Convert.ToString(DateTime.Now.Day))
                    listaBoletas.Add((Boleta)item);
            }
            return listaBoletas;

        }
        public bool cajaDia()
        {
            bool retorno = false;
            try
            {
                CajaVirtual.CreditoAnio = 0;
                CajaVirtual.CreditoDia = 0;
                CajaVirtual.CreditoMes = 0;
                CajaVirtual.GananciaAnio = 0; 
                CajaVirtual.GananciaDia = 0;
                CajaVirtual.GananciaMes = 0;

                var lasBoletas = from boleta
                      in db.Boletas
                                 select boleta;

                List<Boleta> misB = new List<Boleta>();
                foreach (var item in lasBoletas)
                {
                    if (item.fecha.Day == DateTime.Now.Day)
                    {
                        misB.Add((Boleta)item);
                    }
                }      
                try
                {
                foreach (var item in misB)
                {

                        //   Boleta b = db.Boletas.Find(item.idBoleta);
                        if (item.Cliente > 0)
                        {
                            CajaVirtual.GananciaDia = CajaVirtual.GananciaDia + item.total;
                        }
                        else
                        {
                            CajaVirtual.CreditoDia = CajaVirtual.CreditoDia + item.total;
                        }
                        //   CajaVirtual.Boletas.Add(b);
                        retorno = true;
                    }
                   
                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception)
            {

                throw;  
            }

            return retorno;
        }
        public bool cajaMes()
        {
            CajaVirtual.CreditoAnio = 0;
            CajaVirtual.CreditoDia = 0;
            CajaVirtual.CreditoMes = 0;
            CajaVirtual.GananciaAnio = 0;
            CajaVirtual.GananciaDia = 0;
            CajaVirtual.GananciaMes = 0;
            bool retorno = false;
            try
            {

                var lasBoletas = from boleta
                                 in db.Boletas
                                 select boleta;

                List<Boleta> misB = new List<Boleta>();
                foreach (var item in lasBoletas)
                {
                    if (item.fecha.Month == DateTime.Now.Month)
                    {
                        misB.Add((Boleta)item);
                    }
                }
                try        
                {
                    foreach (var item in misB)
                    {
                        //   Boleta b = db.Boletas.Find(item.idBoleta);
                        if (item.Cliente > 0)
                        {
                            CajaVirtual.GananciaMes = CajaVirtual.GananciaMes + item.total;
                        }
                        else
                        {
                            CajaVirtual.CreditoMes = CajaVirtual.CreditoMes + item.total;
                        }
                        //   CajaVirtual.Boletas.Add(b);
                        retorno = true;
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }

        public bool cajaAnio()
        {
            CajaVirtual.CreditoAnio = 0;
            CajaVirtual.CreditoDia = 0;
            CajaVirtual.CreditoMes = 0;
            CajaVirtual.GananciaAnio = 0;
            CajaVirtual.GananciaDia = 0;
            CajaVirtual.GananciaMes = 0;
            bool retorno = false;
            try
            {

                var lasBoletas = from boleta
                                 in db.Boletas                              
                                 select boleta;

                List<Boleta> misB = new List<Boleta>();
                foreach (var item in lasBoletas)
                {
                    if (item.fecha.Year==DateTime.Now.Year)
                    {
                        misB.Add((Boleta)item);
                    }
                }
                try
                {
                    foreach (var item in misB)
                    {
                        //   Boleta b = db.Boletas.Find(item.idBoleta);
                        if (item.Cliente>0)
                        {
                        CajaVirtual.GananciaAnio= CajaVirtual.GananciaAnio + item.total;
                        }
                        else
                        {
                            CajaVirtual.CreditoAnio = CajaVirtual.CreditoAnio + item.total;
                        }
                        //   CajaVirtual.Boletas.Add(b);
                    }
                        retorno = true;

                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }
    }
}
