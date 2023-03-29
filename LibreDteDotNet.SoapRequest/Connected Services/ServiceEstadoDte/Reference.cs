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
        //[System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getEstDteReturn")]
        System.Threading.Tasks.Task<string> getEstDteAsync(string RutConsultante, string DvConsultante, string RutCompania, string DvCompania, string RutReceptor, string DvReceptor, string TipoDte, string FolioDte, string FechaEmisionDte, string MontoDte, string Token);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getVersionReturn")]
        System.Threading.Tasks.Task<string> getVersionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getVersionMayorReturn")]
        System.Threading.Tasks.Task<string> getVersionMayorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getVersionMenorReturn")]
        System.Threading.Tasks.Task<string> getVersionMenorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getVersionPatchReturn")]
        System.Threading.Tasks.Task<string> getVersionPatchAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="getStateReturn")]
        System.Threading.Tasks.Task<string> getStateAsync();
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
        
        public System.Threading.Tasks.Task<string> getEstDteAsync(string RutConsultante, string DvConsultante, string RutCompania, string DvCompania, string RutReceptor, string DvReceptor, string TipoDte, string FolioDte, string FechaEmisionDte, string MontoDte, string Token)
        {
            return base.Channel.getEstDteAsync(RutConsultante, DvConsultante, RutCompania, DvCompania, RutReceptor, DvReceptor, TipoDte, FolioDte, FechaEmisionDte, MontoDte, Token);
        }
        
        public System.Threading.Tasks.Task<string> getVersionAsync()
        {
            return base.Channel.getVersionAsync();
        }
        
        public System.Threading.Tasks.Task<string> getVersionMayorAsync()
        {
            return base.Channel.getVersionMayorAsync();
        }
        
        public System.Threading.Tasks.Task<string> getVersionMenorAsync()
        {
            return base.Channel.getVersionMenorAsync();
        }
        
        public System.Threading.Tasks.Task<string> getVersionPatchAsync()
        {
            return base.Channel.getVersionPatchAsync();
        }
        
        public System.Threading.Tasks.Task<string> getStateAsync()
        {
            return base.Channel.getStateAsync();
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
