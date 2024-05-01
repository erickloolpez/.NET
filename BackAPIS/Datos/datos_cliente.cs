using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class datos_cliente : IDatos<cliente>
    {
        IntegracionDBBEntities _context;

        public datos_cliente()
        {
            _context = new IntegracionDBBEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<cliente> Listar()
        {
            return _context.cliente.ToList();
        }

        public cliente LeerID(string id)
        {
            return _context.cliente.Where(c => c.id == id).FirstOrDefault();
        }

        public void Insertar(cliente nuevo_cliente)
        {
            _context.cliente.Add(nuevo_cliente);
            _context.SaveChanges();
        }

        public bool Actualizar(cliente cliente_actualizado)
        {
            cliente clienteTemp = LeerID(cliente_actualizado.id);

            if (clienteTemp != null)
            {
                clienteTemp.nombre = cliente_actualizado.nombre;
                clienteTemp.apellido = cliente_actualizado.apellido;
                clienteTemp.email = cliente_actualizado.email;

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
            cliente clienteTemp = LeerID(id);

            if(clienteTemp != null)
            {
                _context.cliente.Remove(clienteTemp);
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
