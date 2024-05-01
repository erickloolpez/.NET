﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace APIFront.APIFactura {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Api_GestionFacturaSoap", Namespace="http://tempuri.org/")]
    public partial class Api_GestionFactura : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ListarOperationCompleted;
        
        private System.Threading.SendOrPostCallback LeerIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListarFiltroOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertarOperationCompleted;
        
        private System.Threading.SendOrPostCallback ActualizarOperationCompleted;
        
        private System.Threading.SendOrPostCallback EliminarOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Api_GestionFactura() {
            this.Url = global::APIFront.Properties.Settings.Default.APIFront_APIFactura_Api_GestionFactura;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ListarCompletedEventHandler ListarCompleted;
        
        /// <remarks/>
        public event LeerIDCompletedEventHandler LeerIDCompleted;
        
        /// <remarks/>
        public event ListarFiltroCompletedEventHandler ListarFiltroCompleted;
        
        /// <remarks/>
        public event InsertarCompletedEventHandler InsertarCompleted;
        
        /// <remarks/>
        public event ActualizarCompletedEventHandler ActualizarCompleted;
        
        /// <remarks/>
        public event EliminarCompletedEventHandler EliminarCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Listar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public factura[] Listar() {
            object[] results = this.Invoke("Listar", new object[0]);
            return ((factura[])(results[0]));
        }
        
        /// <remarks/>
        public void ListarAsync() {
            this.ListarAsync(null);
        }
        
        /// <remarks/>
        public void ListarAsync(object userState) {
            if ((this.ListarOperationCompleted == null)) {
                this.ListarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListarOperationCompleted);
            }
            this.InvokeAsync("Listar", new object[0], this.ListarOperationCompleted, userState);
        }
        
        private void OnListarOperationCompleted(object arg) {
            if ((this.ListarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListarCompleted(this, new ListarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LeerID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public factura LeerID(string id) {
            object[] results = this.Invoke("LeerID", new object[] {
                        id});
            return ((factura)(results[0]));
        }
        
        /// <remarks/>
        public void LeerIDAsync(string id) {
            this.LeerIDAsync(id, null);
        }
        
        /// <remarks/>
        public void LeerIDAsync(string id, object userState) {
            if ((this.LeerIDOperationCompleted == null)) {
                this.LeerIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLeerIDOperationCompleted);
            }
            this.InvokeAsync("LeerID", new object[] {
                        id}, this.LeerIDOperationCompleted, userState);
        }
        
        private void OnLeerIDOperationCompleted(object arg) {
            if ((this.LeerIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LeerIDCompleted(this, new LeerIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListarFiltro", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public factura[] ListarFiltro(string info) {
            object[] results = this.Invoke("ListarFiltro", new object[] {
                        info});
            return ((factura[])(results[0]));
        }
        
        /// <remarks/>
        public void ListarFiltroAsync(string info) {
            this.ListarFiltroAsync(info, null);
        }
        
        /// <remarks/>
        public void ListarFiltroAsync(string info, object userState) {
            if ((this.ListarFiltroOperationCompleted == null)) {
                this.ListarFiltroOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListarFiltroOperationCompleted);
            }
            this.InvokeAsync("ListarFiltro", new object[] {
                        info}, this.ListarFiltroOperationCompleted, userState);
        }
        
        private void OnListarFiltroOperationCompleted(object arg) {
            if ((this.ListarFiltroCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListarFiltroCompleted(this, new ListarFiltroCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Insertar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Insertar(factura factura_nueva) {
            this.Invoke("Insertar", new object[] {
                        factura_nueva});
        }
        
        /// <remarks/>
        public void InsertarAsync(factura factura_nueva) {
            this.InsertarAsync(factura_nueva, null);
        }
        
        /// <remarks/>
        public void InsertarAsync(factura factura_nueva, object userState) {
            if ((this.InsertarOperationCompleted == null)) {
                this.InsertarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertarOperationCompleted);
            }
            this.InvokeAsync("Insertar", new object[] {
                        factura_nueva}, this.InsertarOperationCompleted, userState);
        }
        
        private void OnInsertarOperationCompleted(object arg) {
            if ((this.InsertarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertarCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Actualizar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Actualizar(factura factura_actualizada) {
            object[] results = this.Invoke("Actualizar", new object[] {
                        factura_actualizada});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ActualizarAsync(factura factura_actualizada) {
            this.ActualizarAsync(factura_actualizada, null);
        }
        
        /// <remarks/>
        public void ActualizarAsync(factura factura_actualizada, object userState) {
            if ((this.ActualizarOperationCompleted == null)) {
                this.ActualizarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnActualizarOperationCompleted);
            }
            this.InvokeAsync("Actualizar", new object[] {
                        factura_actualizada}, this.ActualizarOperationCompleted, userState);
        }
        
        private void OnActualizarOperationCompleted(object arg) {
            if ((this.ActualizarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ActualizarCompleted(this, new ActualizarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Eliminar", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Eliminar(factura factura_eliminada) {
            object[] results = this.Invoke("Eliminar", new object[] {
                        factura_eliminada});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void EliminarAsync(factura factura_eliminada) {
            this.EliminarAsync(factura_eliminada, null);
        }
        
        /// <remarks/>
        public void EliminarAsync(factura factura_eliminada, object userState) {
            if ((this.EliminarOperationCompleted == null)) {
                this.EliminarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEliminarOperationCompleted);
            }
            this.InvokeAsync("Eliminar", new object[] {
                        factura_eliminada}, this.EliminarOperationCompleted, userState);
        }
        
        private void OnEliminarOperationCompleted(object arg) {
            if ((this.EliminarCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EliminarCompleted(this, new EliminarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class factura {
        
        private string idField;
        
        private string suscripcion_idField;
        
        private System.Nullable<int> plan_historial_idField;
        
        private System.DateTime fecha_inicioField;
        
        private System.DateTime fecha_finalField;
        
        private decimal totalField;
        
        private System.Nullable<System.DateTime> factura_canceladaField;
        
        private historial_plan historial_planField;
        
        private suscripcion suscripcionField;
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string suscripcion_id {
            get {
                return this.suscripcion_idField;
            }
            set {
                this.suscripcion_idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> plan_historial_id {
            get {
                return this.plan_historial_idField;
            }
            set {
                this.plan_historial_idField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime fecha_inicio {
            get {
                return this.fecha_inicioField;
            }
            set {
                this.fecha_inicioField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime fecha_final {
            get {
                return this.fecha_finalField;
            }
            set {
                this.fecha_finalField = value;
            }
        }
        
        /// <remarks/>
        public decimal total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> factura_cancelada {
            get {
                return this.factura_canceladaField;
            }
            set {
                this.factura_canceladaField = value;
            }
        }
        
        /// <remarks/>
        public historial_plan historial_plan {
            get {
                return this.historial_planField;
            }
            set {
                this.historial_planField = value;
            }
        }
        
        /// <remarks/>
        public suscripcion suscripcion {
            get {
                return this.suscripcionField;
            }
            set {
                this.suscripcionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class historial_plan {
        
        private factura[] facturaField;
        
        private planes planesField;
        
        private suscripcion suscripcionField;
        
        private int idField;
        
        private string suscripcion_idField;
        
        private string plan_idField;
        
        private System.DateTime fecha_comienzoField;
        
        private System.DateTime fecha_finalField;
        
        private System.Nullable<System.DateTime> creado_enField;
        
        /// <remarks/>
        public factura[] factura {
            get {
                return this.facturaField;
            }
            set {
                this.facturaField = value;
            }
        }
        
        /// <remarks/>
        public planes planes {
            get {
                return this.planesField;
            }
            set {
                this.planesField = value;
            }
        }
        
        /// <remarks/>
        public suscripcion suscripcion {
            get {
                return this.suscripcionField;
            }
            set {
                this.suscripcionField = value;
            }
        }
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string suscripcion_id {
            get {
                return this.suscripcion_idField;
            }
            set {
                this.suscripcion_idField = value;
            }
        }
        
        /// <remarks/>
        public string plan_id {
            get {
                return this.plan_idField;
            }
            set {
                this.plan_idField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime fecha_comienzo {
            get {
                return this.fecha_comienzoField;
            }
            set {
                this.fecha_comienzoField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime fecha_final {
            get {
                return this.fecha_finalField;
            }
            set {
                this.fecha_finalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> creado_en {
            get {
                return this.creado_enField;
            }
            set {
                this.creado_enField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class planes {
        
        private historial_plan[] historial_planField;
        
        private suscripcion[] suscripcionField;
        
        private string idField;
        
        private string nombreField;
        
        private string tipoField;
        
        private decimal precioField;
        
        private System.Nullable<System.DateTime> creado_enField;
        
        /// <remarks/>
        public historial_plan[] historial_plan {
            get {
                return this.historial_planField;
            }
            set {
                this.historial_planField = value;
            }
        }
        
        /// <remarks/>
        public suscripcion[] suscripcion {
            get {
                return this.suscripcionField;
            }
            set {
                this.suscripcionField = value;
            }
        }
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
        
        /// <remarks/>
        public string tipo {
            get {
                return this.tipoField;
            }
            set {
                this.tipoField = value;
            }
        }
        
        /// <remarks/>
        public decimal precio {
            get {
                return this.precioField;
            }
            set {
                this.precioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> creado_en {
            get {
                return this.creado_enField;
            }
            set {
                this.creado_enField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class suscripcion {
        
        private cliente clienteField;
        
        private factura[] facturaField;
        
        private historial_plan[] historial_planField;
        
        private planes planesField;
        
        private string idField;
        
        private string cliente_idField;
        
        private string plan_idField;
        
        private System.DateTime fecha_suscripcionField;
        
        private System.Nullable<System.DateTime> creado_enField;
        
        /// <remarks/>
        public cliente cliente {
            get {
                return this.clienteField;
            }
            set {
                this.clienteField = value;
            }
        }
        
        /// <remarks/>
        public factura[] factura {
            get {
                return this.facturaField;
            }
            set {
                this.facturaField = value;
            }
        }
        
        /// <remarks/>
        public historial_plan[] historial_plan {
            get {
                return this.historial_planField;
            }
            set {
                this.historial_planField = value;
            }
        }
        
        /// <remarks/>
        public planes planes {
            get {
                return this.planesField;
            }
            set {
                this.planesField = value;
            }
        }
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string cliente_id {
            get {
                return this.cliente_idField;
            }
            set {
                this.cliente_idField = value;
            }
        }
        
        /// <remarks/>
        public string plan_id {
            get {
                return this.plan_idField;
            }
            set {
                this.plan_idField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime fecha_suscripcion {
            get {
                return this.fecha_suscripcionField;
            }
            set {
                this.fecha_suscripcionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> creado_en {
            get {
                return this.creado_enField;
            }
            set {
                this.creado_enField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class cliente {
        
        private suscripcion[] suscripcionField;
        
        private string idField;
        
        private string nombreField;
        
        private string apellidoField;
        
        private string emailField;
        
        private System.Nullable<System.DateTime> creado_enField;
        
        /// <remarks/>
        public suscripcion[] suscripcion {
            get {
                return this.suscripcionField;
            }
            set {
                this.suscripcionField = value;
            }
        }
        
        /// <remarks/>
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
        
        /// <remarks/>
        public string apellido {
            get {
                return this.apellidoField;
            }
            set {
                this.apellidoField = value;
            }
        }
        
        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> creado_en {
            get {
                return this.creado_enField;
            }
            set {
                this.creado_enField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void ListarCompletedEventHandler(object sender, ListarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public factura[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((factura[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void LeerIDCompletedEventHandler(object sender, LeerIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LeerIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LeerIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public factura Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((factura)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void ListarFiltroCompletedEventHandler(object sender, ListarFiltroCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListarFiltroCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListarFiltroCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public factura[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((factura[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void InsertarCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void ActualizarCompletedEventHandler(object sender, ActualizarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ActualizarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ActualizarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void EliminarCompletedEventHandler(object sender, EliminarCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EliminarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EliminarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591