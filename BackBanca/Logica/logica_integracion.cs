using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Middleware;
using PatronDisenio;

namespace Logica
{
    public class logica_integracion
    {
        middleware_integracion middlaware = new middleware_integracion();

        public List<DTOTransacciones> listarTransacciones(string id)
        {
            return middlaware.listarTransacciones(id);
        }
    }
}
