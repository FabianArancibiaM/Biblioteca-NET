﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca.Web.ServiceReferenceCliente {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceCliente.IClienteS")]
    public interface IClienteS {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteS/create", ReplyAction="http://tempuri.org/IClienteS/createResponse")]
        bool create(int edadN, int idN, string nombreN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteS/create", ReplyAction="http://tempuri.org/IClienteS/createResponse")]
        System.Threading.Tasks.Task<bool> createAsync(int edadN, int idN, string nombreN);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteSChannel : Biblioteca.Web.ServiceReferenceCliente.IClienteS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteSClient : System.ServiceModel.ClientBase<Biblioteca.Web.ServiceReferenceCliente.IClienteS>, Biblioteca.Web.ServiceReferenceCliente.IClienteS {
        
        public ClienteSClient() {
        }
        
        public ClienteSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool create(int edadN, int idN, string nombreN) {
            return base.Channel.create(edadN, idN, nombreN);
        }
        
        public System.Threading.Tasks.Task<bool> createAsync(int edadN, int idN, string nombreN) {
            return base.Channel.createAsync(edadN, idN, nombreN);
        }
    }
}
