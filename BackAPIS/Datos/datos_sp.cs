using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class datos_sp
    {
        IntegracionDBBEntities _context;

        public datos_sp()
        {
            _context = new IntegracionDBBEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<sp_SuscripcionesPorPlan_Result> SuscripcionesPorPlan()
        {
            return _context.sp_SuscripcionesPorPlan().ToList();
        }

        public List<sp_IngresosPorPlan_Result> IngresosPorPlan()
        {
            return _context.sp_IngresosPorPlan().ToList();
        }

        public List<sp_TestBanca_Result> TestBanca(string id)
        {
            return _context.sp_TestBanca(id).ToList();
        }

    }
}
