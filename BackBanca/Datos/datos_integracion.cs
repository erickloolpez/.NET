using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Datos.APISP;

namespace Datos
{
    public class datos_integracion
    {
        APISP.Api_GestionIntegracion api = new Api_GestionIntegracion();
        List<APISP.DTOAwita> lstDtoAwita = new List<DTOAwita>();

        public List<APISP.DTOAwita> tomaTransaccion(string id)
        {
            lstDtoAwita = api.tomaTransaccion(id).ToList();
            return lstDtoAwita;

        }
        
    }
}
