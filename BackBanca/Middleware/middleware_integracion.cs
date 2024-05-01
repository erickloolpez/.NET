using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.APISP;
using PatronDisenio;

namespace Middleware
{
    public class middleware_integracion
    {
        datos_integracion datos = new datos_integracion();

        public List<DTOTransacciones> listarTransacciones(string id)
        {
            List<Datos.APISP.DTOAwita> lstTransaccionAwita = datos.tomaTransaccion(id);

            List<DTOTransacciones> lstTransacciones = new List<DTOTransacciones>();
            DTOTransacciones dtoTransacciones;

            foreach(var item in lstTransaccionAwita)
            {
                dtoTransacciones = new DTOTransacciones();
                dtoTransacciones.monto = item.monto;
                dtoTransacciones.fecha = item.fecha;

                lstTransacciones.Add(dtoTransacciones);
            }
            return lstTransacciones;
        }

    }
}
