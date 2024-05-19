using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Logica;
using AccesoDatos;
using System.Runtime.InteropServices;
using System.Web.Http.Cors;


namespace APIBack_REST.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClientesController : ApiController
    {

        logica_cliente cliente = new logica_cliente();


        // GET: api/Clientes
        // GET: api/Clientes/5
        [HttpGet]
        public List<cliente> listarClientes()
        {
            return cliente.Listar();
        }

        // GET: api/Clientes/5
        [HttpGet]
        public cliente leerID(string id)
        {
            return cliente.LeerID(id);
        }

        // POST: api/Clientes
        [HttpPost]
        public void crearCliente(cliente nuevoCliente)
        {
            cliente.Insertar(nuevoCliente);
        }

        // PUT: api/Clientes/5
        [HttpPut]
        public bool actualizarCliente(cliente clienteActualizado)
        {
            return cliente.Actualizar(clienteActualizado);
        }

        // DELETE: api/Clientes/5
        [HttpDelete]
        public bool eliminarCliente(cliente clienteEliminado)
        {
            return cliente.Eliminar(clienteEliminado.id);
        }
    }
}
