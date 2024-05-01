using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class datos_factura : IDatos<factura>
    {
        IntegracionDBBEntities _context;

        public datos_factura()
        {
            _context = new IntegracionDBBEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        } 

        public List<factura> Listar()
        {
            return _context.factura.ToList();
        }

        public factura LeerID(string id)
        {
            return _context.factura.Where(f => f.id == id).FirstOrDefault();
        }

        public void Insertar(factura factura_nueva)
        {
            _context.factura.Add(factura_nueva);
            _context.SaveChanges();
        }

        public bool Actualizar(factura factura_actualizada)
        {
            factura facturaTemp = LeerID(factura_actualizada.id);

            if(facturaTemp != null)
            {
                facturaTemp.suscripcion_id = factura_actualizada.suscripcion_id;
                facturaTemp.plan_historial_id = factura_actualizada.plan_historial_id;
                facturaTemp.fecha_inicio = factura_actualizada.fecha_inicio;
                facturaTemp.fecha_final = factura_actualizada.fecha_final;
                facturaTemp.total = factura_actualizada.total;
                facturaTemp.factura_cancelada = factura_actualizada.factura_cancelada;

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
            factura facturaTemp = LeerID(id);

            if (facturaTemp != null)
            {
                _context.factura.Remove(facturaTemp);
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
