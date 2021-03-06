﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.17626
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CEP.EventGenerators.EventReceiverService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EventReceiverService.IEventReceiverService")]
    public interface IEventReceiverService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventReceiverService/SendEvent", ReplyAction="http://tempuri.org/IEventReceiverService/SendEventResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Simulations.Car.SpeedSensor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Simulations.Car.TireSensor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Simulations.Car.LocationSensor))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CEP.Common.Simulations.Car.TirePosition))]
        void SendEvent(CEP.Common.Simulations.Sensor obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventReceiverService/SendEvent", ReplyAction="http://tempuri.org/IEventReceiverService/SendEventResponse")]
        System.Threading.Tasks.Task SendEventAsync(CEP.Common.Simulations.Sensor obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEventReceiverServiceChannel : CEP.EventGenerators.EventReceiverService.IEventReceiverService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EventReceiverServiceClient : System.ServiceModel.ClientBase<CEP.EventGenerators.EventReceiverService.IEventReceiverService>, CEP.EventGenerators.EventReceiverService.IEventReceiverService {
        
        public EventReceiverServiceClient() {
        }
        
        public EventReceiverServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EventReceiverServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventReceiverServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventReceiverServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SendEvent(CEP.Common.Simulations.Sensor obj) {
            base.Channel.SendEvent(obj);
        }
        
        public System.Threading.Tasks.Task SendEventAsync(CEP.Common.Simulations.Sensor obj) {
            return base.Channel.SendEventAsync(obj);
        }
    }
}
