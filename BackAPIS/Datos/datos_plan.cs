using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class datos_plan : IDatos <planes>
    {
        IntegracionDBBEntities _context;
        public datos_plan()
        {
            _context = new IntegracionDBBEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<planes> Listar()
        {
            return _context.planes.ToList();
        }

        public planes LeerID(string id)
        {
            return _context.planes.Where(p => p.id == id).FirstOrDefault();
        }

        public void Insertar(planes plan_nuevo)
        {
            _context.planes.Add(plan_nuevo);
            _context.SaveChanges();
        }
        
        public bool Actualizar(planes plan_actualizado)
        {
            planes planTemp = LeerID(plan_actualizado.id);

            if (planTemp != null)
            {
                planTemp.nombre = plan_actualizado.nombre;
                planTemp.tipo = plan_actualizado.tipo;
                planTemp.precio = plan_actualizado.precio;

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
            planes planTemp = LeerID(id);

            if (planTemp != null)
            {
                _context.planes.Remove(planTemp);
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
