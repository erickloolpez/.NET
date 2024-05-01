using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using AccesoDatos.DTO;

namespace Datos
{
    public class datos_integracionAwita
    {
        public List<DTOAwita> tomaTransaccion(string id)
        {
            datos_sp datosSp = new datos_sp();
            List<sp_TestBanca_Result> testBancaTemp;
            testBancaTemp = datosSp.TestBanca(id).ToList();
            DTOAwita dtoAwita;
            List<DTOAwita> lstDTOAwita = new List<DTOAwita>();

            foreach (var item in testBancaTemp)
            {
                dtoAwita = new DTOAwita();
                dtoAwita.cuenta_id = item.id;
                dtoAwita.monto = item.precio;
                dtoAwita.fecha = item.fecha_suscripcion;

                lstDTOAwita.Add(dtoAwita);
            }
            return lstDTOAwita;
        }
    }
}
