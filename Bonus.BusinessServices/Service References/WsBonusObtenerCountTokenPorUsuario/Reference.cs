﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="AppBonus", ConfigurationName="WsBonusObtenerCountTokenPorUsuario.wsobtctousSoapPort")]
    public interface wsobtctousSoapPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="AppBonusaction/AWSOBTCTOUS.Execute", ReplyAction="*")]
        Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteResponse Execute(Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="AppBonusaction/AWSOBTCTOUS.Execute", ReplyAction="*")]
        System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteResponse> ExecuteAsync(Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ExecuteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="wsobtctous.Execute", Namespace="AppBonus", Order=0)]
        public Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteRequestBody Body;
        
        public ExecuteRequest() {
        }
        
        public ExecuteRequest(Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteRequestBody Body) {
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
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="wsobtctous.ExecuteResponse", Namespace="AppBonus", Order=0)]
        public Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteResponseBody Body;
        
        public ExecuteResponse() {
        }
        
        public ExecuteResponse(Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="AppBonus")]
    public partial class ExecuteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public short Count;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public short Coderror;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Msjerror;
        
        public ExecuteResponseBody() {
        }
        
        public ExecuteResponseBody(short Count, short Coderror, string Msjerror) {
            this.Count = Count;
            this.Coderror = Coderror;
            this.Msjerror = Msjerror;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsobtctousSoapPortChannel : Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.wsobtctousSoapPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsobtctousSoapPortClient : System.ServiceModel.ClientBase<Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.wsobtctousSoapPort>, Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.wsobtctousSoapPort {
        
        public wsobtctousSoapPortClient() {
        }
        
        public wsobtctousSoapPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsobtctousSoapPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsobtctousSoapPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsobtctousSoapPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteResponse Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.wsobtctousSoapPort.Execute(Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteRequest request) {
            return base.Channel.Execute(request);
        }
        
        public short Execute(string Userid, out short Coderror, out string Msjerror) {
            Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteRequest inValue = new Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteRequest();
            inValue.Body = new Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteRequestBody();
            inValue.Body.Userid = Userid;
            Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteResponse retVal = ((Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.wsobtctousSoapPort)(this)).Execute(inValue);
            Coderror = retVal.Body.Coderror;
            Msjerror = retVal.Body.Msjerror;
            return retVal.Body.Count;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteResponse> Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.wsobtctousSoapPort.ExecuteAsync(Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteRequest request) {
            return base.Channel.ExecuteAsync(request);
        }
        
        public System.Threading.Tasks.Task<Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteResponse> ExecuteAsync(string Userid) {
            Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteRequest inValue = new Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteRequest();
            inValue.Body = new Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.ExecuteRequestBody();
            inValue.Body.Userid = Userid;
            return ((Bonus.BusinessServices.WsBonusObtenerCountTokenPorUsuario.wsobtctousSoapPort)(this)).ExecuteAsync(inValue);
        }
    }
}