﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="AppBonus", ConfigurationName="WsBonusEliminarTokenPorUsuario.wselitokusSoapPort")]
    public interface wselitokusSoapPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="AppBonusaction/AWSELITOKUS.Execute", ReplyAction="*")]
        Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteResponse Execute(Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="AppBonusaction/AWSELITOKUS.Execute", ReplyAction="*")]
        System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteResponse> ExecuteAsync(Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="wselitokus.Execute", Namespace="AppBonus", Order=0)]
        public Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteRequestBody Body;
        
        public ExecuteRequest() {
        }
        
        public ExecuteRequest(Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="AppBonus")]
    public partial class ExecuteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Userid;
        
        public ExecuteRequestBody() {
        }
        
        public ExecuteRequestBody(string Userid) {
            this.Userid = Userid;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="wselitokus.ExecuteResponse", Namespace="AppBonus", Order=0)]
        public Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteResponseBody Body;
        
        public ExecuteResponse() {
        }
        
        public ExecuteResponse(Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="AppBonus")]
    public partial class ExecuteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public short Coderror;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Msjerror;
        
        public ExecuteResponseBody() {
        }
        
        public ExecuteResponseBody(short Coderror, string Msjerror) {
            this.Coderror = Coderror;
            this.Msjerror = Msjerror;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wselitokusSoapPortChannel : Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.wselitokusSoapPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wselitokusSoapPortClient : System.ServiceModel.ClientBase<Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.wselitokusSoapPort>, Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.wselitokusSoapPort {
        
        public wselitokusSoapPortClient() {
        }
        
        public wselitokusSoapPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wselitokusSoapPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wselitokusSoapPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wselitokusSoapPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteResponse Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.wselitokusSoapPort.Execute(Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteRequest request) {
            return base.Channel.Execute(request);
        }
        
        public short Execute(string Userid, out string Msjerror) {
            Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteRequest inValue = new Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteRequest();
            inValue.Body = new Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteRequestBody();
            inValue.Body.Userid = Userid;
            Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteResponse retVal = ((Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.wselitokusSoapPort)(this)).Execute(inValue);
            Msjerror = retVal.Body.Msjerror;
            return retVal.Body.Coderror;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteResponse> Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.wselitokusSoapPort.ExecuteAsync(Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteRequest request) {
            return base.Channel.ExecuteAsync(request);
        }
        
        public System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteResponse> ExecuteAsync(string Userid) {
            Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteRequest inValue = new Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteRequest();
            inValue.Body = new Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.ExecuteRequestBody();
            inValue.Body.Userid = Userid;
            return ((Bonus.BusinessServices.WsBonusEliminarTokenPorUsuario.wselitokusSoapPort)(this)).ExecuteAsync(inValue);
        }
    }
}
