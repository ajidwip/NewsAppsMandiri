﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace News.services {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService1", Namespace="http://tempuri.org/")]
    public partial class BasicHttpBinding_IService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SP_GetCountryOperationCompleted;
        
        private System.Threading.SendOrPostCallback SP_GetCategoryOperationCompleted;
        
        private System.Threading.SendOrPostCallback SP_GetNewsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BasicHttpBinding_IService1() {
            this.Url = "http://194.233.71.252/WcfNews/Service1.svc";
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
        public event SP_GetCountryCompletedEventHandler SP_GetCountryCompleted;
        
        /// <remarks/>
        public event SP_GetCategoryCompletedEventHandler SP_GetCategoryCompleted;
        
        /// <remarks/>
        public event SP_GetNewsCompletedEventHandler SP_GetNewsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/SP_GetCountry", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Temp SP_GetCountry() {
            object[] results = this.Invoke("SP_GetCountry", new object[0]);
            return ((Temp)(results[0]));
        }
        
        /// <remarks/>
        public void SP_GetCountryAsync() {
            this.SP_GetCountryAsync(null);
        }
        
        /// <remarks/>
        public void SP_GetCountryAsync(object userState) {
            if ((this.SP_GetCountryOperationCompleted == null)) {
                this.SP_GetCountryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSP_GetCountryOperationCompleted);
            }
            this.InvokeAsync("SP_GetCountry", new object[0], this.SP_GetCountryOperationCompleted, userState);
        }
        
        private void OnSP_GetCountryOperationCompleted(object arg) {
            if ((this.SP_GetCountryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SP_GetCountryCompleted(this, new SP_GetCountryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/SP_GetCategory", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Temp SP_GetCategory() {
            object[] results = this.Invoke("SP_GetCategory", new object[0]);
            return ((Temp)(results[0]));
        }
        
        /// <remarks/>
        public void SP_GetCategoryAsync() {
            this.SP_GetCategoryAsync(null);
        }
        
        /// <remarks/>
        public void SP_GetCategoryAsync(object userState) {
            if ((this.SP_GetCategoryOperationCompleted == null)) {
                this.SP_GetCategoryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSP_GetCategoryOperationCompleted);
            }
            this.InvokeAsync("SP_GetCategory", new object[0], this.SP_GetCategoryOperationCompleted, userState);
        }
        
        private void OnSP_GetCategoryOperationCompleted(object arg) {
            if ((this.SP_GetCategoryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SP_GetCategoryCompleted(this, new SP_GetCategoryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/SP_GetNews", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Temp SP_GetNews([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string country, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string category, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string query, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string page) {
            object[] results = this.Invoke("SP_GetNews", new object[] {
                        country,
                        category,
                        query,
                        page});
            return ((Temp)(results[0]));
        }
        
        /// <remarks/>
        public void SP_GetNewsAsync(string country, string category, string query, string page) {
            this.SP_GetNewsAsync(country, category, query, page, null);
        }
        
        /// <remarks/>
        public void SP_GetNewsAsync(string country, string category, string query, string page, object userState) {
            if ((this.SP_GetNewsOperationCompleted == null)) {
                this.SP_GetNewsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSP_GetNewsOperationCompleted);
            }
            this.InvokeAsync("SP_GetNews", new object[] {
                        country,
                        category,
                        query,
                        page}, this.SP_GetNewsOperationCompleted, userState);
        }
        
        private void OnSP_GetNewsOperationCompleted(object arg) {
            if ((this.SP_GetNewsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SP_GetNewsCompleted(this, new SP_GetNewsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    // CODEGEN: The optional WSDL extension element 'PolicyReference' from namespace 'http://schemas.xmlsoap.org/ws/2004/09/policy' was not handled.
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpsBinding_IService1", Namespace="http://tempuri.org/")]
    public partial class BasicHttpsBinding_IService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SP_GetCountryOperationCompleted;
        
        private System.Threading.SendOrPostCallback SP_GetCategoryOperationCompleted;
        
        private System.Threading.SendOrPostCallback SP_GetNewsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BasicHttpsBinding_IService1() {
            this.Url = "https://vmi1297892:4433/WcfNews/Service1.svc";
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
        public event SP_GetCountryCompletedEventHandler SP_GetCountryCompleted;
        
        /// <remarks/>
        public event SP_GetCategoryCompletedEventHandler SP_GetCategoryCompleted;
        
        /// <remarks/>
        public event SP_GetNewsCompletedEventHandler SP_GetNewsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/SP_GetCountry", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Temp SP_GetCountry() {
            object[] results = this.Invoke("SP_GetCountry", new object[0]);
            return ((Temp)(results[0]));
        }
        
        /// <remarks/>
        public void SP_GetCountryAsync() {
            this.SP_GetCountryAsync(null);
        }
        
        /// <remarks/>
        public void SP_GetCountryAsync(object userState) {
            if ((this.SP_GetCountryOperationCompleted == null)) {
                this.SP_GetCountryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSP_GetCountryOperationCompleted);
            }
            this.InvokeAsync("SP_GetCountry", new object[0], this.SP_GetCountryOperationCompleted, userState);
        }
        
        private void OnSP_GetCountryOperationCompleted(object arg) {
            if ((this.SP_GetCountryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SP_GetCountryCompleted(this, new SP_GetCountryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/SP_GetCategory", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Temp SP_GetCategory() {
            object[] results = this.Invoke("SP_GetCategory", new object[0]);
            return ((Temp)(results[0]));
        }
        
        /// <remarks/>
        public void SP_GetCategoryAsync() {
            this.SP_GetCategoryAsync(null);
        }
        
        /// <remarks/>
        public void SP_GetCategoryAsync(object userState) {
            if ((this.SP_GetCategoryOperationCompleted == null)) {
                this.SP_GetCategoryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSP_GetCategoryOperationCompleted);
            }
            this.InvokeAsync("SP_GetCategory", new object[0], this.SP_GetCategoryOperationCompleted, userState);
        }
        
        private void OnSP_GetCategoryOperationCompleted(object arg) {
            if ((this.SP_GetCategoryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SP_GetCategoryCompleted(this, new SP_GetCategoryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/SP_GetNews", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public Temp SP_GetNews([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string country, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string category, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string query, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string page) {
            object[] results = this.Invoke("SP_GetNews", new object[] {
                        country,
                        category,
                        query,
                        page});
            return ((Temp)(results[0]));
        }
        
        /// <remarks/>
        public void SP_GetNewsAsync(string country, string category, string query, string page) {
            this.SP_GetNewsAsync(country, category, query, page, null);
        }
        
        /// <remarks/>
        public void SP_GetNewsAsync(string country, string category, string query, string page, object userState) {
            if ((this.SP_GetNewsOperationCompleted == null)) {
                this.SP_GetNewsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSP_GetNewsOperationCompleted);
            }
            this.InvokeAsync("SP_GetNews", new object[] {
                        country,
                        category,
                        query,
                        page}, this.SP_GetNewsOperationCompleted, userState);
        }
        
        private void OnSP_GetNewsOperationCompleted(object arg) {
            if ((this.SP_GetNewsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SP_GetNewsCompleted(this, new SP_GetNewsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WcfTemp")]
    public partial class Temp {
        
        private System.Data.DataTable temptableField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Data.DataTable Temptable {
            get {
                return this.temptableField;
            }
            set {
                this.temptableField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void SP_GetCountryCompletedEventHandler(object sender, SP_GetCountryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SP_GetCountryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SP_GetCountryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Temp Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Temp)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void SP_GetCategoryCompletedEventHandler(object sender, SP_GetCategoryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SP_GetCategoryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SP_GetCategoryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Temp Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Temp)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void SP_GetNewsCompletedEventHandler(object sender, SP_GetNewsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SP_GetNewsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SP_GetNewsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Temp Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Temp)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591