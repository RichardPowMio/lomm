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

namespace LOTROMusicManager.MyLotroBand {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="MyLotroBandSoap", Namespace="http://MyLotroBand.JoshKraker.com")]
    public partial class MyLotroBand : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetSongListOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSongPartsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MyLotroBand() {
            this.Url = global::LOTROMusicManager.Properties.Settings.Default.LOTROMusicManager_MyLotroBand_MyLotroBand;
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
        public event GetSongListCompletedEventHandler GetSongListCompleted;
        
        /// <remarks/>
        public event GetSongPartsCompletedEventHandler GetSongPartsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://MyLotroBand.JoshKraker.com/GetSongList", RequestNamespace="http://MyLotroBand.JoshKraker.com", ResponseNamespace="http://MyLotroBand.JoshKraker.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SongResponse GetSongList(Credentials C) {
            object[] results = this.Invoke("GetSongList", new object[] {
                        C});
            return ((SongResponse)(results[0]));
        }
        
        /// <remarks/>
        public void GetSongListAsync(Credentials C) {
            this.GetSongListAsync(C, null);
        }
        
        /// <remarks/>
        public void GetSongListAsync(Credentials C, object userState) {
            if ((this.GetSongListOperationCompleted == null)) {
                this.GetSongListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSongListOperationCompleted);
            }
            this.InvokeAsync("GetSongList", new object[] {
                        C}, this.GetSongListOperationCompleted, userState);
        }
        
        private void OnGetSongListOperationCompleted(object arg) {
            if ((this.GetSongListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSongListCompleted(this, new GetSongListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://MyLotroBand.JoshKraker.com/GetSongParts", RequestNamespace="http://MyLotroBand.JoshKraker.com", ResponseNamespace="http://MyLotroBand.JoshKraker.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public PartResponse GetSongParts(Credentials C, int SongId) {
            object[] results = this.Invoke("GetSongParts", new object[] {
                        C,
                        SongId});
            return ((PartResponse)(results[0]));
        }
        
        /// <remarks/>
        public void GetSongPartsAsync(Credentials C, int SongId) {
            this.GetSongPartsAsync(C, SongId, null);
        }
        
        /// <remarks/>
        public void GetSongPartsAsync(Credentials C, int SongId, object userState) {
            if ((this.GetSongPartsOperationCompleted == null)) {
                this.GetSongPartsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSongPartsOperationCompleted);
            }
            this.InvokeAsync("GetSongParts", new object[] {
                        C,
                        SongId}, this.GetSongPartsOperationCompleted, userState);
        }
        
        private void OnGetSongPartsOperationCompleted(object arg) {
            if ((this.GetSongPartsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSongPartsCompleted(this, new GetSongPartsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MyLotroBand.JoshKraker.com")]
    public partial class Credentials {
        
        private string emailField;
        
        private string passwordField;
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MyLotroBand.JoshKraker.com")]
    public partial class Part {
        
        private int partIdField;
        
        private string abcField;
        
        private string partNameField;
        
        private string[] instrumentsField;
        
        /// <remarks/>
        public int PartId {
            get {
                return this.partIdField;
            }
            set {
                this.partIdField = value;
            }
        }
        
        /// <remarks/>
        public string Abc {
            get {
                return this.abcField;
            }
            set {
                this.abcField = value;
            }
        }
        
        /// <remarks/>
        public string PartName {
            get {
                return this.partNameField;
            }
            set {
                this.partNameField = value;
            }
        }
        
        /// <remarks/>
        public string[] Instruments {
            get {
                return this.instrumentsField;
            }
            set {
                this.instrumentsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MyLotroBand.JoshKraker.com")]
    public partial class PartResponse {
        
        private Err eField;
        
        private Part[] partField;
        
        /// <remarks/>
        public Err E {
            get {
                return this.eField;
            }
            set {
                this.eField = value;
            }
        }
        
        /// <remarks/>
        public Part[] Part {
            get {
                return this.partField;
            }
            set {
                this.partField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MyLotroBand.JoshKraker.com")]
    public partial class Err {
        
        private bool hasErrorField;
        
        private string errorMsgField;
        
        /// <remarks/>
        public bool HasError {
            get {
                return this.hasErrorField;
            }
            set {
                this.hasErrorField = value;
            }
        }
        
        /// <remarks/>
        public string ErrorMsg {
            get {
                return this.errorMsgField;
            }
            set {
                this.errorMsgField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MyLotroBand.JoshKraker.com")]
    public partial class Song {
        
        private int songIdField;
        
        private string songNameField;
        
        private System.DateTime createdField;
        
        private string addedByField;
        
        private string artistNameField;
        
        private int numPartsField;
        
        /// <remarks/>
        public int SongId {
            get {
                return this.songIdField;
            }
            set {
                this.songIdField = value;
            }
        }
        
        /// <remarks/>
        public string SongName {
            get {
                return this.songNameField;
            }
            set {
                this.songNameField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Created {
            get {
                return this.createdField;
            }
            set {
                this.createdField = value;
            }
        }
        
        /// <remarks/>
        public string AddedBy {
            get {
                return this.addedByField;
            }
            set {
                this.addedByField = value;
            }
        }
        
        /// <remarks/>
        public string ArtistName {
            get {
                return this.artistNameField;
            }
            set {
                this.artistNameField = value;
            }
        }
        
        /// <remarks/>
        public int NumParts {
            get {
                return this.numPartsField;
            }
            set {
                this.numPartsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://MyLotroBand.JoshKraker.com")]
    public partial class SongResponse {
        
        private Err eField;
        
        private Song[] songField;
        
        /// <remarks/>
        public Err E {
            get {
                return this.eField;
            }
            set {
                this.eField = value;
            }
        }
        
        /// <remarks/>
        public Song[] Song {
            get {
                return this.songField;
            }
            set {
                this.songField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void GetSongListCompletedEventHandler(object sender, GetSongListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSongListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSongListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SongResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SongResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void GetSongPartsCompletedEventHandler(object sender, GetSongPartsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSongPartsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSongPartsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public PartResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PartResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591