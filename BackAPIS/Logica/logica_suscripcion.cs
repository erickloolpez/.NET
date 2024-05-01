using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;
using Cache;
using AccesoDatos.DTO;

namespace Logica
{
    public  class logica_suscripcion
    {
        datos_suscripcion datosSuscripcion = new datos_suscripcion(); 
        cache_general<suscripcion, datos_suscripcion> cacheGeneral = new cache_general<suscripcion, datos_suscripcion> ();

        public List<suscripcion> Listar()
        {
            return cacheGeneral.Listar();
        }

        public suscripcion LeerID(string id)
        {
            return cacheGeneral.Listar().Where(s => s.id == id).FirstOrDefault();
        }
        public List<suscripcion> ListarFiltro(string info)
        {
            List<suscripcion> listTemp;

            if (String.IsNullOrEmpty(info))
            {
                return cacheGeneral.Listar();
            }
            else
            {
                listTemp = new List<suscripcion>();
                listTemp.Add(LeerID(info));

                if (listTemp[0] == null)
                {
                    return cacheGeneral.Listar().Where(s => s.plan_id.Contains(info)).ToList();
                }
                else
                {
                    return cacheGeneral.Listar().Where(s => s.cliente_id.Contains(info)).ToList();
                }
            }
        }

        public void Insertar(suscripcion suscripcion_nueva)
        {
            cacheGeneral.Insertar(suscripcion_nueva);
        }

        public bool Actualizar(suscripcion suscripcion_actualizada)
        {
            return cacheGeneral.Actualizar(suscripcion_actualizada);
        }

        public bool Eliminar(suscripcion suscripcion_eliminada)
        {
            return cacheGeneral.Eliminar(suscripcion_eliminada.id);
        }

        public List<MostrarPagosPMA> mostrarPagosPMA(string cedula)
        {
            return datosSuscripcion.mostrarPagosPMA(cedula);
        }
        public bool ActualizarEstado(string cod_pago)
        {
            return datosSuscripcion.ActualizarEstado(cod_pago);
        }
    }
}
