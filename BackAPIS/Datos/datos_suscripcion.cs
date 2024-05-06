using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using AccesoDatos.DTO;

namespace Datos
{
    public class datos_suscripcion : IDatos <suscripcion>
    {
        IntegracionDBBEntities _context;

        public datos_suscripcion()
        {
            _context = new IntegracionDBBEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<suscripcion> Listar()
        {
            return _context.suscripcion.ToList();
        }

        public suscripcion LeerID(string id)
        {
            return _context.suscripcion.Where(s => s.id == id).FirstOrDefault();
        } 


        public void Insertar(suscripcion suscripcion_nueva)
        {
            var id =_context.sp_ID_Suscripcion().FirstOrDefault();

            string[] partes = id.id.Split('-');
            string nombre = partes[0];
            int numero = Convert.ToInt32(partes[1]);

            nombre = $"{nombre}-{numero + 1}";

            suscripcion_nueva.id = nombre;
            suscripcion_nueva.fecha_suscripcion = DateTime.Today;
            suscripcion_nueva.creado_en = DateTime.Now;
            _context.suscripcion.Add(suscripcion_nueva);
            _context.SaveChanges();
        }

        public bool Actualizar(suscripcion suscripcion_actualizada)
        {
            suscripcion suscripcionTemp = LeerID(suscripcion_actualizada.id);

            if (suscripcionTemp != null)
            {
                suscripcionTemp.cliente_id = suscripcion_actualizada.cliente_id;
                suscripcionTemp.plan_id = suscripcion_actualizada.plan_id;
                suscripcionTemp.fecha_suscripcion = suscripcion_actualizada.fecha_suscripcion;

                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool  Eliminar(string id)
        {
            suscripcion suscripcionTemp = LeerID(id);

            if(suscripcionTemp != null)
            {
                _context.suscripcion.Remove(suscripcionTemp);
                _context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }

        }
        public List<MostrarPagosPMA> mostrarPagosPMA(string cedula)
        {
            var consulta = _context.sp_MostrarPagosPMA(cedula).ToList();

            List<MostrarPagosPMA> lista = new List<MostrarPagosPMA>();

            foreach(var item in consulta)
            {
                MostrarPagosPMA mostrar = new MostrarPagosPMA();
                mostrar.cedula = item.cedula;
                mostrar.cod_pago = item.cod_pago;
                mostrar.monto = item.monto;
                mostrar.nServicio = $"Pago Membresia {item.nServicio} Awita";
                lista.Add(mostrar);
            }
            return lista;
        }
        public bool ActualizarEstado(string cod_pago)
        {
            factura facturaModificar = _context.factura.Where(f => f.id == cod_pago).FirstOrDefault();

            if(facturaModificar != null)
            {
                facturaModificar.factura_cancelada = DateTime.Now;
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
