using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IDatos <T> where T : class
    {
        List<T> Listar();

        T LeerID(string id);

        void Insertar(T item);

        bool Actualizar(T item);

        bool Eliminar(string id_entidad);
    }
}
