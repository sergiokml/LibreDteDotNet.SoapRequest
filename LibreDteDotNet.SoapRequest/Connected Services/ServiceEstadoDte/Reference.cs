﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceEstadoDte
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://DefaultNamespace", ConfigurationName="ServiceEstadoDte.QueryEstDte")]
    internal interface QueryEstDte
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceEstadoDte.getVersionResponse> getVersionAsync(ServiceEstadoDte.getVersionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceEstadoDte.getVersionMayorResponse> getVersionMayorAsync(ServiceEstadoDte.getVersionMayorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceEstadoDte.getVersionMenorResponse> getVersionMenorAsync(ServiceEstadoDte.getVersionMenorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceEstadoDte.getVersionPatchResponse> getVersionPatchAsync(ServiceEstadoDte.getVersionPatchRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        //[System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceEstadoDte.getEstDteResponse> getEstDteAsync(ServiceEstadoDte.getEstDteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceEstadoDte.getStateResponse> getStateAsync(ServiceEstadoDte.getStateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getVersion", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getVersionRequest
    {
        
        public getVersionRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getVersionResponse", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getVersionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string getVersionReturn;
        
        public getVersionResponse()
        {
        }
        
        public getVersionResponse(string getVersionReturn)
        {
            this.getVersionReturn = getVersionReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getVersionMayor", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getVersionMayorRequest
    {
        
        public getVersionMayorRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getVersionMayorResponse", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getVersionMayorResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string getVersionMayorReturn;
        
        public getVersionMayorResponse()
        {
        }
        
        public getVersionMayorResponse(string getVersionMayorReturn)
        {
            this.getVersionMayorReturn = getVersionMayorReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getVersionMenor", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getVersionMenorRequest
    {
        
        public getVersionMenorRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getVersionMenorResponse", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getVersionMenorResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string getVersionMenorReturn;
        
        public getVersionMenorResponse()
        {
        }
        
        public getVersionMenorResponse(string getVersionMenorReturn)
        {
            this.getVersionMenorReturn = getVersionMenorReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getVersionPatch", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getVersionPatchRequest
    {
        
        public getVersionPatchRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getVersionPatchResponse", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getVersionPatchResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string getVersionPatchReturn;
        
        public getVersionPatchResponse()
        {
        }
        
        public getVersionPatchResponse(string getVersionPatchReturn)
        {
            this.getVersionPatchReturn = getVersionPatchReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getEstDte", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getEstDteRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string RutConsultante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string DvConsultante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string RutCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string DvCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=4)]
        public string RutReceptor;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=5)]
        public string DvReceptor;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=6)]
        public string TipoDte;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=7)]
        public string FolioDte;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=8)]
        public string FechaEmisionDte;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=9)]
        public string MontoDte;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=10)]
        public string Token;
        
        public getEstDteRequest()
        {
        }
        
        public getEstDteRequest(string RutConsultante, string DvConsultante, string RutCompania, string DvCompania, string RutReceptor, string DvReceptor, string TipoDte, string FolioDte, string FechaEmisionDte, string MontoDte, string Token)
        {
            this.RutConsultante = RutConsultante;
            this.DvConsultante = DvConsultante;
            this.RutCompania = RutCompania;
            this.DvCompania = DvCompania;
            this.RutReceptor = RutReceptor;
            this.DvReceptor = DvReceptor;
            this.TipoDte = TipoDte;
            this.FolioDte = FolioDte;
            this.FechaEmisionDte = FechaEmisionDte;
            this.MontoDte = MontoDte;
            this.Token = Token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getEstDteResponse", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getEstDteResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace= "http://DefaultNamespace", Order=0)]
        public string getEstDteReturn;
        
        public getEstDteResponse()
        {
        }
        
        public getEstDteResponse(string getEstDteReturn)
        {
            this.getEstDteReturn = getEstDteReturn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getState", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getStateRequest
    {
        
        public getStateRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStateResponse", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getStateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string getStateReturn;
        
        public getStateResponse()
        {
        }
        
        public getStateResponse(string getStateReturn)
        {
            this.getStateReturn = getStateReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    internal interface QueryEstDteChannel : ServiceEstadoDte.QueryEstDte, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    internal partial class QueryEstDteClient : System.ServiceModel.ClientBase<ServiceEstadoDte.QueryEstDte>, ServiceEstadoDte.QueryEstDte
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public QueryEstDteClient() : 
                base(QueryEstDteClient.GetDefaultBinding(), QueryEstDteClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.QueryEstDte.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QueryEstDteClient(EndpointConfiguration endpointConfiguration) : 
                base(QueryEstDteClient.GetBindingForEndpoint(endpointConfiguration), QueryEstDteClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QueryEstDteClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(QueryEstDteClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QueryEstDteClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(QueryEstDteClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QueryEstDteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceEstadoDte.getVersionResponse> getVersionAsync(ServiceEstadoDte.getVersionRequest request)
        {
            return base.Channel.getVersionAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceEstadoDte.getVersionMayorResponse> getVersionMayorAsync(ServiceEstadoDte.getVersionMayorRequest request)
        {
            return base.Channel.getVersionMayorAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceEstadoDte.getVersionMenorResponse> getVersionMenorAsync(ServiceEstadoDte.getVersionMenorRequest request)
        {
            return base.Channel.getVersionMenorAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceEstadoDte.getVersionPatchResponse> getVersionPatchAsync(ServiceEstadoDte.getVersionPatchRequest request)
        {
            return base.Channel.getVersionPatchAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceEstadoDte.getEstDteResponse> getEstDteAsync(ServiceEstadoDte.getEstDteRequest request)
        {
            return base.Channel.getEstDteAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceEstadoDte.getStateResponse> getStateAsync(ServiceEstadoDte.getStateRequest request)
        {
            return base.Channel.getStateAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.QueryEstDte))
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
            if ((endpointConfiguration == EndpointConfiguration.QueryEstDte))
            {
                return new System.ServiceModel.EndpointAddress("https://palena.sii.cl/DTEWS/QueryEstDte.jws");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return QueryEstDteClient.GetBindingForEndpoint(EndpointConfiguration.QueryEstDte);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return QueryEstDteClient.GetEndpointAddress(EndpointConfiguration.QueryEstDte);
        }
        
        public enum EndpointConfiguration
        {
            
            QueryEstDte,
        }
    }
}
