using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Logica;
using Cache;
using Datos;
using System.Runtime.InteropServices;

namespace Logica
{
    public class logica_factura
    {
        cache_general<factura, datos_factura> cacheGeneral = new cache_general<factura, datos_factura>();
        
        public List<factura> Listar()
        {
            return cacheGeneral.Listar();
        }

        public factura LeerID(string id)
        {
            return cacheGeneral.Listar().Where(f => f.id == id).FirstOrDefault();
        }
        public List<factura> ListarFiltro(string info)
        {
            List<factura> listTemp;

            if (String.IsNullOrEmpty(info))
            {
                return cacheGeneral.Listar();
            }
            else
            {
                listTemp = new List<factura>();
                listTemp.Add(LeerID(info));

                if (listTemp[0] == null)
                {
                    return cacheGeneral.Listar().Where(f => f.suscripcion_id.Contains(info)).ToList();
                }
                else
                {
                    return listTemp;
                }
            }
        }

        public void Insertar(factura factura_nueva)
        {
           cacheGeneral.Insertar(factura_nueva);
        }

        public bool Actualizar(factura factura_actualizada)
        {
           return cacheGeneral.Actualizar(factura_actualizada);
        }
        
        public bool Eliminar(string id)
        {
            return cacheGeneral.Eliminar(id);
        }

    }
}
