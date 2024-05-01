using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Microsoft.SqlServer.Server;

namespace Datos
{
    public class datos_historial : IDatos <historial_plan>
    {
        IntegracionDBBEntities _context;

        public datos_historial()
        {
            _context = new IntegracionDBBEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<historial_plan> Listar()
        {
            return _context.historial_plan.ToList();
        }

        public historial_plan LeerID(string id)
        {
            int parsedValue = Convert.ToInt32(id);
            return _context.historial_plan.Where(h => h.id == parsedValue).FirstOrDefault();
        }

        public void Insertar(historial_plan historial_nuevo)
        {
            _context.historial_plan.Add(historial_nuevo);
            _context.SaveChanges();
        }

        public bool Actualizar(historial_plan historial_actualizado)
        {
            string parsedValue = historial_actualizado.id.ToString();
            historial_plan historialTemp = LeerID(parsedValue);

            if(historialTemp != null)
            {
                historialTemp.suscripcion_id = historial_actualizado.suscripcion_id;
                historialTemp.plan_id = historial_actualizado.plan_id;
                historialTemp.fecha_comienzo = historial_actualizado.fecha_comienzo;
                historialTemp.fecha_final = historial_actualizado.fecha_final;

                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Eliminar(string id)
        {
            historial_plan historialTemp = LeerID(id);

            if(historialTemp != null)
            {
                _context.historial_plan.Remove(historialTemp);
                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
