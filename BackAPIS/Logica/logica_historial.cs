using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;
using Cache;

namespace Logica
{
    public class logica_historial
    {
        cache_general<historial_plan, datos_historial> cacheGeneral = new cache_general<historial_plan, datos_historial> ();

        public List<historial_plan> Listar()
        {
            return cacheGeneral.Listar();
        }

        public historial_plan LeerID(string id)
        {
            int parsedValue = Convert.ToInt32(id);
            return cacheGeneral.Listar().Where(h => h.id == parsedValue).FirstOrDefault();
        }
        public List<historial_plan> ListarFiltro(string info)
        {
            List<historial_plan> listTemp;

            if (String.IsNullOrEmpty(info))
            {
                return cacheGeneral.Listar();
            }
            else
            {
                listTemp = new List<historial_plan>();
                listTemp.Add(LeerID(info));

                if (listTemp[0] == null)
                {
                    return cacheGeneral.Listar().Where(h => h.suscripcion_id.Contains(info)).ToList();
                }
                else
                {
                    return listTemp;
                }
            }
        }

        public void Insertar(historial_plan historial_nuevo)
        {
            cacheGeneral.Insertar(historial_nuevo);
        }

        public bool Actualizar(historial_plan historial_actualizado)
        {
            return cacheGeneral.Actualizar(historial_actualizado);
        }

        public bool Eliminar(string id)
        {
            return cacheGeneral.Eliminar(id);
        }

    }
}
