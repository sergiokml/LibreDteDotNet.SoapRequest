﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceSemilla
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://DefaultNamespace", ConfigurationName="ServiceSemilla.CrSeed")]
    internal interface CrSeed
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceSemilla.getVersionMayorResponse> getVersionMayorAsync(ServiceSemilla.getVersionMayorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceSemilla.getVersionMenorResponse> getVersionMenorAsync(ServiceSemilla.getVersionMenorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceSemilla.getVersionPatchResponse> getVersionPatchAsync(ServiceSemilla.getVersionPatchRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        //[System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceSemilla.getSeedResponse> getSeedAsync(ServiceSemilla.getSeedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceSemilla.getStateResponse> getStateAsync(ServiceSemilla.getStateRequest request);
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="getSeed", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getSeedRequest
    {
        
        public getSeedRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getSeedResponse", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getSeedResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace= "http://DefaultNamespace", Order=0)]
        public string getSeedReturn;
        
        public getSeedResponse()
        {
        }
        
        public getSeedResponse(string getSeedReturn)
        {
            this.getSeedReturn = getSeedReturn;
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
    internal interface CrSeedChannel : ServiceSemilla.CrSeed, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    internal partial class CrSeedClient : System.ServiceModel.ClientBase<ServiceSemilla.CrSeed>, ServiceSemilla.CrSeed
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CrSeedClient() : 
                base(CrSeedClient.GetDefaultBinding(), CrSeedClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.CrSeed.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrSeedClient(EndpointConfiguration endpointConfiguration) : 
                base(CrSeedClient.GetBindingForEndpoint(endpointConfiguration), CrSeedClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrSeedClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CrSeedClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrSeedClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CrSeedClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrSeedClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceSemilla.getVersionMayorResponse> getVersionMayorAsync(ServiceSemilla.getVersionMayorRequest request)
        {
            return base.Channel.getVersionMayorAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceSemilla.getVersionMenorResponse> getVersionMenorAsync(ServiceSemilla.getVersionMenorRequest request)
        {
            return base.Channel.getVersionMenorAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceSemilla.getVersionPatchResponse> getVersionPatchAsync(ServiceSemilla.getVersionPatchRequest request)
        {
            return base.Channel.getVersionPatchAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceSemilla.getSeedResponse> getSeedAsync(ServiceSemilla.getSeedRequest request)
        {
            return base.Channel.getSeedAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceSemilla.getStateResponse> getStateAsync(ServiceSemilla.getStateRequest request)
        {
            return base.Channel.getStateAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CrSeed))
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
            if ((endpointConfiguration == EndpointConfiguration.CrSeed))
            {
                return new System.ServiceModel.EndpointAddress("https://palena.sii.cl/DTEWS/CrSeed.jws");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CrSeedClient.GetBindingForEndpoint(EndpointConfiguration.CrSeed);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CrSeedClient.GetEndpointAddress(EndpointConfiguration.CrSeed);
        }
        
        public enum EndpointConfiguration
        {
            
            CrSeed,
        }
    }
}
