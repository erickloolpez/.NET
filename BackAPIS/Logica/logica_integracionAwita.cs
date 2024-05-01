using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.DTO;
using Datos;


namespace Logica
{
    public class logica_integracionAwita
    {
        datos_integracionAwita datosIntegracion = new datos_integracionAwita();

        public List<DTOAwita> tomaTransaccion(string id)
        {
            return datosIntegracion.tomaTransaccion(id);
        }
    }
}
