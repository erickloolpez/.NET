using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;
using Cache;
using System.Security.Policy;
using System.Runtime.CompilerServices;

namespace Logica
{
    public class logica_cliente
    {
        cache_general<cliente, datos_cliente> cacheGeneral = new cache_general<cliente, datos_cliente>();

        public List<cliente> Listar()
        {
            return cacheGeneral.Listar();
        }

        public cliente LeerID(string id)
        {
            return cacheGeneral.Listar().Where(c => c.id == id).FirstOrDefault();
        }
        public List<cliente> ListarFiltro(string info)
        {
            List<cliente> listTemp;

            if (String.IsNullOrEmpty(info))
            {
                return cacheGeneral.Listar();
            }
            else
            {
                listTemp = new List<cliente>();
                listTemp.Add(LeerID(info));

                if (listTemp[0] == null)
                {
                    return cacheGeneral.Listar().Where(c => c.apellido.Contains(info)).ToList();
                }
                else
                {
                    return listTemp;
                }
            }
        }

        public void Insertar(cliente cliente_nuevo)
        {
            cacheGeneral.Insertar(cliente_nuevo);
        }

        public bool Actualizar(cliente cliente_actualizado)
        {
            return cacheGeneral.Actualizar(cliente_actualizado);
        }

        public bool Eliminar(string id)
        {
            return cacheGeneral.Eliminar(id);
        }

    }
}
