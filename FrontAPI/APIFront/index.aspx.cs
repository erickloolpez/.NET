using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using APIFront.APISP;

namespace APIFront
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            APISP.Api_GestionSP sp = new APISP.Api_GestionSP();
            List<sp_SuscripcionesPorPlan_Result> res = sp.SuscripcionesPorPlan().ToList();
            List<sp_IngresosPorPlan_Result> ras = sp.IngresosPorPlan().ToList();

            foreach (var item in res)
            {
                var nombrePlan = item.Nombre_del_plan;
                var numeroSubs = item.Número_de_suscripciones;
                var gomaBungee = $"{nombrePlan}-{numeroSubs},";
                inputBungee.Text += gomaBungee;
            }

            foreach (var item in ras)
            {
                var nombre = item.nombre;
                var ingresos = item.Ingresos_Totales;
                var meetBungee = $"{nombre}-{ingresos},";

                halfBungee.Text += meetBungee;
            }


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            FormView1.ChangeMode(FormViewMode.Insert);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            FormView2.ChangeMode(FormViewMode.Insert);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            FormView3.ChangeMode(FormViewMode.Insert);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            FormView4.ChangeMode(FormViewMode.Insert);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            FormView5.ChangeMode(FormViewMode.Insert);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            APISuscripcion.Api_GestionSuscripcion apiSus = new APISuscripcion.Api_GestionSuscripcion();
            APICliente.Api_GestionCliente apiCli = new APICliente.Api_GestionCliente();

            APICliente.cliente itemCliente;
            APISuscripcion.suscripcion itemSuscripcion;

            string nombre = nombreCliente.Value;
            string apellido = apellidoCliente.Value;
            string email = emailCliente.Value;
            string plan_id = TextBoxPlanID.Text;
            string cedula = inputCI.Value;


            itemCliente = apiCli.LeerID(cedula);

            if (itemCliente != null)
            {
                itemSuscripcion = new APISuscripcion.suscripcion();
                itemSuscripcion.plan_id = plan_id;
                itemSuscripcion.cliente_id = cedula;
                apiSus.Insertar(itemSuscripcion);
            }
            else
            {
                itemCliente = new APICliente.cliente();
                itemCliente.id = cedula;
                itemCliente.nombre = nombre;
                itemCliente.apellido = apellido;
                itemCliente.email = email;
                itemCliente.creado_en = DateTime.Now;
                apiCli.Insertar(itemCliente);


                itemSuscripcion = new APISuscripcion.suscripcion();
                itemSuscripcion.plan_id = plan_id;
                itemSuscripcion.cliente_id = cedula;
                apiSus.Insertar(itemSuscripcion);

            }
            payContainer.Style.Add(HtmlTextWriterStyle.Display, "none");
            payLoading.Style.Add(HtmlTextWriterStyle.Display, "grid");
            lucky.Attributes["class"] += " active";
        }
    }
}