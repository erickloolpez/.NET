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

namespace Datos.APISP {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="Api_GestionIntegracionSoap", Namespace="http://tempuri.org/")]
    public partial class Api_GestionIntegracion : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback tomaTransaccionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Api_GestionIntegracion() {
            this.Url = global::Datos.Properties.Settings.Default.Datos_APISP_Api_GestionIntegracion;
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
        public event tomaTransaccionCompletedEventHandler tomaTransaccionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/tomaTransaccion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DTOAwita[] tomaTransaccion(string id) {
            object[] results = this.Invoke("tomaTransaccion", new object[] {
                        id});
            return ((DTOAwita[])(results[0]));
        }
        
        /// <remarks/>
        public void tomaTransaccionAsync(string id) {
            this.tomaTransaccionAsync(id, null);
        }
        
        /// <remarks/>
        public void tomaTransaccionAsync(string id, object userState) {
            if ((this.tomaTransaccionOperationCompleted == null)) {
                this.tomaTransaccionOperationCompleted = new System.Threading.SendOrPostCallback(this.OntomaTransaccionOperationCompleted);
            }
            this.InvokeAsync("tomaTransaccion", new object[] {
                        id}, this.tomaTransaccionOperationCompleted, userState);
        }
        
        private void OntomaTransaccionOperationCompleted(object arg) {
            if ((this.tomaTransaccionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.tomaTransaccionCompleted(this, new tomaTransaccionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class DTOAwita {
        
        private string idField;
        
        private string cuenta_idField;
        
        private decimal montoField;
        
        private System.DateTime fechaField;
        
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
        public string cuenta_id {
            get {
                return this.cuenta_idField;
            }
            set {
                this.cuenta_idField = value;
            }
        }
        
        /// <remarks/>
        public decimal monto {
            get {
                return this.montoField;
            }
            set {
                this.montoField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void tomaTransaccionCompletedEventHandler(object sender, tomaTransaccionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class tomaTransaccionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal tomaTransaccionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DTOAwita[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DTOAwita[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591