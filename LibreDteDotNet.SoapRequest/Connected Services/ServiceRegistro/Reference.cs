﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceRegistro
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.registroreclamodte.diii.sdi.sii.cl")]
    public partial class Exception
    {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.registroreclamodte.diii.sdi.sii.cl")]
    public partial class DteEventoDocTo
    {
        
        private string codEventoField;
        
        private string descEventoField;
        
        private string rutResponsableField;
        
        private string dvResponsableField;
        
        private string fechaEventoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codEvento
        {
            get
            {
                return this.codEventoField;
            }
            set
            {
                this.codEventoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descEvento
        {
            get
            {
                return this.descEventoField;
            }
            set
            {
                this.descEventoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string rutResponsable
        {
            get
            {
                return this.rutResponsableField;
            }
            set
            {
                this.rutResponsableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string dvResponsable
        {
            get
            {
                return this.dvResponsableField;
            }
            set
            {
                this.dvResponsableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string fechaEvento
        {
            get
            {
                return this.fechaEventoField;
            }
            set
            {
                this.fechaEventoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.registroreclamodte.diii.sdi.sii.cl")]
    public partial class respuestaTo
    {
        
        private int codRespField;
        
        private bool codRespFieldSpecified;
        
        private string descRespField;
        
        private DteEventoDocTo[] listaEventosDocField;
        
        private string rutTokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int codResp
        {
            get
            {
                return this.codRespField;
            }
            set
            {
                this.codRespField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codRespSpecified
        {
            get
            {
                return this.codRespFieldSpecified;
            }
            set
            {
                this.codRespFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descResp
        {
            get
            {
                return this.descRespField;
            }
            set
            {
                this.descRespField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("listaEventosDoc", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        public DteEventoDocTo[] listaEventosDoc
        {
            get
            {
                return this.listaEventosDocField;
            }
            set
            {
                this.listaEventosDocField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string rutToken
        {
            get
            {
                return this.rutTokenField;
            }
            set
            {
                this.rutTokenField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.registroreclamodte.diii.sdi.sii.cl", ConfigurationName="ServiceRegistro.RegistroReclamoDteService")]
    internal interface RegistroReclamoDteService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceRegistro.respuestaTo> consultarDocDteCedibleAsync(string rutEmisor, string dvEmisor, string tipoDoc, string folio);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> consultarFechaRecepcionSiiAsync(string rutEmisor, string dvEmisor, string tipoDoc, string folio);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> getVersionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        //[System.ServiceModel.FaultContractAttribute(typeof(ServiceRegistro.Exception), Action="", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceRegistro.respuestaTo> ingresarAceptacionReclamoDocAsync(string rutEmisor, string dvEmisor, string tipoDoc, string folio, string accionDoc);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ServiceRegistro.respuestaTo> listarEventosHistDocAsync(string rutEmisor, string dvEmisor, string tipoDoc, string folio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    internal interface RegistroReclamoDteServiceChannel : ServiceRegistro.RegistroReclamoDteService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    internal partial class RegistroReclamoDteServiceClient : System.ServiceModel.ClientBase<ServiceRegistro.RegistroReclamoDteService>, ServiceRegistro.RegistroReclamoDteService
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public RegistroReclamoDteServiceClient() : 
                base(RegistroReclamoDteServiceClient.GetDefaultBinding(), RegistroReclamoDteServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.RegistroReclamoDteServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RegistroReclamoDteServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(RegistroReclamoDteServiceClient.GetBindingForEndpoint(endpointConfiguration), RegistroReclamoDteServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RegistroReclamoDteServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(RegistroReclamoDteServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RegistroReclamoDteServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(RegistroReclamoDteServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public RegistroReclamoDteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceRegistro.respuestaTo> consultarDocDteCedibleAsync(string rutEmisor, string dvEmisor, string tipoDoc, string folio)
        {
            return base.Channel.consultarDocDteCedibleAsync(rutEmisor, dvEmisor, tipoDoc, folio);
        }
        
        public System.Threading.Tasks.Task<string> consultarFechaRecepcionSiiAsync(string rutEmisor, string dvEmisor, string tipoDoc, string folio)
        {
            return base.Channel.consultarFechaRecepcionSiiAsync(rutEmisor, dvEmisor, tipoDoc, folio);
        }
        
        public System.Threading.Tasks.Task<string> getVersionAsync()
        {
            return base.Channel.getVersionAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceRegistro.respuestaTo> ingresarAceptacionReclamoDocAsync(string rutEmisor, string dvEmisor, string tipoDoc, string folio, string accionDoc)
        {
            return base.Channel.ingresarAceptacionReclamoDocAsync(rutEmisor, dvEmisor, tipoDoc, folio, accionDoc);
        }
        
        public System.Threading.Tasks.Task<ServiceRegistro.respuestaTo> listarEventosHistDocAsync(string rutEmisor, string dvEmisor, string tipoDoc, string folio)
        {
            return base.Channel.listarEventosHistDocAsync(rutEmisor, dvEmisor, tipoDoc, folio);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.RegistroReclamoDteServicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.RegistroReclamoDteServicePort))
            {
                return new System.ServiceModel.EndpointAddress("https://ws1.sii.cl/WSREGISTRORECLAMODTE/registroreclamodteservice");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return RegistroReclamoDteServiceClient.GetBindingForEndpoint(EndpointConfiguration.RegistroReclamoDteServicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return RegistroReclamoDteServiceClient.GetEndpointAddress(EndpointConfiguration.RegistroReclamoDteServicePort);
        }
        
        public enum EndpointConfiguration
        {
            
            RegistroReclamoDteServicePort,
        }
    }
}
