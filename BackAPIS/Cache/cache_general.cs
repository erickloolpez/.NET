using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Cache
{
    public class cache_general <TEntidad, TDatos> where TDatos:IDatos<TEntidad>, new() where TEntidad : class 
    {
        private static List<TEntidad> cacheEntidad;
        private TDatos datosEntidad = new TDatos();

        public void cargarDatosDesdeBD()
        {
            cacheEntidad = new List<TEntidad>();
            cacheEntidad = datosEntidad.Listar();
        }

        public List<TEntidad> Listar()
        {
                cargarDatosDesdeBD();
            return cacheEntidad;
        }

        public void Insertar(TEntidad tentidad)
        {
            datosEntidad.Insertar(tentidad);
            cargarDatosDesdeBD();
        }

        public bool Actualizar(TEntidad tentidad)
        {
            bool resultado = datosEntidad.Actualizar(tentidad);
            cargarDatosDesdeBD();
            return resultado;
        }

        public bool Eliminar(string id)
        {
            bool resultado = datosEntidad.Eliminar(id);
            cargarDatosDesdeBD();
            return resultado;
        }

    }
}
