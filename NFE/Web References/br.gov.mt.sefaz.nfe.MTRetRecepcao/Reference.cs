﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.1433.
// 
#pragma warning disable 1591

namespace srvNFE.br.gov.mt.sefaz.nfe.MTRetRecepcao {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="NfeRetRecepcaoSoapBinding", Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeRetRecepcao")]
    public partial class NfeRetRecepcao : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback nfeRetRecepcaoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public NfeRetRecepcao() {
            this.Url = global::srvNFE.Properties.Settings.Default.srvNFE_br_gov_mt_sefaz_nfe_MTRetRecepcao_NfeRetRecepcao;
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
        public event nfeRetRecepcaoCompletedEventHandler nfeRetRecepcaoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("nfeRetRecepcao", RequestNamespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeRetRecepcao", ResponseNamespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeRetRecepcao", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string nfeRetRecepcao(string nfeCabecMsg, string nfeDadosMsg) {
            object[] results = this.Invoke("nfeRetRecepcao", new object[] {
                        nfeCabecMsg,
                        nfeDadosMsg});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void nfeRetRecepcaoAsync(string nfeCabecMsg, string nfeDadosMsg) {
            this.nfeRetRecepcaoAsync(nfeCabecMsg, nfeDadosMsg, null);
        }
        
        /// <remarks/>
        public void nfeRetRecepcaoAsync(string nfeCabecMsg, string nfeDadosMsg, object userState) {
            if ((this.nfeRetRecepcaoOperationCompleted == null)) {
                this.nfeRetRecepcaoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnnfeRetRecepcaoOperationCompleted);
            }
            this.InvokeAsync("nfeRetRecepcao", new object[] {
                        nfeCabecMsg,
                        nfeDadosMsg}, this.nfeRetRecepcaoOperationCompleted, userState);
        }
        
        private void OnnfeRetRecepcaoOperationCompleted(object arg) {
            if ((this.nfeRetRecepcaoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.nfeRetRecepcaoCompleted(this, new nfeRetRecepcaoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void nfeRetRecepcaoCompletedEventHandler(object sender, nfeRetRecepcaoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class nfeRetRecepcaoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal nfeRetRecepcaoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591