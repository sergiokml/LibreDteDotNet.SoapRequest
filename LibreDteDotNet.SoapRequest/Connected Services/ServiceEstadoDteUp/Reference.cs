﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;

using LibreDteDotNet.Common.Models;

namespace ServiceEstadoDteUp
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://DefaultNamespace", ConfigurationName="ServiceEstadoDteUp.QueryEstUp")]
    internal interface QueryEstUp
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        //[System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceEstadoDteUp.getVersionResponse> getVersionAsync(ServiceEstadoDteUp.getVersionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        //[System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceEstadoDteUp.getVersionMayorResponse> getVersionMayorAsync(ServiceEstadoDteUp.getVersionMayorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        //[System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceEstadoDteUp.getVersionMenorResponse> getVersionMenorAsync(ServiceEstadoDteUp.getVersionMenorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        //[System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceEstadoDteUp.getVersionPatchResponse> getVersionPatchAsync(ServiceEstadoDteUp.getVersionPatchRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        //[System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceEstadoDteUp.getEstUpResponse> getEstUpAsync(ServiceEstadoDteUp.getEstUpRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        //[System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        System.Threading.Tasks.Task<ServiceEstadoDteUp.getStateResponse> getStateAsync(ServiceEstadoDteUp.getStateRequest request);
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="getEstUp", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getEstUpRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string RutCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string DvCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string TrackId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string Token;
        
        public getEstUpRequest()
        {
        }
        
        public getEstUpRequest(string RutCompania, string DvCompania, string TrackId, string Token)
        {
            this.RutCompania = RutCompania;
            this.DvCompania = DvCompania;
            this.TrackId = TrackId;
            this.Token = Token;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getEstUpResponse", WrapperNamespace="http://DefaultNamespace", IsWrapped=true)]
    internal partial class getEstUpResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace= "http://DefaultNamespace", Order=0)]
        public string getEstUpReturn;
        
        public getEstUpResponse()
        {
        }
        
        public getEstUpResponse(string getEstUpReturn)
        {
            this.getEstUpReturn = getEstUpReturn;
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
    internal interface QueryEstUpChannel : ServiceEstadoDteUp.QueryEstUp, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    internal partial class QueryEstUpClient : System.ServiceModel.ClientBase<ServiceEstadoDteUp.QueryEstUp>, ServiceEstadoDteUp.QueryEstUp
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public QueryEstUpClient() : 
                base(QueryEstUpClient.GetDefaultBinding(), QueryEstUpClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.QueryEstUp.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QueryEstUpClient(EndpointConfiguration endpointConfiguration) : 
                base(QueryEstUpClient.GetBindingForEndpoint(endpointConfiguration), QueryEstUpClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QueryEstUpClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(QueryEstUpClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QueryEstUpClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(QueryEstUpClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public QueryEstUpClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceEstadoDteUp.getVersionResponse> getVersionAsync(ServiceEstadoDteUp.getVersionRequest request)
        {
            return base.Channel.getVersionAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceEstadoDteUp.getVersionMayorResponse> getVersionMayorAsync(ServiceEstadoDteUp.getVersionMayorRequest request)
        {
            return base.Channel.getVersionMayorAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceEstadoDteUp.getVersionMenorResponse> getVersionMenorAsync(ServiceEstadoDteUp.getVersionMenorRequest request)
        {
            return base.Channel.getVersionMenorAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceEstadoDteUp.getVersionPatchResponse> getVersionPatchAsync(ServiceEstadoDteUp.getVersionPatchRequest request)
        {
            return base.Channel.getVersionPatchAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceEstadoDteUp.getEstUpResponse> getEstUpAsync(ServiceEstadoDteUp.getEstUpRequest request)
        {
            return base.Channel.getEstUpAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceEstadoDteUp.getStateResponse> getStateAsync(ServiceEstadoDteUp.getStateRequest request)
        {
            return base.Channel.getStateAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.QueryEstUp))
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
            if ((endpointConfiguration == EndpointConfiguration.QueryEstUp))
            {
                return new System.ServiceModel.EndpointAddress("https://palena.sii.cl/DTEWS/QueryEstUp.jws");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return QueryEstUpClient.GetBindingForEndpoint(EndpointConfiguration.QueryEstUp);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return QueryEstUpClient.GetEndpointAddress(EndpointConfiguration.QueryEstUp);
        }
        
        public enum EndpointConfiguration
        {
            
            QueryEstUp,
        }
    }
}
