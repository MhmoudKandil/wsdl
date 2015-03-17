﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wsdltest.RedPillS {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TriangleType", Namespace="http://schemas.datacontract.org/2004/07/RedBillLibrary")]
    public enum TriangleType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Equilateral = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Isosceles = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scalene = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://KnockKnock.readify.net", ConfigurationName="RedPillS.IRedPill")]
    public interface IRedPill {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatIsYourToken", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenResponse")]
        System.Guid WhatIsYourToken();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis", ReplyAction="http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        wsdltest.RedPillS.TriangleType WhatShapeIsThis(int a, int b, int c);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRedPillChannel : wsdltest.RedPillS.IRedPill, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RedPillClient : System.ServiceModel.ClientBase<wsdltest.RedPillS.IRedPill>, wsdltest.RedPillS.IRedPill {
        
        public RedPillClient() {
        }
        
        public RedPillClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RedPillClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RedPillClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RedPillClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Guid WhatIsYourToken() {
            return base.Channel.WhatIsYourToken();
        }
        
        public wsdltest.RedPillS.TriangleType WhatShapeIsThis(int a, int b, int c) {
            return base.Channel.WhatShapeIsThis(a, b, c);
        }
    }
}
