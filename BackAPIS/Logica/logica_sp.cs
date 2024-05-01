using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Logica
{
    public class logica_sp
    {
        datos_sp datosSp = new datos_sp();

        public List<sp_SuscripcionesPorPlan_Result> SuscripcionesPorPlan()
        {
            return datosSp.SuscripcionesPorPlan();
        }

        public List<sp_IngresosPorPlan_Result> IngresosPorPlan()
        {
            return datosSp.IngresosPorPlan();
        }

        public List<sp_TestBanca_Result> TestBanca(string id)
        {
            return datosSp.TestBanca(id);
        }
    }
}
