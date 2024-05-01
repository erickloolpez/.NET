using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoDatos;
using AccesoDatos.DTO;
using Logica;

namespace APIBacks
{
    /// <summary>
    /// Descripción breve de API_MostrarServicioPMA
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class API_MostrarServicioPMA : System.Web.Services.WebService
    {
        logica_suscripcion logica = new logica_suscripcion();
        Servicio servicio = new Servicio("Pago Membresia","Pago del servicio de awita.");

        [WebMethod]
        public Servicio mostrarServicio()
        {
            return servicio;
        }

        [WebMethod]
        public List<MostrarPagosPMA> mostrarPagosPMA(string cedula)
        {
            return logica.mostrarPagosPMA(cedula);
        }

        [WebMethod]
        public bool ActualizarEstado(string cod_pago)
        {
            return logica.ActualizarEstado(cod_pago);
        }
        

    }
}
