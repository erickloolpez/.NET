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
    public class logica_plan 
    {
        cache_general<planes, datos_plan> cacheGeneral = new cache_general<planes, datos_plan> ();

        public List<planes> Listar()
        {
            return cacheGeneral.Listar();
        }

        public planes LeerID(string id)
        {
            return cacheGeneral.Listar().Where(p => p.id == id).FirstOrDefault(); 
        }
        public List<planes> ListarFiltro(string info)
        {
            List<planes> listTemp;

            if (String.IsNullOrEmpty(info))
            {
                return cacheGeneral.Listar();
            }
            else
            {
                listTemp = new List<planes>();
                listTemp.Add(LeerID(info));

                if (listTemp[0] == null)
                {
                    return cacheGeneral.Listar().Where(p => p.nombre.Contains(info)).ToList();
                }
                else
                {
                    return listTemp;
                }
            }
        }

        public void Insertar(planes plan_nuevo)
        {
            cacheGeneral.Insertar(plan_nuevo);
        }

        public bool Actualizar(planes plan_actualizado)
        {
            return cacheGeneral.Actualizar(plan_actualizado);
        }

        public bool Eliminar(string id)
        {
            return cacheGeneral.Eliminar(id);
        }

    }
}
